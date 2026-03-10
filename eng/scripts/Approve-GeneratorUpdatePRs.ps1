<#
.SYNOPSIS
    Approves and enables auto-merge for generator version upgrade PRs that have no code changes.

.DESCRIPTION
    Finds open PRs from the azure-sdk bot that update generator/emitter versions,
    verifies they only modify version/config files (no source code changes),
    then approves and enables auto-merge for each qualifying PR.

    Requires: gh CLI authenticated with permissions to approve and merge PRs.

.PARAMETER DryRun
    If specified, only lists qualifying PRs without approving or merging.

.PARAMETER Repo
    The GitHub repository in owner/repo format. Defaults to Azure/azure-sdk-for-net.

.EXAMPLE
    # Preview what would be approved
    .\Approve-GeneratorUpdatePRs.ps1 -DryRun

    # Approve and enable auto-merge
    .\Approve-GeneratorUpdatePRs.ps1
#>
[CmdletBinding()]
param(
    [switch]$DryRun,
    [string]$Repo = "Azure/azure-sdk-for-net"
)

$ErrorActionPreference = "Stop"

# Title patterns for generator version update PRs
$TitlePatterns = @(
    "^Update azure-typespec/http-client-csharp version to prerelease \d",
    "^Update azure-typespec/http-client-csharp-mgmt version to prerelease \d",
    "^Update UnbrandedGeneratorVersion to \d"
)

# Allowed file path patterns (glob-style, matched with -like)
$AllowedFilePatterns = @(
    "eng/*-emitter-package.json",
    "eng/*-emitter-package-lock.json",
    "eng/centralpackagemanagement/*.props",
    "eng/packages/*/package.json",
    "eng/packages/*/package-lock.json"
)

function Test-FileAllowed {
    param([string]$FilePath)
    foreach ($pattern in $AllowedFilePatterns) {
        if ($FilePath -like $pattern) {
            return $true
        }
    }
    return $false
}

function Test-TitleMatches {
    param([string]$Title)
    foreach ($pattern in $TitlePatterns) {
        if ($Title -match $pattern) {
            return $true
        }
    }
    return $false
}

Write-Host "Searching for open generator update PRs in $Repo..." -ForegroundColor Cyan

# Find open PRs from azure-sdk bot
$prs = gh pr list --repo $Repo --author "azure-sdk" --state open --json number,title,headRefName --limit 50 | ConvertFrom-Json

if (-not $prs -or $prs.Count -eq 0) {
    Write-Host "No open PRs from azure-sdk found." -ForegroundColor Yellow
    exit 0
}

$candidates = @()
foreach ($pr in $prs) {
    if (Test-TitleMatches $pr.title) {
        $candidates += $pr
    }
}

if ($candidates.Count -eq 0) {
    Write-Host "No generator update PRs found among $($prs.Count) open PRs." -ForegroundColor Yellow
    exit 0
}

Write-Host "Found $($candidates.Count) generator update PR(s). Checking for code changes..." -ForegroundColor Cyan
Write-Host ""

$approved = 0
$skipped = 0

foreach ($pr in $candidates) {
    Write-Host "PR #$($pr.number): $($pr.title)" -ForegroundColor White

    # Get changed files
    $files = gh pr diff $pr.number --repo $Repo --name-only
    if (-not $files) {
        Write-Host "  ⚠️  Could not get file list, skipping" -ForegroundColor Yellow
        $skipped++
        continue
    }

    $fileList = $files -split "`n" | Where-Object { $_.Trim() -ne "" }
    $allAllowed = $true

    foreach ($file in $fileList) {
        if (Test-FileAllowed $file) {
            Write-Host "  ✅ $file" -ForegroundColor DarkGray
        } else {
            Write-Host "  ❌ $file (not in allowlist)" -ForegroundColor Red
            $allAllowed = $false
        }
    }

    if (-not $allAllowed) {
        Write-Host "  ⏭️  Skipping: PR contains code changes" -ForegroundColor Yellow
        $skipped++
        Write-Host ""
        continue
    }

    if ($DryRun) {
        Write-Host "  🔍 Would approve and enable auto-merge (dry run)" -ForegroundColor Magenta
    } else {
        Write-Host "  🔄 Approving..." -ForegroundColor Green
        gh pr review $pr.number --repo $Repo --approve --body "Auto-approved: generator version update with no code changes."

        Write-Host "  🔄 Enabling auto-merge (squash)..." -ForegroundColor Green
        gh pr merge $pr.number --repo $Repo --auto --squash

        Write-Host "  ✅ Done! Will merge when CI passes." -ForegroundColor Green
    }

    $approved++
    Write-Host ""
}

Write-Host "Summary: $approved approved, $skipped skipped (out of $($candidates.Count) candidates)" -ForegroundColor Cyan
