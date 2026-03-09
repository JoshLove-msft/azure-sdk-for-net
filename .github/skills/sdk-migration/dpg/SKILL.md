---
name: sdk-migration/dpg
description: Migrate an Azure SDK for .NET data-plane library from the old AutoRest-based generator to the new TypeSpec generator. Updates configuration, replaces deprecated attributes and APIs, regenerates code, and iteratively fixes build errors.
---
# Skill: sdk-migration/dpg

Migrate a .NET data-plane SDK library from the old AutoRest-based C# code generator to the new TypeSpec-based generator. This skill performs configuration updates, code transformations, code regeneration, and iterative build-error fixing.

> **Shared foundation**: This skill extends the `sdk-migration` skill. Follow that skill for common phases (validation, tsp-location.yaml, code generation, build-fix cycle structure, finalization, safety rules). This file covers only data-plane-specific concerns.

## When Invoked

Trigger phrases: "migrate data-plane library", "migrate DPG", "migrate to new generator", "dpg migration", "data-plane migration".

## Prerequisites

- The library must already have a `tsp-location.yaml` file (it is a TypeSpec-based library).
- The library path must be provided (e.g., `sdk/cognitivelanguage/Azure.AI.Language.Text`).

## DPG-Specific Inputs

| Variable | Example | Description |
|----------|---------|-------------|
| `LIBRARY_PATH` | `sdk/cognitivelanguage/Azure.AI.Language.Text` | Relative path to the SDK package directory |
| `PACKAGE_NAME` | `Azure.AI.Language.Text` | Full NuGet package / directory name |
| `SERVICE_NAME` | `cognitivelanguage` | The folder name immediately after `sdk/` |
| `EMITTER_PACKAGE_JSON_PATH` | `eng/azure-typespec-http-client-csharp-emitter-package.json` | Always this value for data-plane SDKs |

---

## Step 1: Identify the library path

**Goal**: Determine the target library to migrate.
**Actions**:

- If the user has not provided a library path, ask for it. The path should be relative to the repo root and point to the package directory (e.g., `sdk/storage/Azure.Storage.Blobs`).
- Follow the `sdk-migration` skill's "Validate SDK Path" phase.

---

## Step 2: Update `tsp-location.yaml` and commit SHA

**Goal**: Point the library at the new TypeSpec emitter and correct spec commit.
**Actions**:

Follow the `sdk-migration` skill's "Create/Update tsp-location.yaml" phase with DPG-specific values:

- `EMITTER_PACKAGE_JSON_PATH` = `eng/azure-typespec-http-client-csharp-emitter-package.json`
- Target emitter name for commit resolution: `azure-typespec/http-client-csharp`
- If `emitterPackageJsonPath` is not present, add it.
- If the file already contains the new emitter path, skip the emitter update (but still verify the commit SHA).

---

## Step 3: Remove old AutoRest dependencies

Follow the `sdk-migration` skill's "Update .csproj Files" phase.

---

## Step 4: Update CodeGen namespace

Follow the `sdk-migration` skill's "Update CodeGen Namespace" phase.

---

## Step 5: Replace `CodeGenClient` / `CodeGenModel` with `CodeGenType`

Follow the `sdk-migration` skill's "Replace Deprecated CodeGen Attributes" phase.

---

## Step 6: Replace `_pipeline` with `Pipeline`

**Goal**: Update the private pipeline field reference to the new public property.
**Actions**:

- In all non-Generated `.cs` files under `{LIBRARY_PATH}/src/`:
  - Replace `_pipeline` → `Pipeline` (word-boundary match only).

---

## Step 7: Remove `AutoRest.CSharp.Core` using statements

**Goal**: Remove references to the old generator namespace.
**Actions**:

- In all non-Generated `.cs` files under `{LIBRARY_PATH}/src/`:
  - Remove lines matching `using AutoRest.CSharp.Core;`.

---

## Step 8: Replace `_serializedAdditionalRawData` with `_additionalBinaryDataProperties`

**Goal**: Update the backing field name to match the new generator output.
**Actions**:

- In all non-Generated `.cs` files under `{LIBRARY_PATH}/src/`:
  - Replace `_serializedAdditionalRawData` → `_additionalBinaryDataProperties`
  - Replace `serializedAdditionalRawData` → `additionalBinaryDataProperties`

---

## Step 9: Run code generation

**Goal**: Regenerate code with the new generator.
**Actions**:

Follow the `sdk-migration` skill's "Code Generation" phase:

```shell
dotnet build {LIBRARY_PATH}/src/{PACKAGE_NAME}.csproj /t:GenerateCode
```

---

## Step 10: Build and fix errors iteratively

**Goal**: Get the library to compile successfully.

