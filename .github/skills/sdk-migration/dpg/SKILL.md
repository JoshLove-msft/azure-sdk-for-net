---
name: sdk-migration/dpg
description: Migrate an Azure SDK for .NET data-plane library from the old AutoRest-based generator to the new TypeSpec generator. Updates configuration, replaces deprecated attributes and APIs, regenerates code, and iteratively fixes build errors.
---
# Skill: sdk-migration/dpg

Migrate a .NET data-plane SDK library from the old AutoRest-based C# code generator to the new TypeSpec-based generator.

> **Shared foundation**: This skill extends the `sdk-migration` skill. Follow that skill for the step-by-step workflow (validation, tsp-location.yaml, code generation, build-fix cycle, test execution, finalization, safety rules). This file covers only data-plane-specific patterns and configuration.

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

## DPG-Specific Configuration

When running the shared skill's "Create/Update tsp-location.yaml" phase, use these DPG-specific values:

- `EMITTER_PACKAGE_JSON_PATH` = `eng/azure-typespec-http-client-csharp-emitter-package.json`
- Target emitter name for commit resolution: `azure-typespec/http-client-csharp`
- If `emitterPackageJsonPath` is not present, add it.
- If the file already contains the new emitter path, skip the emitter update (but still verify the commit SHA).

---

## DPG Code Transformations

Apply these transformations to all non-Generated `.cs` files under `{LIBRARY_PATH}/src/` **before** running code generation:

### Replace `_pipeline` with `Pipeline`
- Replace `_pipeline` → `Pipeline` (word-boundary match only).
- The private pipeline field reference has been replaced by a new public property.

### Remove `AutoRest.CSharp.Core` using statements
- Remove lines matching `using AutoRest.CSharp.Core;`.

### Replace `_serializedAdditionalRawData` with `_additionalBinaryDataProperties`
- Replace `_serializedAdditionalRawData` → `_additionalBinaryDataProperties`
- Replace `serializedAdditionalRawData` → `additionalBinaryDataProperties`

---

## DPG Migration Patterns

These patterns are specific to data-plane migrations. Apply them during the shared skill's "Build-Fix Cycle" phase, in addition to the common customization patterns.

### `GeneratorPageableHelpers` → `CollectionResult` pattern
- If code uses `GeneratorPageableHelpers.CreatePageable` or similar, replace it with the corresponding generated `CollectionResult` type from the `Generated/` folder.
- If no `CollectionResult` type exists in `Generated/`:
  1. Look for a `[CodeGenSuppress]` attribute that suppresses the internal method which would create the `CollectionResult`.
  2. Comment out or remove that `[CodeGenSuppress]` attribute.
  3. Re-run code generation to produce the `CollectionResult` type.
  4. After regeneration, use the generated type.
- Do NOT create `CollectionResult` types manually — they must be generated.

### `ToRequestContent()` removal
- Input models now have an implicit cast to `RequestContent`.
- Replace `foo.ToRequestContent()` with just `foo`.
- Example: `using RequestContent content = details.ToRequestContent();` → `using RequestContent content = details;`
- **Keep** the `using` statement; only remove the `.ToRequestContent()` call.

### `FromCancellationToken` replacement
- Replace `RequestContext context = FromCancellationToken(cancellationToken);`
- With `RequestContext context = cancellationToken.ToRequestContext();`

### Mismatched `ModelFactory` type names
- If a custom type ending in `ModelFactory` has a different name than the generated type ending in `ModelFactory`, update the `CodeGenType` attribute in the custom type to match the generated type name.

### Mismatched `ClientBuilderExtensions` type names
- If a custom type ending in `ClientBuilderExtensions` has a different name than the generated type ending in `ClientBuilderExtensions`, update the `CodeGenType` attribute in the custom type to match the generated type name.

### Fetch methods in custom LRO methods
- The old `Fetch` methods are replaced by static `FromLroResponse` methods on the response models.
- Update custom LRO methods to use `ResponseModel.FromLroResponse(response)` instead of calling `Fetch` methods.
- Do NOT create `Fetch` methods manually — call the generated `FromLroResponse` method.

### `FromResponse` method removal
- `FromResponse` methods have been removed from models.
- Use explicit cast from `Response` to the model type instead.
- Example: `var model = ModelType.FromResponse(response);` → `var model = (ModelType)response;`

### Generator and customization file interaction
- The generator reads existing customization files (partial classes with `[CodeGenSuppress]`, `[CodeGenType]`, etc.) and produces **different output** based on them.
- Errors in `Generated/` files are often **caused** by stale customization files, not generator bugs.
- Fixing a `Generated/` error usually means editing or removing the customization file that caused it, then re-running code generation so the generator produces correct output without the stale influence.
- Only after eliminating customization interference can you identify true generator bugs.

---

## DPG Error Classification

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
