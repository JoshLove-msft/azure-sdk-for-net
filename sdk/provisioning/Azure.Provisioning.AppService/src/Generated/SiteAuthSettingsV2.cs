// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// SiteAuthSettingsV2.
/// </summary>
public partial class SiteAuthSettingsV2 : ProvisionableResource
{
    private BicepValue<string>? _name;

    /// <summary>
    /// The configuration settings that determines the validation flow of users
    /// using App Service Authentication/Authorization.
    /// </summary>
    public GlobalValidation GlobalValidation 
    {
        get { Initialize(); return _globalValidation!; }
        set { Initialize(); AssignOrReplace(ref _globalValidation, value); }
    }
    private GlobalValidation? _globalValidation;

    /// <summary>
    /// The configuration settings of the HTTP requests for authentication and
    /// authorization requests made against App Service
    /// Authentication/Authorization.
    /// </summary>
    public AppServiceHttpSettings HttpSettings 
    {
        get { Initialize(); return _httpSettings!; }
        set { Initialize(); AssignOrReplace(ref _httpSettings, value); }
    }
    private AppServiceHttpSettings? _httpSettings;

    /// <summary>
    /// The configuration settings of each of the identity providers used to
    /// configure App Service Authentication/Authorization.
    /// </summary>
    public AppServiceIdentityProviders IdentityProviders 
    {
        get { Initialize(); return _identityProviders!; }
        set { Initialize(); AssignOrReplace(ref _identityProviders, value); }
    }
    private AppServiceIdentityProviders? _identityProviders;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<string>? _kind;

    /// <summary>
    /// The configuration settings of the login flow of users using App Service
    /// Authentication/Authorization.
    /// </summary>
    public WebAppLoginInfo Login 
    {
        get { Initialize(); return _login!; }
        set { Initialize(); AssignOrReplace(ref _login, value); }
    }
    private WebAppLoginInfo? _login;

    /// <summary>
    /// The configuration settings of the platform of App Service
    /// Authentication/Authorization.
    /// </summary>
    public AuthPlatform Platform 
    {
        get { Initialize(); return _platform!; }
        set { Initialize(); AssignOrReplace(ref _platform, value); }
    }
    private AuthPlatform? _platform;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Get the default value for the Name property.
    /// </summary>
    private partial BicepValue<string> GetNameDefaultValue();

    /// <summary>
    /// Creates a new SiteAuthSettingsV2.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SiteAuthSettingsV2 resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SiteAuthSettingsV2.</param>
    public SiteAuthSettingsV2(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Web/sites/config", resourceVersion)
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SiteAuthSettingsV2.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], defaultValue: GetNameDefaultValue());
        _globalValidation = DefineModelProperty<GlobalValidation>("GlobalValidation", ["properties", "globalValidation"]);
        _httpSettings = DefineModelProperty<AppServiceHttpSettings>("HttpSettings", ["properties", "httpSettings"]);
        _identityProviders = DefineModelProperty<AppServiceIdentityProviders>("IdentityProviders", ["properties", "identityProviders"]);
        _kind = DefineProperty<string>("Kind", ["kind"]);
        _login = DefineModelProperty<WebAppLoginInfo>("Login", ["properties", "login"]);
        _platform = DefineModelProperty<AuthPlatform>("Platform", ["properties", "platform"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Creates a reference to an existing SiteAuthSettingsV2.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SiteAuthSettingsV2 resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SiteAuthSettingsV2.</param>
    /// <returns>The existing SiteAuthSettingsV2 resource.</returns>
    public static SiteAuthSettingsV2 FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