Follow the `sdk-migration` skill's "Build-Fix Cycle" phase, extended with DPG-specific migration patterns below.

### Execution Protocol

1. Run `dotnet build {LIBRARY_PATH}/src/{PACKAGE_NAME}.csproj` to check for compilation errors.
2. If the build succeeds, proceed to Step 11.
3. If the build fails, analyze errors and apply fixes using the DPG migration patterns below.
4. After applying fixes, re-run `dotnet build /t:GenerateCode` if fixes may affect generated output (e.g., modifying `[CodeGenSuppress]` attributes), then rebuild.
5. Repeat up to 10 times or until the build succeeds.

### CRITICAL RULE: Never modify files under `Generated/` folders

All fixes must be made in non-Generated customization files. If an error originates from a Generated file, create or edit a partial class in the parallel non-Generated location.

### DPG Migration Patterns

These patterns are specific to data-plane migrations. Apply them in addition to the common customization patterns from the `sdk-migration` skill.

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

#### Mismatched `ClientBuilderExtensions` type names
- If a custom type ending in `ClientBuilderExtensions` has a different name than the generated type ending in `ClientBuilderExtensions`, update the `CodeGenType` attribute in the custom type to match the generated type name.

#### Fetch methods in custom LRO methods
- The old `Fetch` methods are replaced by static `FromLroResponse` methods on the response models.
- Update custom LRO methods to use `ResponseModel.FromLroResponse(response)` instead of calling `Fetch` methods.
- Do NOT create `Fetch` methods manually — call the generated `FromLroResponse` method.

#### `FromResponse` method removal
- `FromResponse` methods have been removed from models.
- Use explicit cast from `Response` to the model type instead.
- Example: `var model = ModelType.FromResponse(response);` → `var model = (ModelType)response;`

#### Generator and customization file interaction
- The generator reads existing customization files (partial classes with `[CodeGenSuppress]`, `[CodeGenType]`, etc.) and produces **different output** based on them.
- Errors in `Generated/` files are often **caused** by stale customization files, not generator bugs.
- Fixing a `Generated/` error usually means editing or removing the customization file that caused it, then re-running code generation so the generator produces correct output without the stale influence.
- Only after eliminating customization interference can you identify true generator bugs.

### DPG Error Classification (extends shared framework)

In addition to the shared error classification from `sdk-migration`:

```
Given: error in file F with message M

1. IF M mentions `GeneratorPageableHelpers` or `CreatePageable`:
   → Replace with CollectionResult pattern (see above)

2. IF M mentions `ToRequestContent`:
   → Remove the method call, use implicit cast

3. IF M mentions `FromCancellationToken`:
   → Replace with cancellationToken.ToRequestContext()

4. IF M mentions `FromResponse` on a model type:
   → Replace with explicit cast

5. IF M mentions `Fetch` method not found:
   → Replace with FromLroResponse pattern

6. IF M mentions `_pipeline` not found:
   → Replace with Pipeline property

7. IF M mentions `_serializedAdditionalRawData`:
   → Replace with _additionalBinaryDataProperties

8. IF M mentions `AutoRest.CSharp.Core`:
   → Remove the using statement

9. IF M mentions `CodeGenClient` or `CodeGenModel`:
   → Replace with CodeGenType
```

---

## Step 11: Build the full solution (including tests)

**Goal**: Ensure tests also compile after migration.

Follow the `sdk-migration` skill's "Test Project Build" phase:

1. Run `dotnet build` from the library root directory `{LIBRARY_PATH}` to build the full solution including tests.
2. If build errors occur in test projects, apply the same migration patterns above (test files are not generated, so edit them directly).
3. Repeat until the solution builds successfully.

---

## Step 12: Run tests

**Goal**: Verify tests pass after migration.

Follow the `sdk-migration` skill's "Test Execution" phase:

1. Run `dotnet test --no-build --filter "TestCategory!=Live"` from the library root directory.
2. Fix failures in test files, rebuild, and re-test.
3. Repeat (max 5 iterations).

---

## Step 13: Finalization

**Goal**: Run post-migration housekeeping.

Follow the `sdk-migration` skill's "Finalization" phase:

1. Export API: `.\eng\scripts\Export-API.ps1 -ServiceDirectory SERVICE_NAME`
2. Update snippets: `.\eng\scripts\Update-Snippets.ps1 -ServiceDirectory SERVICE_NAME`
3. Announce: "Migration completed successfully"

---

## Step 14: Verify and summarize

**Goal**: Confirm migration is complete.
**Actions**:

- Report a summary of all completed steps and any warnings.
- Note if any `CodeGenType` attributes may need manual updates due to type name changes.
- Remind the user to review the changes with `git diff` before committing.
- Suggest running `pre-commit-checks` skill before committing.
