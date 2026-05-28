# Migration Status — Azure.Maps.Weather

**Last Updated:** 2026-05-28

## PRs

| PR | URL | Status |
|----|-----|--------|
| **Spec** | https://github.com/Azure/azure-rest-api-specs/pull/42486 | Open (pre-existing) |
| **SDK** | Not created | — |

## Branches

| Repo | Branch | Fork Remote |
|------|--------|-------------|
| azure-sdk-for-net | `joshlove-msft/migrate-azure-maps-weather-typespec` | origin |
| azure-rest-api-specs | `remove-typespec-csharp` (HEAD `7c18c4c4`) | origin |

## Generation Mode

`local` — spec PR not yet merged to main. Use `/p:LocalSpecRepo=C:\Users\jolov\repos\azure-rest-api-specs`.
After spec PR merges, switch to remote with the merged-to-main SHA and final regenerate.

## Phase Tracker

| Phase | Status | Notes |
|-------|--------|-------|
| Phase 0 — Sync & Resume | ✅ | Discovery complete |
| Phase 1 — Discovery & Planning | ✅ | Spec at specification/maps/data-plane/Weather (TypeSpec, csharp emitter configured) |
| Phase 2 — Create tsp-location.yaml | ⏭️ | |
| Phase 3 — Handle Legacy Configuration | ⏭️ | Delete autorest.md, remove IncludeAutorestDependency |
| Phase 4 — Update Custom Code | ⏭️ | |
| Phase 5 — Code Generation | ⏭️ | |
| Phase 6 — Build-Fix Cycle | ⏭️ | |
| Phase 7 — CHANGELOG | ⏭️ | |
| Phase 8 — Test Project Build | ⏭️ | |
| Phase 9 — Test Execution | ⏭️ | |
| Phase 10 — Finalization | ⏭️ | |
| Phase 11 — Pull Requests | ⏭️ | |
| Phase 12 — Verify & Summarize | ⏭️ | |

## Notes

- Existing SDK is Swagger/AutoRest-based (`src/autorest.md`, swagger commit `48dcf5d2`)
- Existing `src/MapsWeatherClient.cs` is hand-written and wraps `WeatherRestClient` (generated)
- `src/Models/` contains a mix of hand-written models (GeoJson*, WeatherLanguage, Options/*, WeatherAlongRouteQuery, etc.) and partial serialization overrides
- Existing spec `client.tsp` already has extensive `@@clientName` decorators — won't re-apply
