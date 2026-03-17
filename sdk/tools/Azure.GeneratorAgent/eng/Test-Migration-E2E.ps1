<#
.SYNOPSIS
    End-to-end test for the Azure GeneratorAgent migration workflow.

.DESCRIPTION
    Validates the GeneratorAgent's migration output against a known-good migration commit.

    The test:
    1. Creates a git worktree at the pre-migration state (parent of the migration commit)
    2. Snapshots the expected post-migration files from the migration commit
    3. Invokes the GeneratorAgent 'migrate' command on the pre-migration state
    4. Produces a diff between the agent's output and the expected migration

.PARAMETER LibraryPath
    Relative path to the SDK library from the repo root (e.g., sdk/cognitivelanguage/Azure.AI.Language.Text).

.PARAMETER MigrationCommitSha
    The commit SHA where the migration was merged.

.PARAMETER LocalSpecsPath
    Path to the local azure-rest-api-specs clone. Defaults to ../azure-rest-api-specs relative to the repo root.

.PARAMETER OutputDiffPath
    Path to write the diff file. Defaults to a temp file.

.PARAMETER SkipAgentInvocation
    If set, skips running the migration and only sets up the worktree and expected snapshot.
    Useful for testing the harness itself.

.PARAMETER UseSkill
    If set, uses the Copilot CLI with the sdk-migration skill instead of the GeneratorAgent tool.
    Requires 'copilot' CLI to be installed and authenticated.

.EXAMPLE
    ./Test-Migration-E2E.ps1 -LibraryPath "sdk/cognitivelanguage/Azure.AI.Language.Text" -MigrationCommitSha "eee894db7c3"

.EXAMPLE
    ./Test-Migration-E2E.ps1 -LibraryPath "sdk/cognitivelanguage/Azure.AI.Language.Text" -MigrationCommitSha "eee894db7c3" -UseSkill
#>

