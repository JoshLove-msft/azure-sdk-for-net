// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.OracleDatabase
{
    /// <summary>
    /// A Class representing an OracleGIVersion along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="OracleGIVersionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetOracleGIVersionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetOracleGIVersion method.
    /// </summary>
    public partial class OracleGIVersionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="OracleGIVersionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="location"> The location. </param>
        /// <param name="giversionname"> The giversionname. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string giversionname)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/giVersions/{giversionname}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _oracleGIVersionGiVersionsClientDiagnostics;
        private readonly GiVersionsRestOperations _oracleGIVersionGiVersionsRestClient;
        private readonly OracleGIVersionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Oracle.Database/locations/giVersions";

        /// <summary> Initializes a new instance of the <see cref="OracleGIVersionResource"/> class for mocking. </summary>
        protected OracleGIVersionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OracleGIVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal OracleGIVersionResource(ArmClient client, OracleGIVersionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="OracleGIVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal OracleGIVersionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _oracleGIVersionGiVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OracleDatabase", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string oracleGIVersionGiVersionsApiVersion);
            _oracleGIVersionGiVersionsRestClient = new GiVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, oracleGIVersionGiVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual OracleGIVersionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of OracleGIMinorVersionResources in the OracleGIVersion. </summary>
        /// <returns> An object representing collection of OracleGIMinorVersionResources and their operations over a OracleGIMinorVersionResource. </returns>
        public virtual OracleGIMinorVersionCollection GetOracleGIMinorVersions()
        {
            return GetCachedClient(client => new OracleGIMinorVersionCollection(client, Id));
        }

        /// <summary>
        /// Get a GiMinorVersion
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/giVersions/{giversionname}/giMinorVersions/{giMinorVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GiMinorVersion_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OracleGIMinorVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="giMinorVersionName"> The name of the GiMinorVersion. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="giMinorVersionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="giMinorVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<OracleGIMinorVersionResource>> GetOracleGIMinorVersionAsync(string giMinorVersionName, CancellationToken cancellationToken = default)
        {
            return await GetOracleGIMinorVersions().GetAsync(giMinorVersionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a GiMinorVersion
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/giVersions/{giversionname}/giMinorVersions/{giMinorVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GiMinorVersion_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OracleGIMinorVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="giMinorVersionName"> The name of the GiMinorVersion. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="giMinorVersionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="giMinorVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<OracleGIMinorVersionResource> GetOracleGIMinorVersion(string giMinorVersionName, CancellationToken cancellationToken = default)
        {
            return GetOracleGIMinorVersions().Get(giMinorVersionName, cancellationToken);
        }

        /// <summary>
        /// Get a GiVersion
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/giVersions/{giversionname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GiVersion_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OracleGIVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OracleGIVersionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _oracleGIVersionGiVersionsClientDiagnostics.CreateScope("OracleGIVersionResource.Get");
            scope.Start();
            try
            {
                var response = await _oracleGIVersionGiVersionsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OracleGIVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a GiVersion
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/giVersions/{giversionname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GiVersion_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OracleGIVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OracleGIVersionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _oracleGIVersionGiVersionsClientDiagnostics.CreateScope("OracleGIVersionResource.Get");
            scope.Start();
            try
            {
                var response = _oracleGIVersionGiVersionsRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OracleGIVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
