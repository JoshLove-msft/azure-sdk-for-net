---
name: sdk-migration
description: Shared migration logic for Azure SDK for .NET libraries migrating from AutoRest/Swagger to TypeSpec-based generation. Common phases used by both management-plane (sdk-migration/mpg) and data-plane (sdk-migration/dpg) skills.
---
# Skill: sdk-migration (Shared Base)

Shared migration workflow for Azure SDK for .NET libraries migrating from AutoRest/Swagger to TypeSpec-based generation. This skill contains the common phases and patterns used by both management-plane and data-plane migration skills.

> **Do not invoke this skill directly.** It is referenced by the `sdk-migration/mpg` and `sdk-migration/dpg` skills.

## Shared Inputs

| Variable | Example | Description |
|----------|---------|-------------|
| `LIBRARY_PATH` | `sdk/storage/Azure.Storage.Blobs` | Relative path to the SDK package directory |
| `PACKAGE_NAME` | `Azure.Storage.Blobs` | Full NuGet package / directory name |
| `SERVICE_NAME` | `storage` | The folder name immediately after `sdk/` in the library path |
| `SPEC_COMMIT` | `37052dfa3f...` | Latest commit SHA from `Azure/azure-rest-api-specs` for the spec |
| `EMITTER_PACKAGE_JSON_PATH` | (set by plane-specific skill) | Path to the emitter package.json — differs between MPG and DPG |

## Phase: Validate SDK Path

**Goal**: Confirm the target library exists and is a valid migration target.
**Actions**:

1. Verify the library path is relative to the repo root and points to an existing directory.
2. Verify the directory contains a `src/` subdirectory with at least one `.csproj` file.
3. Verify `tsp-location.yaml` exists (library must already be a TypeSpec-based library).

---

## Phase: Create/Update `tsp-location.yaml`

**Goal**: Point the library at the correct spec and emitter.
**Actions**:

1. Read `{LIBRARY_PATH}/tsp-location.yaml`.
2. Parse `repo`, `directory`, and `commit` fields.
3. Set `emitterPackageJsonPath` to the value provided by the plane-specific skill (`EMITTER_PACKAGE_JSON_PATH`).
4. Resolve the correct commit SHA (see "Commit SHA Resolution" below).
5. Update the `commit` field with the resolved SHA.
6. If the `directory` path no longer exists in the spec repo, search for the new location by looking for TypeSpec projects (`tspconfig.yaml`) with similar service names, and update `directory` accordingly.
7. Preserve all other existing fields and formatting.

### Commit SHA Resolution

The spec's `tspconfig.yaml` must contain a matching emitter entry for the target emitter. The emitter name depends on the plane:
- **DPG** (data-plane generation): `azure-typespec/http-client-csharp`
- **MPG** (management-plane generation): `azure-typespec/http-client-csharp-mgmt`

Resolve the commit SHA using this algorithm:

```
1. Read the current `commit` from tsp-location.yaml (may be empty for new migrations).
2. Read the `directory` path from tsp-location.yaml.
3. Check the spec repo's `tspconfig.yaml` at that commit:
   - Fetch: {SPEC_REPO}/{directory}/tspconfig.yaml at the current commit
   - IF tspconfig.yaml contains an `emit` or `options` entry for the target emitter
     → the current commit is valid. Use it.
   - IF tspconfig.yaml does NOT contain the target emitter entry (or commit is empty)
     → the spec was not yet configured for this emitter at that commit.
     → Find the earliest commit AFTER the current commit on `main` that adds
       the target emitter to tspconfig.yaml for this directory.
     → Use that commit SHA.
4. IF no commit can be found with the target emitter configured
   → fall back to the latest commit on `main` for the directory path.
   → Warn the user that tspconfig.yaml may need manual emitter configuration.
```

**Why not always use latest?** The spec may have breaking changes between the current commit and HEAD. Using the earliest commit that has the correct emitter config minimizes unrelated spec churn during migration.

---

## Phase: Update `.csproj` Files

**Goal**: Remove old AutoRest dependencies.
**Actions**:

1. Find all `.csproj` files under `{LIBRARY_PATH}/src/` for the pattern `{LIBRARY_PATH}/src/**/*.csproj`
2. Remove `<IncludeAutorestDependency>true</IncludeAutorestDependency>` if present.
3. Clean up any resulting empty lines.