[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [string]$LibraryPath,

    [Parameter(Mandatory = $true)]
    [string]$MigrationCommitSha,

    [Parameter(Mandatory = $false)]
    [string]$LocalSpecsPath,

    [Parameter(Mandatory = $false)]
    [string]$OutputDiffPath,

    [Parameter(Mandatory = $false)]
    [switch]$SkipAgentInvocation,

    [Parameter(Mandatory = $false)]
    [switch]$UseSkill
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

# ----------------------------------------------
# Resolve paths
# ----------------------------------------------

$ScriptDir = $PSScriptRoot
$GeneratorAgentRoot = (Resolve-Path (Join-Path $ScriptDir "..")).Path
$GeneratorAgentCsproj = Join-Path $GeneratorAgentRoot "src" "Azure.GeneratorAgent.csproj"

# Find the repo root by walking up to find .git
$RepoRoot = $GeneratorAgentRoot
while ($RepoRoot -and -not (Test-Path (Join-Path $RepoRoot ".git"))) {
    $RepoRoot = Split-Path $RepoRoot -Parent
}
if (-not $RepoRoot) {
    throw "Unable to find repository root (no .git directory found above $GeneratorAgentRoot)"
}

Write-Host "Repository root: $RepoRoot" -ForegroundColor Cyan
Write-Host "GeneratorAgent project: $GeneratorAgentCsproj" -ForegroundColor Cyan

# Normalize LibraryPath to be relative to repo root
if ([System.IO.Path]::IsPathRooted($LibraryPath)) {
    $resolvedLib = (Resolve-Path $LibraryPath -ErrorAction SilentlyContinue)?.Path ?? $LibraryPath
    $LibraryPath = [System.IO.Path]::GetRelativePath($RepoRoot, $resolvedLib)
}
# Ensure forward-slash separators for git commands
$LibraryPath = $LibraryPath -replace '\\', '/'

Write-Host "Library path (relative): $LibraryPath" -ForegroundColor Cyan

if (-not $LocalSpecsPath) {
    $LocalSpecsPath = Join-Path (Split-Path $RepoRoot -Parent) "azure-rest-api-specs"
}

if (-not $OutputDiffPath) {
    $OutputDiffPath = Join-Path ([System.IO.Path]::GetTempPath()) "migration-e2e-diff.patch"
}

# ----------------------------------------------
# Validate inputs
# ----------------------------------------------

function Validate-Inputs {
    Write-Host "`n=== Validating inputs ===" -ForegroundColor Yellow

    # Validate commit SHA exists
    Write-Host "  Validating commit SHA: $MigrationCommitSha"
    $fullSha = git -C $RepoRoot rev-parse --verify "$MigrationCommitSha^{commit}" 2>&1
    if ($LASTEXITCODE -ne 0) {
        throw "Commit SHA '$MigrationCommitSha' does not exist in the repository. Error: $fullSha"
    }
    $script:FullMigrationCommitSha = $fullSha.Trim()
    Write-Host "  Full commit SHA: $script:FullMigrationCommitSha" -ForegroundColor Green

    # Validate library path exists at the migration commit
    $treeCheck = git -C $RepoRoot ls-tree --name-only "$script:FullMigrationCommitSha" -- $LibraryPath 2>&1
    if ($LASTEXITCODE -ne 0 -or -not $treeCheck) {
        throw "Library path '$LibraryPath' does not exist at commit $MigrationCommitSha"
    }
    Write-Host "  Library path '$LibraryPath' exists at migration commit" -ForegroundColor Green

    # Validate local specs repo
    if (-not (Test-Path $LocalSpecsPath)) {
        throw "Local specs repository not found at '$LocalSpecsPath'. Provide -LocalSpecsPath or clone azure-rest-api-specs alongside this repo."
    }
    Write-Host "  Local specs path: $LocalSpecsPath" -ForegroundColor Green

    # Validate GeneratorAgent project
    if (-not (Test-Path $GeneratorAgentCsproj)) {
        throw "GeneratorAgent project not found at '$GeneratorAgentCsproj'"
    }
    Write-Host "  GeneratorAgent project found" -ForegroundColor Green
}

# ----------------------------------------------
# Find pre-migration parent commit
# ----------------------------------------------

function Get-PreMigrationCommit {
    Write-Host "`n=== Determining pre-migration commit ===" -ForegroundColor Yellow

    # Get the parent commit of the migration commit
    $parentSha = git -C $RepoRoot rev-parse --verify "$script:FullMigrationCommitSha~1" 2>&1
    if ($LASTEXITCODE -ne 0) {
        throw "Unable to determine parent commit of $script:FullMigrationCommitSha. Error: $parentSha"
    }
    $script:PreMigrationCommitSha = $parentSha.Trim()

    Write-Host "  Migration commit: $script:FullMigrationCommitSha" -ForegroundColor Cyan
    Write-Host "  Pre-migration commit (parent): $script:PreMigrationCommitSha" -ForegroundColor Green

    # Show the migration commit message for context
    $commitMsg = git -C $RepoRoot log --format="%s" -1 $script:FullMigrationCommitSha
    Write-Host "  Migration commit message: $commitMsg" -ForegroundColor Cyan
}

# ----------------------------------------------
# Snapshot expected state
# ----------------------------------------------

function Snapshot-ExpectedState {
    Write-Host "`n=== Snapshotting expected migration output ===" -ForegroundColor Yellow

    $script:ExpectedDir = Join-Path ([System.IO.Path]::GetTempPath()) "migration-e2e-expected-$([System.IO.Path]::GetRandomFileName())"
    New-Item -ItemType Directory -Path $script:ExpectedDir -Force | Out-Null

    # Export the library files at the migration commit to the expected directory
    Write-Host "  Exporting files from migration commit to: $script:ExpectedDir"

    # Use git archive to extract just the library directory
    $archiveResult = git -C $RepoRoot archive --format=tar "$script:FullMigrationCommitSha" -- $LibraryPath 2>&1
    if ($LASTEXITCODE -ne 0) {
        throw "Failed to archive library files from migration commit. Error: $archiveResult"
    }

    # Extract to temp directory
    git -C $RepoRoot archive "$script:FullMigrationCommitSha" -- $LibraryPath | tar -x -C $script:ExpectedDir 2>&1
    if ($LASTEXITCODE -ne 0) {
        # Fallback: use git show for each file
        Write-Host "  tar extraction failed, using file-by-file export fallback" -ForegroundColor Yellow
        $files = git -C $RepoRoot ls-tree -r --name-only "$script:FullMigrationCommitSha" -- $LibraryPath
        foreach ($file in $files) {
            $destFile = Join-Path $script:ExpectedDir $file
            $destDir = Split-Path $destFile -Parent
            if (-not (Test-Path $destDir)) {
                New-Item -ItemType Directory -Path $destDir -Force | Out-Null
            }
            git -C $RepoRoot show "${script:FullMigrationCommitSha}:$file" | Set-Content -Path $destFile -NoNewline -Encoding UTF8
        }
    }

    $fileCount = (Get-ChildItem -Path $script:ExpectedDir -Recurse -File).Count
    Write-Host "  Exported $fileCount files to expected snapshot" -ForegroundColor Green
}

# ----------------------------------------------
# Create worktree at pre-migration state
# ----------------------------------------------

function Setup-Worktree {
    Write-Host "`n=== Setting up git worktree at pre-migration state ===" -ForegroundColor Yellow

    $script:WorktreeDir = Join-Path ([System.IO.Path]::GetTempPath()) "migration-e2e-worktree-$([System.IO.Path]::GetRandomFileName())"

    Write-Host "  Creating worktree at: $script:WorktreeDir"
    Write-Host "  Checked out at commit: $script:PreMigrationCommitSha"

    git -C $RepoRoot worktree add --detach $script:WorktreeDir $script:PreMigrationCommitSha 2>&1
    if ($LASTEXITCODE -ne 0) {
        throw "Failed to create git worktree at $script:WorktreeDir"
    }

    # Verify the library exists in the worktree
    $worktreeLibPath = Join-Path $script:WorktreeDir $LibraryPath
    if (-not (Test-Path $worktreeLibPath)) {
        Write-Host "  Warning: Library path does not exist in worktree at pre-migration commit" -ForegroundColor Yellow
        Write-Host "  This may indicate the library was newly created in the migration commit" -ForegroundColor Yellow
        # Create the directory so the agent has something to work with
        New-Item -ItemType Directory -Path $worktreeLibPath -Force | Out-Null
    }
    else {
        $fileCount = (Get-ChildItem -Path $worktreeLibPath -Recurse -File).Count
        Write-Host "  Library has $fileCount files in pre-migration state" -ForegroundColor Green
    }
}

# ----------------------------------------------
# Invoke migration (GeneratorAgent or Copilot Skill)
# ----------------------------------------------

function Invoke-Migration {
    if ($SkipAgentInvocation) {
        Write-Host "`n=== Skipping migration invocation (-SkipAgentInvocation flag set) ===" -ForegroundColor Yellow
        return
    }

    if ($UseSkill) {
        Invoke-CopilotSkill
    }
    else {
        Invoke-GeneratorAgent
    }
}

function Invoke-CopilotSkill {
    Write-Host "`n=== Invoking Copilot CLI with sdk-migration skill ===" -ForegroundColor Yellow

    # Verify copilot CLI is available
    $copilotCmd = Get-Command copilot -ErrorAction SilentlyContinue
    if (-not $copilotCmd) {
        throw "Copilot CLI not found. Install it from https://docs.github.com/en/copilot/using-github-copilot/using-github-copilot-in-the-command-line"
    }
    Write-Host "  Copilot CLI: $($copilotCmd.Source)" -ForegroundColor Green

    $worktreeLibPath = Join-Path $script:WorktreeDir $LibraryPath
    $prompt = "Invoke the sdk-migration skill to migrate the library at $worktreeLibPath"

    Write-Host "  Working directory: $script:WorktreeDir"
    Write-Host "  Prompt: $prompt" -ForegroundColor DarkGray

    $copilotArgs = @(
        "-p", $prompt,
        "--yolo",
        "--no-ask-user"
    )

    Write-Host "  Command: copilot $($copilotArgs -join ' ')" -ForegroundColor DarkGray

    $stdoutLog = Join-Path $script:WorktreeDir "skill-stdout.log"
    $stderrLog = Join-Path $script:WorktreeDir "skill-stderr.log"

    $process = Start-Process -FilePath $copilotCmd.Source -ArgumentList $copilotArgs `
        -WorkingDirectory $script:WorktreeDir `
        -NoNewWindow -PassThru -RedirectStandardOutput $stdoutLog -RedirectStandardError $stderrLog

    # Wait for completion (no timeout)
    $process.WaitForExit()

    $stdout = Get-Content $stdoutLog -Raw -ErrorAction SilentlyContinue
    $stderr = Get-Content $stderrLog -Raw -ErrorAction SilentlyContinue

    if ($stdout) {
        Write-Host "`n  --- Copilot stdout ---" -ForegroundColor DarkGray
        Write-Host $stdout -ForegroundColor DarkGray
    }
    if ($stderr) {
        Write-Host "`n  --- Copilot stderr ---" -ForegroundColor DarkGray
        Write-Host $stderr -ForegroundColor DarkGray
    }

    if ($process.ExitCode -ne 0) {
        Write-Host "  Copilot CLI exited with code $($process.ExitCode)" -ForegroundColor Red
        throw "Copilot CLI failed with exit code $($process.ExitCode)"
    }

    Write-Host "  Copilot skill migration completed successfully" -ForegroundColor Green
}

function Invoke-GeneratorAgent {
    Write-Host "`n=== Invoking GeneratorAgent migrate command ===" -ForegroundColor Yellow

    $worktreeLibPath = Join-Path $script:WorktreeDir $LibraryPath

    Write-Host "  SDK path: $worktreeLibPath"
    Write-Host "  Running GeneratorAgent migrate..."

    # Build the GeneratorAgent first
    Write-Host "  Building GeneratorAgent..." -ForegroundColor Cyan
    $buildResult = dotnet build $GeneratorAgentCsproj --configuration Release --nologo --verbosity quiet 2>&1
    if ($LASTEXITCODE -ne 0) {
        Write-Host "  Build output: $buildResult" -ForegroundColor Red
        throw "Failed to build GeneratorAgent"
    }
    Write-Host "  Build succeeded" -ForegroundColor Green

    # Run the migrate command
    Write-Host "  Executing migration..." -ForegroundColor Cyan
    $env:DOTNET_CLI_TELEMETRY_OPTOUT = "1"

    # Resolve the target framework from the csproj so dotnet run doesn't fail
    # when multiple SDKs are installed
    $framework = (dotnet msbuild $GeneratorAgentCsproj -getProperty:TargetFrameworks -v:q 2>$null).Trim()
    if (-not $framework) {
        $framework = (dotnet msbuild $GeneratorAgentCsproj -getProperty:TargetFramework -v:q 2>$null).Trim()
    }

    # The migrate command takes only sdk-path as a positional argument
    $runArgs = @(
        "run",
        "--project", $GeneratorAgentCsproj,
        "--configuration", "Release",
        "--no-build"
    )
    if ($framework) {
        $runArgs += @("--framework", $framework)
    }
    $runArgs += @(
        "--",
        "migrate",
        $worktreeLibPath
    )

    Write-Host "  Command: dotnet $($runArgs -join ' ')" -ForegroundColor DarkGray

    $process = Start-Process -FilePath "dotnet" -ArgumentList $runArgs `
        -NoNewWindow -PassThru -RedirectStandardOutput (Join-Path $script:WorktreeDir "agent-stdout.log") `
        -RedirectStandardError (Join-Path $script:WorktreeDir "agent-stderr.log")

    # Wait for the agent to finish (no timeout — migrations can take a long time)
    $process.WaitForExit()

    $stdout = Get-Content (Join-Path $script:WorktreeDir "agent-stdout.log") -Raw -ErrorAction SilentlyContinue
    $stderr = Get-Content (Join-Path $script:WorktreeDir "agent-stderr.log") -Raw -ErrorAction SilentlyContinue

    if ($stdout) {
        Write-Host "`n  --- Agent stdout ---" -ForegroundColor DarkGray
        Write-Host $stdout -ForegroundColor DarkGray
    }
    if ($stderr) {
        Write-Host "`n  --- Agent stderr ---" -ForegroundColor DarkGray
        Write-Host $stderr -ForegroundColor DarkGray
    }

    if ($process.ExitCode -ne 0) {
        Write-Host "  GeneratorAgent exited with code $($process.ExitCode)" -ForegroundColor Red
        throw "GeneratorAgent failed with exit code $($process.ExitCode)"
    }

    Write-Host "  GeneratorAgent completed successfully" -ForegroundColor Green
}

# ----------------------------------------------
# Generate diff and report
# ----------------------------------------------

function Generate-DiffReport {
    Write-Host "`n=== Generating diff report ===" -ForegroundColor Yellow

    $worktreeLibPath = Join-Path $script:WorktreeDir $LibraryPath
    $expectedLibPath = Join-Path $script:ExpectedDir $LibraryPath

    if (-not (Test-Path $expectedLibPath)) {
        throw "Expected library path not found at '$expectedLibPath'"
    }

    # Use git diff --no-index to compare the two directories
    # This works even outside a git repo and produces standard unified diff format
    $diffOutput = git diff --no-index --stat -- $expectedLibPath $worktreeLibPath 2>&1
    $diffExitCode = $LASTEXITCODE

    # Generate full diff for the patch file
    $fullDiff = git diff --no-index -- $expectedLibPath $worktreeLibPath 2>&1
    $fullDiffExitCode = $LASTEXITCODE

    # Write the full diff to the output file
    if ($fullDiff) {
        # Clean up temp paths in the diff for readability
        $cleanDiff = ($fullDiff -join "`n") -replace [regex]::Escape($expectedLibPath), "a/$LibraryPath"
        $cleanDiff = $cleanDiff -replace [regex]::Escape($worktreeLibPath), "b/$LibraryPath"
        Set-Content -Path $OutputDiffPath -Value $cleanDiff -Encoding UTF8
    }
    else {
        Set-Content -Path $OutputDiffPath -Value "No differences found." -Encoding UTF8
    }

    # Report results
    Write-Host "`n=== E2E Migration Test Results ===" -ForegroundColor Yellow
    Write-Host "  Library: $LibraryPath" -ForegroundColor Cyan
    Write-Host "  Migration commit: $script:FullMigrationCommitSha" -ForegroundColor Cyan
    Write-Host "  Pre-migration commit: $script:PreMigrationCommitSha" -ForegroundColor Cyan
    Write-Host "  Elapsed so far: $("{0:N1} sec" -f $script:Stopwatch.Elapsed.TotalSeconds)" -ForegroundColor Cyan

    if ($diffExitCode -eq 0) {
        Write-Host "`n  Result: PASS - Agent migration output matches expected migration" -ForegroundColor Green
        Write-Host "  Diff file: $OutputDiffPath (empty - no differences)" -ForegroundColor Green
        return 0
    }
    else {
        Write-Host "`n  Result: DIFFERENCES FOUND" -ForegroundColor Yellow
        Write-Host "`n  Diff summary:" -ForegroundColor Cyan
        if ($diffOutput) {
            foreach ($line in $diffOutput) {
                Write-Host "    $line"
            }
        }
        Write-Host "`n  Full diff written to: $OutputDiffPath" -ForegroundColor Cyan

        # Count changed files
        $changedFiles = ($diffOutput | Where-Object { $_ -match "^\s+\S+.*\|" }).Count
        $summaryLine = $diffOutput | Where-Object { $_ -match "files? changed" } | Select-Object -Last 1
        if ($summaryLine) {
            Write-Host "  Summary: $summaryLine" -ForegroundColor Yellow
        }

        return 1
    }
}

# ----------------------------------------------
# Cleanup
# ----------------------------------------------

function Cleanup {
    Write-Host "`n=== Cleaning up ===" -ForegroundColor Yellow

    if ($script:WorktreeDir -and (Test-Path $script:WorktreeDir)) {
        Write-Host "  Removing worktree: $script:WorktreeDir"
        git -C $RepoRoot worktree remove --force $script:WorktreeDir 2>&1 | Out-Null
        if (Test-Path $script:WorktreeDir) {
            Remove-Item -Recurse -Force $script:WorktreeDir -ErrorAction SilentlyContinue
        }
    }

    if ($script:ExpectedDir -and (Test-Path $script:ExpectedDir)) {
        Write-Host "  Removing expected snapshot: $script:ExpectedDir"
        Remove-Item -Recurse -Force $script:ExpectedDir -ErrorAction SilentlyContinue
    }

    Write-Host "  Cleanup complete" -ForegroundColor Green
}

# ----------------------------------------------
# Main orchestration
# ----------------------------------------------

$script:FullMigrationCommitSha = $null
$script:PreMigrationCommitSha = $null
$script:ExpectedDir = $null
$script:WorktreeDir = $null
$script:Stopwatch = [System.Diagnostics.Stopwatch]::new()
$script:StepTimings = [ordered]@{}
$exitCode = 1

function Measure-Step {
    param([string]$Name, [scriptblock]$Block)
    $sw = [System.Diagnostics.Stopwatch]::StartNew()
    $result = & $Block
    $sw.Stop()
    $script:StepTimings[$Name] = $sw.Elapsed
    return $result
}

try {
    $script:Stopwatch.Start()

    Write-Host "=========================================" -ForegroundColor Cyan
    Write-Host "  GeneratorAgent E2E Migration Test" -ForegroundColor Cyan
    if ($UseSkill) {
        Write-Host "  Mode: Copilot CLI (sdk-migration skill)" -ForegroundColor Cyan
    } elseif ($SkipAgentInvocation) {
        Write-Host "  Mode: Harness only (skip migration)" -ForegroundColor Cyan
    } else {
        Write-Host "  Mode: GeneratorAgent CLI tool" -ForegroundColor Cyan
    }
    Write-Host "=========================================" -ForegroundColor Cyan

    Measure-Step "Validate inputs" { Validate-Inputs }
    Measure-Step "Determine pre-migration commit" { Get-PreMigrationCommit }
    Measure-Step "Snapshot expected state" { Snapshot-ExpectedState }
    Measure-Step "Setup worktree" { Setup-Worktree }
    Measure-Step "Invoke migration" { Invoke-Migration }
    $exitCode = Measure-Step "Generate diff report" { Generate-DiffReport }
}
catch {
    Write-Host "`nERROR: $_" -ForegroundColor Red
    Write-Host $_.ScriptStackTrace -ForegroundColor DarkRed
    $exitCode = 2
}
finally {
    Measure-Step "Cleanup" { Cleanup }
    $script:Stopwatch.Stop()
}

# Print timing summary
Write-Host "`n=== Timing Summary ===" -ForegroundColor Yellow
foreach ($step in $script:StepTimings.GetEnumerator()) {
    $elapsed = $step.Value
    $formatted = if ($elapsed.TotalMinutes -ge 1) {
        "{0:N1} min" -f $elapsed.TotalMinutes
    } else {
        "{0:N1} sec" -f $elapsed.TotalSeconds
    }
    Write-Host ("  {0,-35} {1,10}" -f $step.Key, $formatted)
}
$totalElapsed = $script:Stopwatch.Elapsed
$totalFormatted = if ($totalElapsed.TotalMinutes -ge 1) {
    "{0:N1} min" -f $totalElapsed.TotalMinutes
} else {
    "{0:N1} sec" -f $totalElapsed.TotalSeconds
}
Write-Host ("  {0,-35} {1,10}" -f "TOTAL", $totalFormatted) -ForegroundColor Cyan

Write-Host "`nExiting with code: $exitCode" -ForegroundColor $(if ($exitCode -eq 0) { "Green" } else { "Yellow" })
exit $exitCode
