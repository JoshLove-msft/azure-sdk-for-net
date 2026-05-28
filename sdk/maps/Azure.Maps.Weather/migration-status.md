# Migration Status — Azure.Maps.Weather

**Last Updated:** 2026-05-29

## PRs

| PR | URL | Status |
|----|-----|--------|
| **Spec** | TypeSpec already merged to `main` (commit `0b8d8f25ae3`, PR #41399). PR #42486 only removes the legacy `@azure-tools/typespec-csharp` emitter config. | Merged / N/A |
| **SDK** | Not created | — |

## Branches

| Repo | Branch | Fork Remote |
|------|--------|-------------|
| azure-sdk-for-net | `joshlove-msft/migrate-azure-maps-weather-typespec` | origin |

## Generation Mode

`remote` — Weather TypeSpec is on `azure-rest-api-specs` main. `tsp-location.yaml` commit = `0b8d8f25ae31af3099165228c4cfcf0a3035515d`.
Generate with `dotnet build /t:GenerateCode` (no LocalSpecRepo).

## Phase Tracker

| Phase | Status | Notes |
|-------|--------|-------|
| Phase 0 — Sync & Resume | ✅ | Merged upstream/main (bumped emitter 20260415.3 → 20260528.3, fixing a generator type-init crash) |
| Phase 1 — Discovery & Planning | ✅ | Spec at specification/maps/data-plane/Weather (TypeSpec, csharp emitter configured) |
| Phase 2 — tsp-location.yaml | ✅ | commit set to main SHA `0b8d8f25ae3`, emitterPackageJsonPath verified |
| Phase 3 — Handle Legacy Configuration | ✅ | autorest.md + IncludeAutorestDependency already removed |
| Phase 4 — Update Custom Code | ✅ | Old hand-written src removed; CodeGenSuppress workaround added (see below) |
| Phase 5 — Code Generation | ✅ | Remote generation succeeded (199 generated files) |
| Phase 6 — Build-Fix Cycle (src) | ✅ | **src builds 0 errors on all TFMs (net8/net9/net10/netstandard2.0)** |
| Phase 7 — CHANGELOG | ⏭️ | |
| Phase 8 — Test Project Build | ❌ BLOCKED | Tests + Samples written against the OLD curated API — needs API-surface decision (see below) |
| Phase 9 — Test Execution | ⏭️ | |
| Phase 10 — Finalization | 🔄 | Export-API done (api/*.cs regenerated). Update-Snippets pending (blocked on samples). |
| Phase 11 — Pull Requests | ⏭️ | |
| Phase 12 — Verify & Summarize | ⏭️ | |

## csproj fixes (Phase 6)

The minimal generated csproj failed on netstandard2.0. Added to `src/Azure.Maps.Weather.csproj`:
- `<IncludeOperationsSharedSource>true</IncludeOperationsSharedSource>` (RawRequestUriBuilder, ClientDiagnostics, trimming attribute polyfills)
- shared sources `ExperimentalAttribute.cs` (fixes cascading SCME0002) and `AzureKeyCredentialPolicy.cs`

Modeled after `sdk/appconfiguration/Azure.Data.AppConfiguration/src/Azure.Data.AppConfiguration.csproj`.

## Known Issues

### Generator bug — optional enum query parameter projected as non-nullable `long`
- **Symptom:** `GetAirQualityDailyForecasts(Async)` / `GetAirQualityHourlyForecasts(Async)` had their `duration` query parameter (extensible int enums `DailyDuration` / `HourlyDuration`) emitted as non-nullable `long` in the protocol method and REST request builder, while surrounding generated code treats it as nullable (`duration?.ToSerialInt64()`, `if (duration != null)`). Produced CS1503 ×4 and CS0472 ×2.
- **Confirmed not customization-caused** (no Custom/ folder existed; the correct sibling op `GetHourlyForecast` generates `int? duration` properly).
- **Root cause:** base TypeSpec C# emitter (microsoft/typespec `packages/http-client-csharp`) — not the in-repo Azure DPG emitter (`ToSerialInt64` is base-emitter output). A real fix is upstream.
- **Workaround applied:** `src/MapsWeatherClient.AirQualityForecasts.cs` uses `[CodeGenSuppress]` on the 6 affected members (2 protocol + 2 protocol-async + 2 request builders) and re-declares them with `long?`. Remove this file once the base emitter is fixed and regenerate.
- **TODO:** file an upstream issue against microsoft/typespec.

### BLOCKER — API surface change breaks tests & samples (Phase 8)
The pre-migration `Azure.Maps.Weather` shipped a **hand-curated** API (Options objects like `GetAirQualityDailyForecastsOptions`, `WeatherLanguage` enum, `GeoPosition` coordinates, wrapper response models). The TypeSpec generator produces the **raw DPG API** (positional params, `JsonFormat format`, `IEnumerable<double> coordinates`, `DailyDuration?` etc.). `tests/MapsWeatherTests.cs` and `tests/Samples/WeatherClientSamples.cs` (~800 lines) are written entirely against the old API and do not compile.

**Open product decision required:**
- **Option A:** Add extensive customization (client.tsp `@@clientName`/`@@access` + SDK custom code + backward-compat shims) to preserve the curated public API. Large effort; minimizes breaking changes.
- **Option B:** Ship the new generated API as a breaking change (treat as new beta — current csproj is `1.0.0-beta.1`, no ApiCompatVersion). Rewrite tests + samples + README against the new surface.

src already reflects Option B's surface. No decision recorded yet — do not assume.

## Next Steps

1. Decide API-surface direction (Option A vs B above).
2. Rewrite or shim tests/samples accordingly; build the test project (Phase 8).
3. Update CHANGELOG.md (Phase 7) and run Update-Snippets (Phase 10).
4. Create SDK PR (Phase 11); file upstream generator issue.