---

## Phase: Code Generation

**Goal**: Regenerate code with the new TypeSpec emitter.
**Actions**:

1. For each `.csproj` file found under `{LIBRARY_PATH}/src/` (using the pattern `{LIBRARY_PATH}/src/**/*.csproj`), run:
   ```shell
   dotnet build <csproj_path> /t:GenerateCode
   ```
2. Verify `src/Generated/` contains output files.
3. If generation fails, check if a **customization file** is causing it. Customization files are any hand-written `.cs` files under `{LIBRARY_PATH}/src/` that are **outside** the `Generated/` directory — these are typically partial classes, extension methods, or overrides that extend generated code. If a customization references types or members that no longer exist in the generated output, it can cause generation or compilation failures. Temporarily remove or fix the problematic customization, then re-run. If it still fails with no customizations involved, it's a generator bug — report and stop.

**IMPORTANT**: Always use `dotnet build /t:GenerateCode` for SDK code generation. Do NOT use `tsp-client update` — it can produce different output and decorators may not take effect with it.

---

## Phase: Build-Fix Cycle

**Goal**: Get the library to compile successfully through iterative error fixing.

### Command Macros

Use these exact commands throughout:

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
     - IF attempt_count >= 5 for any error → escalate to user via ask_user
     - IF error count increased from previous iteration → escalate to user
  6. Apply fixes in batch (see plane-specific skill for fix patterns)
  7. Increment attempt_count for each targeted error
  8. IF any fix involved generator attributes ([CodeGenSuppress], [CodeGenType], etc.)
     → run [GENERATE] then [BUILD]
  9. OTHERWISE → just run [BUILD]
  10. GOTO 1
```

Max 10 iterations per phase. If still failing, escalate to user.

### Key Insight: Generator and Customization File Interaction

The generator reads existing customization files (partial classes with `[CodeGenSuppress]`, `[CodeGenType]`, `[CodeGenModel]`, `[CodeGenMember]`, `[CodeGenSerialization]`) and produces **different output** based on them. This means:

- Errors in `Generated/` files are often **caused** by stale customization files, not generator bugs.
- Fixing a `Generated/` error usually means editing or removing the customization file that caused it, then re-running `[GENERATE]` so the generator produces correct output without the stale influence.
- Only after eliminating customization interference can you identify true generator bugs.

### Error Classification Framework

For each build error, classify it:

```
Given: error in file F with message M

1. IF F is under `src/Generated/`:
   a. Find the corresponding customization file (partial class, [CodeGenSuppress], etc.)
   b. Read both the Generated file and the customization file
   c. Fix the customization file to match the new generated code
   d. After fixing customization files with generator attributes → run [GENERATE] then [BUILD]
   e. If the error persists after removing all related customizations and regenerating → generator bug

2. IF F is under custom code (src/Custom/, src/Customization/, etc.):
   a. IF M references a type that was renamed or no longer exists
      → update custom code to use new name, or add a rename (plane-specific approach)
   b. IF M references a type that became internal
      → use plane-specific accessibility fix approach

