---
name: sdk-migration
description: Shared migration logic for Azure SDK for .NET libraries migrating from AutoRest/Swagger to TypeSpec-based generation. Common phases used by both management-plane (sdk-migration/mpg) and data-plane (sdk-migration/dpg) skills.
---
# SDK Migration Workflow

Unified migration workflow for Azure SDK for .NET libraries. This file is the single source of truth for both data-plane (DPG) and management-plane (MPG) migrations. Sections marked **[MPG only]** or **[DPG only]** apply to one plane; everything else is shared.

## When Invoked

Trigger phrases: "migrate service X", "update spec", "bring SDK to latest", "help with mgmt migration", "mpg migration", "mgmt sdk migration", "data-plane migration", "dpg migration", "migrate to TypeSpec", "swagger to TypeSpec migration", "upgrade generator", "generator migration help".

## Inputs

Determine if the library is data-plane or management-plane - management-plane libraries will be named like Azure.ResourceManager.*. Data-plane libraries will have service-specific names without "ResourceManager".
For the purposes of diagnosing generator bugs, the management-plane emitter is located in this repo under `eng/packages/http-client-csharp-mgmt/`, while the data-plane emitter is in this repo under `eng/packages/http-client-csharp/`. The base emitter is in the microsoft/typespec repo under `packages/http-client-csharp/`.

| Variable | Example | Description |
|----------|---------|-------------|
| `LIBRARY_PATH` | `sdk/communication/Azure.Communication.Messages` | Relative path to the SDK package directory |
| `PACKAGE_NAME` | `Azure.Communication.Messages` | Full NuGet package / directory name |
| `SERVICE_NAME` | `communication` | The folder name immediately after `sdk/` |
| `EMITTER_PACKAGE_JSON_PATH` | see below | Path to the emitter package.json |

| Plane | `EMITTER_PACKAGE_JSON_PATH` | Target emitter in `tspconfig.yaml` |
|-------|----------------------------|------------------------------------|
| **DPG** | `eng/azure-typespec-http-client-csharp-emitter-package.json` | `azure-typespec/http-client-csharp` |
| **MPG** | `eng/azure-typespec-http-client-csharp-mgmt-emitter-package.json` | `azure-typespec/http-client-csharp-mgmt` |

| Variable | Example | Description |
|----------|---------|-------------|
| `SPEC_DIR` | `specification/chaos/resource-manager/Microsoft.Chaos/Chaos` | TypeSpec directory in azure-rest-api-specs |
| `SPEC_COMMIT` | `37052dfa3f...` | Commit SHA from the spec repo |
| `API_VERSION` | `2025-01-01` | Target API version from the spec |

---

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

# Sync base generator repo (if needed for generator fixes)
cd ..\typespec
git fetch origin main
git merge origin/main
```

---

## Phase 1 — Discovery & Planning

Use **explore** agents in parallel:

1. **Find the spec**: Search `../azure-rest-api-specs/specification/<service>/` for `main.tsp` / `tspconfig.yaml`. Determine TypeSpec vs Swagger.
2. **Find the existing SDK**: Check for `tsp-location.yaml` (already migrated) or `src/autorest.md` (legacy Swagger).
3. **Inventory existing csharp customizations in spec**: Search `.tsp` files for `@clientName("...", "csharp")` and `@@clientName` decorators. Check for `back-compatible.tsp`.
4. **Snapshot old API surface**: Read `api/<PACKAGE_NAME>.net*.cs` — extract all public type names for later rename resolution.
5. **Extract autorest rename mappings**: From `src/autorest.md`, extract `rename-mapping` and `prepend-rp-prefix` entries.
6. **Identify custom code folder convention**: `Custom/`, `Customization/`, or `Customized/`.
7. **Review naming conventions**: Consult the `azure-sdk-mgmt-pr-review` skill.

Present a summary plan and **ask the user** to confirm.

---

## Phase 2 — Create/Update `tsp-location.yaml`

**Goal**: Point the library at the correct spec and emitter.

1. Read `{LIBRARY_PATH}/tsp-location.yaml`.
2. Parse `repo`, `directory`, and `commit` fields.
3. Set `emitterPackageJsonPath` to the plane-specific value (see Inputs table).
4. Resolve the correct commit SHA (see below).
5. Update the `commit` field with the resolved SHA.
6. If the `directory` path no longer exists, search for TypeSpec projects with similar service names.
7. Preserve all other existing fields.

### Commit SHA Resolution

```
1. Read current `commit` and `directory` from tsp-location.yaml.
2. Fetch tspconfig.yaml from spec repo at that commit.
3. IF tspconfig.yaml contains an `emit` or `options` entry for the target emitter
   → current commit is valid. Use it.
