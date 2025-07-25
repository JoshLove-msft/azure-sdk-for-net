# Release History

## 1.6.0-beta.1 (Unreleased)

### Features Added

### Breaking Changes

### Bugs Fixed

### Other Changes

## 1.5.0 (2025-07-02)

### Features Added

- Upgraded api-version tag from 'package-2023-09-01' to 'package-2024-09-01'. Tag detail available at https://github.com/Azure/azure-rest-api-specs/blob/802ded7f507321d74f4594edf2a78732b83edda6/specification/vmware/resource-manager/readme.md.
- Added Host, Provisioned Network, Pure Storage Policy Resource and Collection classes

### Other Changes

- Generated using typespec

## 1.4.0 (2024-10-28)

### Features Added

- Upgraded api-version tag from 'package-2023-03-01' to 'package-2023-09-01'. Tag detail available at https://github.com/Azure/azure-rest-api-specs/blob/e19b5771846718774c0452800b9a42c251319f48/specification/vmware/resource-manager/readme.md.
    - WorkloadNetworkResource is now a singleton resource
- Exposed `JsonModelWriteCore` for model serialization procedure.

## 1.3.0 (2024-01-22)

### Features Added

- Upgraded api-version tag from 'package-2022-05-01' to 'package-2023-03-01'. Tag detail available at https://github.com/Azure/azure-rest-api-specs/blob/a032c2413b49d297196a0c64393e862433fccbb1/specification/vmware/resource-manager/readme.md.
    - Added ExtendedNetworkBlocks to AvsPrivateCloudData class
- Enable the new model serialization by using the System.ClientModel, refer this [document](https://aka.ms/azsdk/net/mrw) for more details.

### Other Changes

- Upgraded dependent `Azure.ResourceManager` to 1.10.0.

## 1.2.0 (2023-11-27)

### Features Added

- Enable mocking for extension methods, refer this [document](https://aka.ms/azsdk/net/mocking) for more details.

### Other Changes

- Upgraded dependent `Azure.ResourceManager` to 1.9.0.

## 1.2.0-beta.1 (2023-05-25)

### Features Added

- Enable the model factory feature for model mocking, more information can be found [here](https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-mocking-factory-builder).

### Other Changes

- Upgraded dependent Azure.Core to 1.32.0.
- Upgraded dependent Azure.ResourceManager to 1.6.0.

## 1.1.1 (2023-02-16)

### Other Changes

- Upgraded dependent `Azure.Core` to `1.28.0`.
- Upgraded dependent `Azure.ResourceManager` to `1.4.0`.

## 1.1.0 (2022-10-19)

### Other Changes

- Upgraded API version to 2022-05-01

## 1.0.0 (2022-09-13)

This release is the first stable release of the Azure VMware Solution management library.

### Breaking Changes

Polishing since last public beta release:
- Prepended `Avs` prefix to all single / simple model names.
- Corrected the format of all `ResourceIdentifier` type properties / parameters.
- Optimized the name of some models and functions.

### Other Changes

- Upgraded dependent Azure.ResourceManager to 1.3.1.
- Optimized the implementation of methods related to tag operations.

## 1.0.0-beta.1 (2022-08-18)

### Breaking Changes

New design of track 2 initial commit.

### Package Name

The package name has been changed from `Microsoft.Azure.Management.Avs` to `Azure.ResourceManager.Avs`.

### General New Features

This package follows the [new Azure SDK guidelines](https://azure.github.io/azure-sdk/general_introduction.html), and provides many core capabilities:

    - Support MSAL.NET, Azure.Identity is out of box for supporting MSAL.NET.
    - Support [OpenTelemetry](https://opentelemetry.io/) for distributed tracing.
    - HTTP pipeline with custom policies.
    - Better error-handling.
    - Support uniform telemetry across all languages.

This package is a Public Preview version, so expect incompatible changes in subsequent releases as we improve the product. To provide feedback, submit an issue in our [Azure SDK for .NET GitHub repo](https://github.com/Azure/azure-sdk-for-net/issues).

> NOTE: For more information about unified authentication, please refer to [Microsoft Azure Identity documentation for .NET](https://learn.microsoft.com/dotnet/api/overview/azure/identity-readme?view=azure-dotnet).
