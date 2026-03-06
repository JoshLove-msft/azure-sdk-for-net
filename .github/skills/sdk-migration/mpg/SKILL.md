---
name: sdk-migration/mpg
description: Migrate an Azure management-plane .NET SDK from Swagger/AutoRest to TypeSpec-based generation. Use when asked to migrate a service, do MPG migration, update spec, or bring SDK to latest TypeSpec.
---
# Skill: sdk-migration/mpg

Migrate an Azure management-plane .NET SDK from Swagger/AutoRest to TypeSpec-based generation.

> **Shared foundation**: This skill extends the `sdk-migration` skill. Follow that skill for common phases (validation, tsp-location.yaml, code generation, build-fix cycle structure, finalization, safety rules). This file covers only management-plane-specific concerns.

## When Invoked

Trigger phrases: "migrate service X", "update spec", "bring SDK to latest", "help with mgmt migration", "mpg migration", "mgmt sdk migration".

## Prerequisites

This skill requires two repositories side by side:

| Path | Purpose |
|------|---------|
| Current repository (`azure-sdk-for-net`) | Azure SDK for .NET mono-repo. SDK packages live under `sdk/<service>/Azure.ResourceManager.<Service>/`. |
| Sibling spec folder (`../azure-rest-api-specs`) | Full or sparse-checkout of the [Azure REST API Specs](https://github.com/Azure/azure-rest-api-specs) repo. TypeSpec specs live under `specification/<service>/resource-manager/Microsoft.<Provider>/<ServiceName>/`. |

If the spec repo is not found at `../azure-rest-api-specs`, ask the user for the path.

## MPG-Specific Inputs

When the user says "migrate service X", resolve:

| Variable | Example | How to find |
|----------|---------|-------------|
| `SERVICE_NAME` | `chaos` | The lowercase service directory name under `sdk/` |
| `PACKAGE_NAME` | `Azure.ResourceManager.Chaos` | Full NuGet package / directory name |
| `SPEC_DIR` | `specification/chaos/resource-manager/Microsoft.Chaos/Chaos` | TypeSpec directory inside azure-rest-api-specs containing `main.tsp` and `tspconfig.yaml` |
| `SPEC_COMMIT` | `37052dfa3f...` | Latest commit hash from `azure-rest-api-specs` for the spec |
| `API_VERSION` | `2025-01-01` | Target API version from the spec |
| `EMITTER_PACKAGE_JSON_PATH` | `eng/azure-typespec-http-client-csharp-mgmt-emitter-package.json` | Always this value for management SDKs |

## Phase 0 — Sync Repositories

Before any migration work, merge the latest `main` branch into both repos:

```powershell
# Sync spec repo
cd ..\azure-rest-api-specs
git fetch origin main
git merge origin/main

# Sync SDK repo
cd ..\azure-sdk-for-net
git fetch origin main
git merge origin/main
```

This ensures specs and SDK tooling are up-to-date. Resolve any merge conflicts before proceeding.

## Phase 1 — Discovery & Planning

Use **explore** agents in parallel to gather information:

1. **Find the spec**: Search `../azure-rest-api-specs/specification/<service>/` for `main.tsp` / `tspconfig.yaml` / OpenAPI JSON files. Determine whether the spec is already TypeSpec or still Swagger-only.
2. **Find the existing SDK**: Check `sdk/<service>/<PACKAGE_NAME>/` for:
   - `tsp-location.yaml` → already migrated (may just need version bump)
   - `src/autorest.md` → legacy Swagger-based, needs migration
3. **Inventory existing csharp customizations in spec**: Search all `.tsp` files in the spec directory for `@clientName("...", "csharp")` and `@@clientName` decorators. Also check for `back-compatible.tsp`. These are already applied and must not be duplicated when adding renames later.
4. **Snapshot old API surface**: Read `api/<PACKAGE_NAME>.net*.cs` and extract all public type names. Store in a lookup table for later rename resolution (Phase 8).
5. **Extract autorest rename mappings**: If `src/autorest.md` exists, extract all `rename-mapping` and `prepend-rp-prefix` entries. Store for comparison after generation.
6. **Identify custom code folder convention**: Check which name the package uses: `Custom/`, `Customization/`, or `Customized/`. Match this convention for all new custom code files.
7. **Review naming conventions**: Consult the `azure-sdk-mgmt-pr-review` skill for naming review rules.

Present a summary plan and **ask the user** to confirm before proceeding.

## Phase 2 — Create/Update `tsp-location.yaml`

Follow the `sdk-migration` skill's "Create/Update tsp-location.yaml" phase with these MPG-specific values:

```yaml
directory: specification/<service>/resource-manager/Microsoft.<Provider>/<ServiceName>
commit: <SPEC_COMMIT>
repo: Azure/azure-rest-api-specs
emitterPackageJsonPath: "eng/azure-typespec-http-client-csharp-mgmt-emitter-package.json"
```

Key rules:
- `directory` must point to the folder containing `main.tsp` and `tspconfig.yaml` in the spec repo.
- `emitterPackageJsonPath` is always `eng/azure-typespec-http-client-csharp-mgmt-emitter-package.json` for management SDKs.
- Target emitter name for commit resolution: `azure-typespec/http-client-csharp-mgmt`
- Optional: `additionalDirectories` array for shared TypeSpec libraries.

## Phase 3 — Handle Legacy `autorest.md`

If `src/autorest.md` exists:
1. Extract key config: `namespace`, `title`, `azure-arm: true`, `require` URL, `output-folder`, directives.
2. **Thoroughly analyze rename mappings** before deleting:
   - Extract ALL `rename-mapping` entries and `prepend-rp-prefix` entries from `autorest.md`.
   - The mgmt emitter auto-handles these naming transforms (anything **not** in this list still needs `@@clientName`):
     - **Model/property suffixes**: `Url`→`Uri`, `Etag`→`ETag`
     - **DateTimeOffset property suffixes**: `Time`→`On`, `Date`→`On`, `DateTime`→`On`, `At`→`On` (e.g. `CreatedAt`→`CreatedOn`). Also transforms word stems: `Creation`→`Created`, `Deletion`→`Deleted`, `Expiration`→`Expire`, `Modification`→`Modified`. Excludes properties starting with `From`/`To` or ending with `PointInTime`.
     - **RP prefix prepending**: Automatically prepends the resource provider name to: `Sku`, `SkuName`, `SkuTier`, `SkuFamily`, `SkuInformation`, `Plan`, `Usage`, `Kind`, `PrivateEndpointConnection`, `PrivateLinkResource`, `PrivateLinkServiceConnectionState`, `PrivateEndpointServiceConnectionStatus`, `PrivateEndpointConnectionProvisioningState`, `PrivateLinkResourceProperties`, `PrivateLinkServiceConnectionStateProperty`, `PrivateEndpointConnectionListResult`, `PrivateLinkResourceListResult`.
     - **Resource update models**: Models using the `ResourceUpdateModel` base type are auto-renamed — `{Resource}Patch` if used only in PATCH, or `{Resource}CreateOrUpdateContent` if used in both CREATE and UPDATE.
   - Most other renames from `autorest.md` will still need `@@clientName` decorators.
   - Do NOT blindly add all renames — check what `@clientName("...", "csharp")` decorators already exist in the spec `.tsp` files (e.g., `back-compatible.tsp`). These are already applied and must not be duplicated.
   - After initial code generation, **compare old vs new public type names** to find which renames are missing. Only add `@@clientName` decorators for types that actually cause build errors.
3. Delete `src/autorest.md` — git history preserves the original content.
4. Do NOT create a `client.tsp` in the SDK repo. The TypeSpec source lives in the spec repo.
5. Map remaining AutoRest directives to TypeSpec customization approach:
   - Model/property renames → `@@clientName(SpecNamespace.SpecTypeName, "SdkName", "csharp")` in spec repo `client.tsp`
   - Accessibility overrides → `@@access(SpecNamespace.TypeName, Access.public, "csharp")` in spec repo `client.tsp` (for types generated as `internal` that need to be `public`)
   - Type mapping overrides → `@@alternateType(SpecNamespace.Model.property, "Azure.ResourceManager.CommonTypes.ResourceIdentifier", "csharp")` for properties that should use SDK types instead of raw strings (e.g., resource IDs)
   - Suppressions → `#suppress` decorators in spec `.tsp` files
   - Format overrides → TypeSpec `@format` / `@encode` decorators

## Phase 4 — SDK Package Structure

Ensure the package directory matches this layout:

```
sdk/<service>/<PACKAGE_NAME>/
├── tsp-location.yaml              # Created in Phase 2
├── src/
│   ├── <PACKAGE_NAME>.csproj      # Inherits from Directory.Build.props
│   ├── Properties/AssemblyInfo.cs
│   ├── Customization/             # Hand-written partial classes (if needed)
│   │   └── <ModelName>.cs         # Override generated behavior
│   └── Generated/                 # Auto-generated (do NOT edit)
├── tests/
├── api/                           # API surface snapshots
├── CHANGELOG.md
├── README.md
├── Directory.Build.props
├── assets.json                    # Test recording assets reference
├── ci.mgmt.yml                    # CI pipeline definition
└── <PACKAGE_NAME>.sln
```

## Phase 5 — Customization (Naming Review)

Apply naming rules from the `azure-sdk-mgmt-pr-review` skill. For detailed customization techniques, invoke the `mitigate-breaking-changes` skill.

In addition to the common customization patterns from the `sdk-migration` skill, MPG uses:
- **Spec-side decorators**: `@@clientName`, `@@access`, `@@markAsPageable`, `@@alternateType` in spec repo `client.tsp`
- **Extension resources**: Parameterized scopes, `ActionSync<>` for sub-resource ops (see the `mitigate-breaking-changes` skill)

## Phase 6 — Code Generation

Follow the `sdk-migration` skill's "Code Generation" phase. MPG adds local spec repo support:

```powershell
cd sdk\<service>\<PACKAGE_NAME>\src

# During iteration — use local spec repo for speed (no need to push spec changes first)
dotnet build /t:GenerateCode /p:LocalSpecRepo=<full-path-to-azure-rest-api-specs>

# For final generation — uses commit from tsp-location.yaml (fetches from remote)
dotnet build /t:GenerateCode
```

After generation, additionally:
- Check ApiCompat with `dotnet pack --no-restore` — ApiCompat errors only surface during pack, not during build.
- Export the API surface: `pwsh eng/scripts/Export-API.ps1 <SERVICE_NAME>`. **CI will fail if not re-exported after migration.**

### Using `RegenSdkLocal.ps1` for Generator Fixes

When you've made local changes to the generator under `eng/packages/http-client-csharp-mgmt/`, use:
```powershell
# Generator-only change (fetches spec from remote)
pwsh eng/packages/http-client-csharp-mgmt/eng/scripts/RegenSdkLocal.ps1 -Services <PACKAGE_NAME>

# Both generator and spec changed (uses local spec repo — no push needed)
pwsh eng/packages/http-client-csharp-mgmt/eng/scripts/RegenSdkLocal.ps1 -Services <PACKAGE_NAME> -LocalSpecRepoPath <full-path-to-azure-rest-api-specs>
```
**Note**: Without `-LocalSpecRepoPath`, this fetches the spec commit from GitHub, so the commit in `tsp-location.yaml` must be pushed to remote.

### Handling ApiCompat Errors

ApiCompat errors surface via `dotnet pack` (not `dotnet build`). See [error-reference.md](https://github.com/Azure/azure-sdk-for-net/blob/main/.github/skills/sdk-migration/mpg/error-reference.md) for the full ApiCompat error pattern table and fix strategies.

## Phase 7 — CI & Changelog

**Do NOT hand-author or manually edit `metadata.json`** — it is auto-generated by the `tsp-client update` tooling during code generation. Always include the auto-generated `metadata.json` in your PR when generation creates or updates it; manual changes can cause conflicts or incorrect values.

### ci.mgmt.yml
```yaml
trigger: none
extends:
  template: /eng/pipelines/templates/stages/archetype-sdk-client.yml
  parameters:
    ServiceDirectory: <service>
    LimitForPullRequest: true
    Artifacts:
    - name: <PACKAGE_NAME>
      safeName: <PackageNameNoDotsNoDashes>
```

### CHANGELOG.md
```markdown
## <VERSION> (Unreleased)

### Features Added
- Upgraded API version to `<API_VERSION>`
- Migrated from Swagger to TypeSpec-based generation
```

## Phase 8 — Autonomous Build-Fix Loop

Follow the `sdk-migration` skill's "Build-Fix Cycle" phase. MPG extends it with spec-side fix capabilities and the Spec ↔ SDK iteration cycle described below.

### Spec ↔ SDK Iteration Cycle

The goal is to **get `dotnet build` to pass with zero errors**. During iteration, you may need to fix issues in the **spec**, the **generator**, or **SDK custom code**. Use local paths to regenerate without pushing to remote.

**Loop until `dotnet build` succeeds with no errors:**

1. **Identify the error** — Run `dotnet build` and triage (spec issue, generator bug, or customization needed).
2. **Fix the source:**
   - **Spec fix**: Edit `client.tsp` in the local spec repo. Run `npx tsp format "**/*.tsp"` in the spec directory.
   - **Generator fix**: Edit generator code under `eng/packages/http-client-csharp-mgmt/`.
   - **Customization fix**: Edit or add partial classes under `src/Customization/` in the SDK package.
3. **Regenerate** based on what changed:
   - **Spec-only change** → `dotnet build /t:GenerateCode /p:LocalSpecRepo=<path>`
   - **Generator-only change** → `pwsh eng/packages/http-client-csharp-mgmt/eng/scripts/RegenSdkLocal.ps1 -Services <PACKAGE_NAME>`
   - **Both spec and generator** → `pwsh eng/packages/http-client-csharp-mgmt/eng/scripts/RegenSdkLocal.ps1 -Services <PACKAGE_NAME> -LocalSpecRepoPath <path>`
   - **Customization-only change** → no regeneration needed, just rebuild.
4. **Rebuild** and repeat.

### MPG Error Classification (extends shared framework)

In addition to the shared error classification from `sdk-migration`:

```
Given: error in file F with message M

1. IF F is under `src/Generated/`:
   a. IF M mentions a type that exists in old API (`api/*.cs`) but with different name:
      → ROOT CAUSE: spec (missing @@clientName)
   b. IF M says "inaccessible due to protection level" (CS0051/CS0122):
      → Try @@access in client.tsp first. If ineffective (nested types), fall back to [CodeGenType].
   c. IF M is about wrong constructor args or type mismatch:
      → Check if old API used a different type (e.g., ResourceIdentifier vs string).
        Try @@alternateType in client.tsp first.
   d. IF M is AZC0030/AZC0032 (forbidden suffix):
      → @@clientName rename in client.tsp

2. IF error is from ApiCompat:
   a. TypesMustExist + renamed type → @@clientName in client.tsp
   b. MembersMustExist → backward-compat shim in custom code (never use ApiCompatBaseline.txt)
```

### MPG Fix Decision Tree

```
PREFER spec-side fix (@@clientName, @@access, @@alternateType in client.tsp) when:
  - The fix is a simple rename, accessibility change, or type mapping override
  - Multiple errors would be resolved by one decorator
  - The old name/accessibility is clearly documented in api/*.cs

PREFER SDK custom code when:
  - @@access doesn't work (nested/wrapper types)
  - The fix requires backward-compat methods or properties
  - It's a one-off workaround for a generator limitation

PREFER generator fix when:
  - The same bug would affect ALL management SDKs
  - The generated code is structurally wrong despite correct spec
  - CAUTION: Run Generate.ps1 to verify no regressions
```

### Generator Fix Workflow

```
1. CONFIRM it's a generator bug (spec compiles, generated code is structurally wrong)
2. DECIDE: fix generator vs workaround (see error-reference.md)
3. IF fixing generator:
   - Edit code under eng/packages/http-client-csharp-mgmt/
   - Regenerate with RegenSdkLocal.ps1
   - CLEAN UP stale custom workarounds now redundant after the fix
   - Run Generate.ps1 to verify no regressions on other SDKs
4. IF workaround: [CodeGenSuppress] + custom implementation, document the issue
```

### Autonomous Rename Resolution Strategy

When migrating from autorest, many types get renamed. Resolve renames autonomously:

```
1. EXTRACT old names:
   a. Read api/<PACKAGE_NAME>.net*.cs for all public type names
   b. Read src/autorest.md rename-mapping entries (before deleting it)
   c. Store both in a lookup table

2. AFTER code generation, COMPARE:
   a. Get all new public type names from src/Generated/
   b. For each type referenced in custom code or old API surface:
      - IF same name → no action
      - IF different name → add @@clientName to preserve old name
      - IF no longer exists → check if flattened/merged/removed

3. For ALL name mismatches that cause build errors, add @@clientName in client.tsp.
   PREFER @@clientName over updating custom code — preserves backward compat.

4. For missing/moved operations:
   a. Check operation HTTP path in spec vs old autorest-generated REST client
   b. If operation mapped to different resource/scope → likely generator bug
   c. If moved between interfaces → check extension resource scope
```

### Batch Fix Strategy

```
1. Collect ALL errors from dotnet build
2. Group by root cause type
3. For spec fixes (@@clientName, @@access):
   a. Identify ALL needed decorators from the full error list
   b. Add ALL to client.tsp in one batch
   c. Run `npx tsp format "**/*.tsp"` in the spec directory
   d. Regenerate ONCE with LocalSpecRepo
4. For custom code fixes:
   a. Fix as many as possible in one pass (no regeneration needed)
5. For generator fixes:
   a. Fix one at a time (cascading effects)
   b. Regenerate and rebuild after each
```

### Sub-Agent Strategy

1. **task agent** — Run `dotnet build`, collect errors, populate SQL table.
2. **Batch spec fixes**:
   - **explore agent** — Analyze ALL errors, compare old API surface vs new names, identify needed decorators.
   - **general-purpose agent** — Apply ALL spec fixes to `client.tsp` in one batch.
   - **task agent** — Regenerate with `LocalSpecRepo` and rebuild.
3. **Batch custom code fixes**:
   - **explore agent** → **general-purpose agent** → **task agent** (rebuild).
4. **Generator fixes** (one at a time):
   - **explore agent** → **general-purpose agent** → **task agent** (RegenSdkLocal + rebuild).
   - **general-purpose agent** — Clean up stale workarounds → **task agent** (rebuild).
5. **task agent** — Final full build.

> **Why batched-sequential?** Spec fixes should be batched (one regeneration for many renames). Custom code fixes can be batched (no regeneration). Generator fixes are one-at-a-time (cascading effects).

## Phase 9 — Create Pull Requests

Once `dotnet build` passes with zero errors, create **separate PRs** for each category of change. This keeps reviews focused and allows independent merge timelines.

### Step 1 — Classify Changes

During the iteration loop, changes fall into three categories. Identify which ones apply:

| Category | Repository | What changed | PR needed? |
|----------|-----------|-------------|------------|
| **Spec changes** | `azure-rest-api-specs` | `client.tsp` decorators (`@@clientName`, `@@access`, `@@markAsPageable`, etc.) | Yes, if any spec files were modified |
| **Generator changes** | `azure-sdk-for-net` | Files under `eng/packages/http-client-csharp-mgmt/` | Yes, if generator code was fixed |
| **SDK migration** | `azure-sdk-for-net` | `tsp-location.yaml`, `Generated/`, `Customization/`, `api/`, `CHANGELOG.md`, etc. | Always yes |

### Step 2 — Create Spec PR (if applicable)

1. In the local spec repo (`../azure-rest-api-specs`), create a branch and commit all spec changes.
2. Push the branch and create a PR against `Azure/azure-rest-api-specs`.
3. Note the **final commit SHA** from the pushed branch.
4. PR title: `Add csharp client customizations for <Service> migration`

### Step 3 — Create Generator PR (if applicable)

1. In the SDK repo, create a branch containing **only** the generator changes under `eng/packages/http-client-csharp-mgmt/`.
2. Push and create a PR against `Azure/azure-sdk-for-net`.
3. PR title: `[Mgmt Generator] Fix <description> for <Service> migration`
4. Include test project regeneration if the fix affects other SDKs (run `eng/packages/http-client-csharp-mgmt/eng/scripts/Generate.ps1`).

### Step 4 — Create SDK Migration PR

1. Update `tsp-location.yaml` with the final spec commit SHA from Step 2.
2. Regenerate one final time **without** `LocalSpecRepo` to verify CI-reproducible generation:
   ```powershell
   cd sdk\<service>\<PACKAGE_NAME>\src
   dotnet build /t:GenerateCode
   ```
3. Verify `dotnet build` still passes.
4. Run pre-commit checks (Export-API, Update-Snippets, dotnet format).
5. Commit all SDK changes and create a PR against `Azure/azure-sdk-for-net`.
6. PR title: `[Mgmt] <PACKAGE_NAME>: Migrate to TypeSpec (API version <API_VERSION>)`
7. In the PR description, link to the spec PR and generator PR (if any) as dependencies.

### Step 5 — Report Summary

After all PRs are created, report:
1. **Spec PR**: Link and summary of decorators added.
2. **Generator PR**: Link and summary of fixes (if any).
3. **SDK PR**: Link and summary of migration changes.
4. **Manual follow-up**: Any remaining items that need human review (naming decisions, breaking changes, etc.).

## Fleet Mode Execution Strategy

When operating in fleet/autopilot mode, use sub-agents for parallelism:

### Parallel Phase (explore agents)
Launch these simultaneously at the start:
- **Agent 1**: Find spec location and determine spec type (TypeSpec vs Swagger)
- **Agent 2**: Analyze existing SDK package structure and current state
- **Agent 3**: Read naming guidelines from the azure-sdk-mgmt-pr-review skill

### Sequential Phase (task/general-purpose agents)
Execute these in order after planning:
1. **Create/update tsp-location.yaml** (task agent)
2. **Delete autorest.md if needed** (task agent)
3. **Create ci.mgmt.yml if missing** (task agent)
4. **Run code generation** (task agent — long-running, use initial_wait: 120+)
5. **Apply customizations** (general-purpose agent — needs reasoning for naming rules)
6. **Build error triage loop** (see Phase 8 sub-agent strategy — sequential per error)
7. **Final build and validate** (task agent)

### Rules for Fleet Agents
- Always pass complete context in the prompt — agents are stateless.
- Include the service name, paths, spec commit, and API version in every agent prompt.
- For customization agents, include the full naming rules from the azure-sdk-mgmt-pr-review skill.
- After each agent completes, verify output before launching dependent agents.
- Use `ask_user` for any destructive changes or ambiguous naming decisions.

## Phase 10 — Retrospective: Update Skill Files

After completing (or making significant progress on) a migration, review what was learned and update the skill files:

1. **New error patterns**: Add to [error-reference.md](https://github.com/Azure/azure-sdk-for-net/blob/main/.github/skills/sdk-migration/mpg/error-reference.md).
2. **New decorators or TypeSpec patterns**: Add to the `mitigate-breaking-changes` skill.
3. **New workarounds or pitfalls**: Add to [error-reference.md](https://github.com/Azure/azure-sdk-for-net/blob/main/.github/skills/sdk-migration/mpg/error-reference.md) Common Pitfalls section.
4. **Migration flow changes**: Update this file (SKILL.md).

> **Goal**: Each migration should leave these skill files slightly better than they were before.

## Common Pitfalls

See [error-reference.md](https://github.com/Azure/azure-sdk-for-net/blob/main/.github/skills/sdk-migration/mpg/error-reference.md) for the full list of common pitfalls and autonomous fix recipes. Key ones to remember during the migration flow:

- **Do NOT use `tsp-client update`** — use `dotnet build /t:GenerateCode`.
- **Do NOT blindly copy all renames from `autorest.md`** — after generation, only add `@@clientName` for names that actually cause build errors. Check existing spec decorators to avoid duplicates.
- **Batch spec fixes, then rebuild** — collect ALL needed `@@clientName`/`@@access` decorators before regenerating, to minimize regeneration cycles.
- **Build errors cascade** — one spec fix can resolve 5–20 errors. Always rebuild after each batch.
- **Try spec-side fix (`@@access`) before custom code (`[CodeGenType]`)** — spec-side is cleaner but doesn't work for all types.
- **Finalize `tsp-location.yaml` before creating the PR** — easy to forget when using `LocalSpecRepo`.
- **Match the existing custom code folder convention** — check if the package uses `Custom/`, `Customization/`, or `Customized/`.

## Safety Rules

Follow all safety rules from the `sdk-migration` skill. MPG adds:

### Additional Permitted Actions (No User Confirmation Needed)
1. **Spec changes**: Adding `@@clientName`, `@@access`, `@@markAsPageable`, `@@alternateType` to `client.tsp` — safe, reversible, csharp-scoped.
2. **Regenerating** with `RegenSdkLocal.ps1`.

### Additional Actions Requiring User Confirmation
1. **Modifying spec `.tsp` files beyond `client.tsp`** — affects all languages.
2. **Adding `ApiCompatBaseline.txt` entries** — almost never appropriate.
3. **Never bump the major version** of a management SDK package.