4. IF NOT → find the earliest commit on `main` that adds it.
5. IF directory no longer exists → search for relocated TypeSpec project, update `directory`, re-resolve.
6. IF nothing found → fall back to latest `main`. Warn user.
```

additional `tsp-location.yaml` fields:
- `directory` must point to the folder containing `main.tsp` and `tspconfig.yaml`.
- Optional: `additionalDirectories` array for shared TypeSpec libraries.

---

## Phase 3 — Handle Legacy Configuration

### Remove AutoRest dependency

1. Remove `<IncludeAutorestDependency>true</IncludeAutorestDependency>` from `.csproj` files.

### Handle `autorest.md` [MPG only]

If `src/autorest.md` exists:
1. Extract key config and **thoroughly analyze rename mappings**.
2. The mgmt emitter auto-handles these naming transforms (do NOT duplicate):
   - `Url`→`Uri`, `Etag`→`ETag`
   - DateTimeOffset suffixes: `Time`/`Date`/`DateTime`/`At`→`On`
   - RP prefix prepending for `Sku`, `Plan`, `Usage`, `Kind`, `PrivateEndpointConnection`, etc.
   - Resource update model naming (`Patch`/`CreateOrUpdateContent`)
3. Delete `autorest.md` — git history preserves it.
4. Map remaining directives to TypeSpec approach:
   - Renames → `@@clientName(SpecNamespace.SpecTypeName, "SdkName", "csharp")` in spec `client.tsp`
   - Accessibility → `@@access(SpecNamespace.TypeName, Access.public, "csharp")`
   - Type mapping → `@@alternateType(SpecNamespace.Model.property, "ArmType", "csharp")`

---

## Phase 4 — Update Custom Code

### CodeGen namespace and attributes

In all non-Generated `.cs` files under `{LIBRARY_PATH}/src/`:
1. Add `using Microsoft.TypeSpec.Generator.Customizations;` where `[CodeGen` attributes are used.
2. Replace `CodeGenClient` → `CodeGenType`
3. Replace `CodeGenModel` → `CodeGenType`

### DPG code transformations [DPG only]

Apply **before** code generation:
- `_pipeline` → `Pipeline` (field → property)
- Remove `using AutoRest.CSharp.Core;`
- `_serializedAdditionalRawData` → `_additionalBinaryDataProperties`
- `serializedAdditionalRawData` → `additionalBinaryDataProperties`
- `FromCancellationToken(cancellationToken)` → `cancellationToken.ToRequestContext()`

---

## Phase 5 — Code Generation

**Goal**: Regenerate code with the new TypeSpec emitter.

```shell
dotnet build <csproj_path> /t:GenerateCode
```

**IMPORTANT**: Always use `dotnet build /t:GenerateCode`. Do NOT use `tsp-client update`.

If generation fails, check if a customization file is causing it. Temporarily remove or fix it, then re-run. If it still fails with no customizations → generator bug.

local spec repo support:
```powershell
# During iteration — use local spec repo (no push needed)
dotnet build /t:GenerateCode /p:LocalSpecRepo=<path-to-azure-rest-api-specs>

# Final generation — uses commit from tsp-location.yaml
dotnet build /t:GenerateCode
```

After generation, additionally:
- **[MPG only]** Check ApiCompat with `dotnet pack --no-restore`.
- Export the API surface: `pwsh eng/scripts/Export-API.ps1 <SERVICE_NAME>`.

### Using `RegenSdkLocal.ps1` [MPG only]

When local generator changes exist under `eng/packages/http-client-csharp-mgmt/`:
```powershell
pwsh eng/packages/http-client-csharp-mgmt/eng/scripts/RegenSdkLocal.ps1 -Services <PACKAGE_NAME>
# With local spec repo:
pwsh eng/packages/http-client-csharp-mgmt/eng/scripts/RegenSdkLocal.ps1 -Services <PACKAGE_NAME> -LocalSpecRepoPath <path>
```

---

## Phase 6 — Build-Fix Cycle

**Goal**: Get the library to compile successfully through iterative error fixing.

### Command Macros

| Macro | Command |
|-------|---------|
| `[BUILD]` | `dotnet build /clp:ErrorsOnly 2>&1 \| Select-Object -First 50` |
| `[GENERATE]` | `dotnet build /t:GenerateCode` |
| `[TEST]` | `dotnet test --no-build --filter "TestCategory!=Live" 2>&1 \| Select-Object -Last 30` |

### Execution Protocol

```
LOOP:
  1. Run [BUILD] → collect ALL errors
  2. IF zero errors → EXIT LOOP
  3. Parse errors into structured list (error code, file, message)
  4. Group errors by root cause
  5. For each error group, check attempt_count:
     - IF attempt_count >= 5 → escalate to user
     - IF error count increased → escalate to user
  6. Apply fixes in batch
  7. Regenerate based on what changed:
     - Generator attributes changed → [GENERATE] then [BUILD]
     - Spec changes → [GENERATE] (with LocalSpecRepo) then [BUILD]
     - Generator code changes [MPG only] → RegenSdkLocal.ps1 then [BUILD]
     - Customization-only → just [BUILD]
  8. GOTO 1
```

Max 10 iterations. If still failing, escalate to user.

### Key Insight: Generator and Customization File Interaction

The generator reads existing customization files (`[CodeGenSuppress]`, `[CodeGenType]`, `[CodeGenMember]`, `[CodeGenSerialization]`) and produces **different output** based on them:

- Errors in `Generated/` are often **caused** by stale customization files, not generator bugs.
- Fix by editing the customization file, then re-running `[GENERATE]`.
- Only after eliminating customization interference can you identify true generator bugs.

### Error Classification

```
Given: error in file F with message M

1. IF F is under `src/Generated/`:
   a. Find the corresponding customization file
   b. Fix the customization to match new generated code
   c. Run [GENERATE] then [BUILD]
   d. If error persists after removing all customizations → generator bug

2. IF F is under custom code:
   a. Renamed/missing type → update custom code or add rename
   b. Internal type → use accessibility fix (@@access [MPG] or CodeGenType)

3. IF error is structural in Generated/ with correct spec → generator bug
```

### DPG-Specific Error Patterns [DPG only]

These patterns are specific to data-plane migrations. Apply them during the shared skill's "Build-Fix Cycle" phase, in addition to the common customization patterns.

#### `GeneratorPageableHelpers` → `CollectionResult` pattern
- If code uses `GeneratorPageableHelpers.CreatePageable` or similar, replace it with the corresponding generated `CollectionResult` type from the `Generated/` folder.
- If no `CollectionResult` type exists in `Generated/`:
    1. Look for a `[CodeGenSuppress]` attribute that suppresses the internal method which would create the `CollectionResult`.
    2. Comment out or remove that `[CodeGenSuppress]` attribute.
    3. Re-run code generation to produce the `CollectionResult` type.
    4. After regeneration, use the generated type.
- Do NOT create `CollectionResult` types manually — they must be generated.

#### `ToRequestContent()` removal
- Input models now have an implicit cast to `RequestContent`.
- Replace `foo.ToRequestContent()` with just `foo`.
- Example: `using RequestContent content = details.ToRequestContent();` → `using RequestContent content = details;`
- **Keep** the `using` statement; only remove the `.ToRequestContent()` call.

#### `FromCancellationToken` replacement
- Replace `RequestContext context = FromCancellationToken(cancellationToken);`
- With `RequestContext context = cancellationToken.ToRequestContext();`

#### Mismatched `ModelFactory` type names
- If a custom type ending in `ModelFactory` has a different name than the generated type ending in `ModelFactory`, update the `CodeGenType` attribute in the custom type to match the generated type name.

### Mismatched `ClientBuilderExtensions` type names
- If a custom type ending in `ClientBuilderExtensions` has a different name than the generated type ending in `ClientBuilderExtensions`, update the `CodeGenType` attribute in the custom type to match the generated type name.

#### Fetch methods in custom LRO methods
- The old `Fetch` methods are replaced by static `FromLroResponse` methods on the response models.
- Update custom LRO methods to use `ResponseModel.FromLroResponse(response)` instead of calling `Fetch` methods.
- Do NOT create `Fetch` methods manually — call the generated `FromLroResponse` method.

#### `FromResponse` method removal
- `FromResponse` methods have been removed from models.
- Use explicit cast from `Response` to the model type instead.
- Example: `var model = ModelType.FromResponse(response);` → `var model = (ModelType)response;`

### MPG-Specific Error Patterns [MPG only]

| Error | Root Cause | Fix |
|-------|-----------|-----|
| CS0234/CS0246 (type not found) | Type renamed by new generator | `@@clientName` in `client.tsp`, or update custom code |
| CS0051/CS0122 (inaccessible) | Type generated as `internal` | Try `@@access` first; fall back to `[CodeGenType]` |
| CS1729/CS0029/CS1503 (type mismatch) | Wrong type (e.g., `string` vs `ResourceIdentifier`) | `@@alternateType` in `client.tsp` |
| AZC0030 (forbidden suffix) | Naming analyzer rejects name | `@@clientName` to old name |
| AZC0032 (forbidden 'Data' suffix) | Doesn't inherit `ResourceData` | `@@clientName` to old name |
| ApiCompat MembersMustExist | Changed return type / missing member | `[CodeGenSuppress]` + custom shim (never use ApiCompatBaseline.txt) |
| ApiCompat TypesMustExist | Missing type | `@@clientName` to restore old name |

### MPG Fix Decision Tree [MPG only]

```
PREFER spec-side fix (@@clientName, @@access, @@alternateType) when:
  - Simple rename, accessibility change, or type mapping override
  - Multiple errors resolved by one decorator

PREFER SDK custom code when:
  - @@access doesn't work (nested/wrapper types)
  - Backward-compat methods/properties needed
  - One-off workaround for generator limitation

PREFER generator fix when:
  - Same bug affects ALL management SDKs
  - Generated code is structurally wrong despite correct spec
  - CAUTION: Run Generate.ps1 to verify no regressions
```

### Priority Order

1. Missing/renamed types (CS0234, CS0246)
2. Accessibility issues (CS0051, CS0122)
3. Signature mismatches (CS1729, CS0029, CS1503)
4. Duplicate definitions (CS0111)
5. Other errors — investigate individually

### Customization Patterns

- **Partial classes** — Extend generated types without editing `Generated/`.
- **`[CodeGenType("SpecName")]`** — Link custom class to generated counterpart.
- **`[CodeGenSuppress("MemberName", typeof(...))]`** — Suppress a generated member.
- **`[CodeGenMember("MemberName")]`** — Link custom property to generated counterpart.
- **Match existing custom code folder convention** — `Custom/`, `Customization/`, or `Customized/`.

> **Further reading**: [C# Customization Guide](https://github.com/microsoft/typespec/blob/main/packages/http-client-csharp/.tspd/docs/customization.md), [TypeSpec client customization](https://github.com/Azure/azure-sdk-for-net/blob/main/eng/common/knowledge/customizing-client-tsp.md).

### SQL Error Tracking

```sql
CREATE TABLE build_errors (
  id TEXT PRIMARY KEY,
  error_code TEXT, file TEXT, message TEXT,
  root_cause TEXT,       -- 'spec' | 'generator' | 'customization' | 'unknown'
  fix_type TEXT,         -- 'clientName' | 'access' | 'codeGenType' | 'codeGenSuppress' | 'custom_code' | 'generator_fix'
  fix_detail TEXT,
  attempt_count INTEGER DEFAULT 0,
  last_fix_attempted TEXT,
  status TEXT DEFAULT 'pending'  -- 'pending' | 'investigating' | 'fixed' | 'blocked' | 'cascaded'
);
```

---

## Phase 7 — CI & Changelog [MPG only]

**Do NOT hand-edit `metadata.json`** — it is auto-generated.

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

---

## Phase 8 — Test Project Build

1. If `tests/Generated/Samples/` exists, move contents to `tests/Samples/`. Do NOT run `[GENERATE]` in tests.
2. Run `[BUILD]` in the tests directory.
3. Fix errors (test files are not generated — edit directly).
4. Check `src/Generated/` for actual new type names before writing fixes.
5. Repeat (max 10 iterations). If still failing, skip to finalization.

---

## Phase 9 — Test Execution

1. Run `[TEST]` in the tests directory.
2. Fix failures, run `[BUILD]`, then `[TEST]` again.
3. Repeat (max 5 iterations). If still failing, continue to finalization.

---

## Phase 10 — Finalization

Run from the **repository root**:

```powershell
.\eng\scripts\Export-API.ps1 -ServiceDirectory SERVICE_NAME
.\eng\scripts\Update-Snippets.ps1 -ServiceDirectory SERVICE_NAME
```

---

## Phase 11 — Create Pull Requests

Once `dotnet build` passes, create **separate PRs** for each category:

| Category | Repository | PR needed? |
|----------|-----------|------------|
| **Spec changes** | `azure-rest-api-specs` | If any spec files were modified |
| **Generator changes** | `azure-sdk-for-net` | If generator code was fixed |
| **SDK migration** | `azure-sdk-for-net` | Always |

1. **Spec PR**: Push `client.tsp` changes to spec repo. Note final commit SHA.
2. **Generator PR**  [MPG only]: Push only `eng/packages/http-client-csharp-mgmt/` changes. Run `Generate.ps1` to verify no regressions.
3. **SDK PR**: Update `tsp-location.yaml` with pushed spec commit. Regenerate without `LocalSpecRepo`. Run pre-commit checks.

---

## Phase 12 — Verify and Summarize

1. Report summary of all completed steps and warnings.
2. Note any `CodeGenType` attributes needing manual review.
3. Remind user to review with `git diff` before committing.
4. Suggest running the `pre-commit-checks` skill.

---

## Phase 13 — Retrospective [MPG only]

After migration, update skill files with:
1. New error patterns → [error-reference.md](error-reference.md)
2. New decorators/TypeSpec patterns → `mitigate-breaking-changes` skill
3. New workarounds/pitfalls → [error-reference.md](error-reference.md)

---

## Generator Bug Diagnosis

Before reporting a generator bug, ALWAYS:
1. Remove/fix any customization files that could influence the generator.
2. Re-run `[GENERATE]`.
3. If the error persists with no customization influence → generator bug.

Report: error messages, generated code snippet, repro steps. Do NOT manually fix Generated/ code.

### Generator Fix Workflow [MPG only]

```
1. CONFIRM it's a generator bug
2. IF fixing generator:
   - Edit under eng/packages/http-client-csharp-mgmt/
   - Regenerate with RegenSdkLocal.ps1
   - Clean up stale custom workarounds
   - Run Generate.ps1 to verify no regressions
3. IF workaround: [CodeGenSuppress] + custom implementation, document the issue
```

---

## Safety Rules

### Hard Rules (Never Violate)

1. **Never edit files under `Generated/`** — they are overwritten by codegen.
2. **Never hand-edit `metadata.json`** — it is auto-generated.
3. **Never use `tsp-client update`** — use `dotnet build /t:GenerateCode`.
4. **Never add entries to `ApiCompatBaseline.txt`** without explicit user approval.
5. **Never bump the major version** of an Azure SDK package.
6. **Preserve git history** — prefer renames over delete+create.

### Autonomous Mode (Default)

During the build-fix loop, Copilot operates autonomously. These actions are **permitted without user confirmation**:

1. **Spec changes**: Adding `@@clientName`, `@@access`, `@@markAsPageable`, `@@alternateType`, and other decorators to `client.tsp` — these are safe, reversible, and csharp-scoped.
2. **Custom code**: Adding partial classes in the SDK custom code folder. Use `[CodeGenType]`/`[CodeGenSuppress]`/`[CodeGenMember]` only when needed.
3. **Deleting `autorest.md`** after extracting directives — git history preserves it.
4. **Updating custom code** to reference new generated type names.
5. **Regenerating code** using `dotnet build /t:GenerateCode` or **[MPG only]** `RegenSdkLocal.ps1`.
6. **Updating CHANGELOG.md** and other metadata files.

### Actions Requiring User Confirmation

These actions **require explicit user approval** (use `ask_user`):

1. **Modifying spec `.tsp` files beyond `client.tsp`** — e.g., changing `main.tsp`, model definitions, or operation signatures. These affect all languages, not just C#.
2. **Generator code changes** that affect other SDKs — run `Generate.ps1` to verify scope first.
3. **Removing public API surface** with no backward-compat option (true breaking change).
4. **Adding `ApiCompatBaseline.txt` entries** — this should almost never be done.
5. **Deleting existing custom code files** — may lose manually-written logic.

### Escalation Criteria

Proceed **without asking the user** except when:
1. Ambiguous fix — multiple equally valid approaches.
2. Breaking API change with no backward-compat option.
3. Generator fix affects other SDKs.
4. 5 consecutive failed attempts for the same error.
5. Error count increases after a fix.

---

## Fleet Mode Execution Strategy

### Parallel Phase (explore agents)
- **Agent 1**: Find spec location and determine spec type
- **Agent 2**: Analyze existing SDK package structure
- **Agent 3**: Read naming guidelines from `azure-sdk-mgmt-pr-review` skill [MPG only]

### Sequential Phase (task/general-purpose agents)
1. Create/update `tsp-location.yaml`
2. Delete `autorest.md` if needed
3. Create `ci.mgmt.yml` if missing
4. Run code generation (initial_wait: 120+)
5. Apply customizations (general-purpose agent for naming rules)
6. Build error triage loop
7. Final build and validate

### Sub-Agent Strategy
1. **task agent** — Run `dotnet build`, collect errors, populate SQL table.
2. **Batch spec fixes**: explore → general-purpose → task (regenerate + rebuild).
3. **Batch custom code fixes**: explore → general-purpose → task (rebuild).
4. **Generator fixes** (one at a time): explore → general-purpose → task (RegenSdkLocal + rebuild) → general-purpose (clean up stale workarounds) → task (rebuild).

## Common Pitfalls

- **Do NOT use `tsp-client update`** — use `dotnet build /t:GenerateCode`.
- **Do NOT hand-edit `metadata.json`**.
- **Match existing custom code folder convention**.
- Don't blindly copy all renames from `autorest.md` — only add `@@clientName` for names that actually cause build errors after generation. Check existing spec decorators to avoid duplicates.
- Batch spec fixes, then rebuild — one spec fix can resolve 5–20 errors.
- Try spec-side fix (`@@access`) before custom code (`[CodeGenType]`).
- Finalize `tsp-location.yaml` with pushed spec commit before creating PR.
- Run `CodeChecks.ps1` before pushing: `pwsh eng\scripts\CodeChecks.ps1 -ServiceDirectory <service>`
- Clean up stale custom workarounds after generator fixes.