3. IF error is structural in Generated/ with correct spec → generator bug
```

### Common Customization Patterns

These patterns apply to both MPG and DPG migrations:

- **Partial classes** — Extend generated types without editing `Generated/` files. No attributes needed for simple additions.
- **`[CodeGenType("SpecName")]`** — Link a custom class to its generated counterpart when names differ.
- **`[CodeGenSuppress("MemberName", typeof(...))]`** — Suppress a specific generated member to replace with a custom implementation.
- **`[CodeGenMember("MemberName")]`** — Link a custom property to its generated counterpart when names differ.
- **Match existing custom code folder convention** — Check if the package uses `Custom/`, `Customization/`, or `Customized/`. Use the same one.

> **Further reading**: See the [C# Customization Guide](https://github.com/microsoft/typespec/blob/main/packages/http-client-csharp/.tspd/docs/customization.md) for full documentation on available customization patterns, and [TypeSpec client customization](../../../eng/common/knowledge/customizing-client-tsp.md) for TypeSpec decorator-based customizations.

### SQL Error Tracking

Track errors and fixes for observability:

```sql
CREATE TABLE build_errors (
  id TEXT PRIMARY KEY,
  error_code TEXT,
  file TEXT,
  message TEXT,
  root_cause TEXT,       -- 'spec' | 'generator' | 'customization' | 'unknown'
  fix_type TEXT,         -- 'clientName' | 'access' | 'codeGenType' | 'codeGenSuppress' | 'custom_code' | 'generator_fix'
  fix_detail TEXT,
  attempt_count INTEGER DEFAULT 0,
  last_fix_attempted TEXT,
  status TEXT DEFAULT 'pending'  -- 'pending' | 'investigating' | 'fixed' | 'blocked' | 'cascaded'
);
```

### Priority Order

Fix these first — they cascade into many other errors:

1. Missing/renamed types (CS0234, CS0246)
2. Accessibility issues (CS0051, CS0122)
3. Signature mismatches (CS1729, CS0029, CS1503)
4. Duplicate definitions (CS0111)
5. Other errors — investigate individually

---

## Phase: Test Project Build

**Goal**: Ensure tests compile after migration.
**Actions**:

1. If `tests/Generated/Samples/` exists, move contents to `tests/Samples/` and delete the empty folder. Do NOT run `[GENERATE]` in the tests directory.
2. Run `[BUILD]` in the tests directory.
3. Fix errors using the same patterns (test files are not generated, so edit them directly).
4. Check `src/Generated/` for actual new type names before writing fixes.
5. Repeat (max 10 iterations). If still failing, skip to finalization.

---

## Phase: Test Execution

**Goal**: Verify tests pass.
**Actions**:

1. Run `[TEST]` in the tests directory.
2. If failures occur, fix non-Generated test files, run `[BUILD]`, then `[TEST]` again.
3. Repeat (max 5 iterations). If still failing, continue to finalization.

---

## Phase: Finalization

**Goal**: Run post-migration housekeeping scripts.
**Actions**:

Run from the **repository root** (not the project directory):

1. Export the API surface:
   ```powershell
   .\eng\scripts\Export-API.ps1 -ServiceDirectory SERVICE_NAME
   ```
2. Update code snippets:
   ```powershell
   .\eng\scripts\Update-Snippets.ps1 -ServiceDirectory SERVICE_NAME
   ```
3. Announce: "Migration completed successfully"

---

## Generator Bug Diagnosis

A true generator bug is when Generated/ code is wrong even with **no** customization files influencing it.

Before reporting a generator bug, ALWAYS:
1. Remove/fix any customization files that could be influencing the generator.
2. Re-run `[GENERATE]`.
3. If the error persists in Generated/ with no customization influence → it's a generator bug.

Report: error messages, generated code snippet, repro steps. Do NOT manually fix Generated/ code.

---

## Escalation Criteria

The build-fix loop proceeds **without asking the user** except when:

1. **Ambiguous fix** — Multiple equally valid approaches and the correct choice is unclear.
2. **Breaking API change with no backward-compat option** — A public type/method must be removed.
3. **Generator fix affects other SDKs** — The fix would change behavior across multiple SDKs.
4. **5 consecutive failed attempts** for the same error.
5. **Error count increases after a fix** — The fix made things worse.

For all other cases, **proceed autonomously**.

---

## Safety Rules

### Hard Rules (Never Violate)

1. **Never edit files under `Generated/`** — they are overwritten by codegen.
2. **Never hand-edit `metadata.json`** — it is auto-generated.
3. **Never use `tsp-client update`** — use `dotnet build /t:GenerateCode`.
4. **Preserve git history** — prefer renames over delete+create.

### Permitted Without User Confirmation

1. Adding/editing customization files (partial classes, `[CodeGenType]`, `[CodeGenSuppress]`).
2. Updating custom code to reference new generated type names.
3. Regenerating code using `dotnet build /t:GenerateCode`.
4. Deleting `autorest.md` after extracting directives — git history preserves it.
5. Updating `CHANGELOG.md` and other metadata files.

### Actions Requiring User Confirmation

1. **Generator code changes** that affect other SDKs.
2. **Removing public API surface** with no backward-compat option (true breaking change).
3. **Deleting existing custom code files** — may lose manually-written logic.

---

## Summary Template

After migration, report:
- All completed steps and any warnings.
- Any `[CodeGenType]` attributes that may need manual review.
- Remind the user to review changes with `git diff` before committing.
- Suggest running the `pre-commit-checks` skill before committing.
