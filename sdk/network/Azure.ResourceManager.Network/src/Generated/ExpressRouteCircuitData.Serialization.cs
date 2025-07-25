// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRouteCircuitData : IUtf8JsonSerializable, IJsonModel<ExpressRouteCircuitData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteCircuitData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExpressRouteCircuitData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AllowClassicOperations))
            {
                writer.WritePropertyName("allowClassicOperations"u8);
                writer.WriteBooleanValue(AllowClassicOperations.Value);
            }
            if (Optional.IsDefined(CircuitProvisioningState))
            {
                writer.WritePropertyName("circuitProvisioningState"u8);
                writer.WriteStringValue(CircuitProvisioningState);
            }
            if (Optional.IsDefined(ServiceProviderProvisioningState))
            {
                writer.WritePropertyName("serviceProviderProvisioningState"u8);
                writer.WriteStringValue(ServiceProviderProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Authorizations))
            {
                writer.WritePropertyName("authorizations"u8);
                writer.WriteStartArray();
                foreach (var item in Authorizations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Peerings))
            {
                writer.WritePropertyName("peerings"u8);
                writer.WriteStartArray();
                foreach (var item in Peerings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ServiceKey))
            {
                writer.WritePropertyName("serviceKey"u8);
                writer.WriteStringValue(ServiceKey);
            }
            if (Optional.IsDefined(ServiceProviderNotes))
            {
                writer.WritePropertyName("serviceProviderNotes"u8);
                writer.WriteStringValue(ServiceProviderNotes);
            }
            if (Optional.IsDefined(ServiceProviderProperties))
            {
                writer.WritePropertyName("serviceProviderProperties"u8);
                writer.WriteObjectValue(ServiceProviderProperties, options);
            }
            if (Optional.IsDefined(ExpressRoutePort))
            {
                writer.WritePropertyName("expressRoutePort"u8);
                ((IJsonModel<WritableSubResource>)ExpressRoutePort).Write(writer, options);
            }
            if (Optional.IsDefined(BandwidthInGbps))
            {
                writer.WritePropertyName("bandwidthInGbps"u8);
                writer.WriteNumberValue(BandwidthInGbps.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(STag))
            {
                writer.WritePropertyName("stag"u8);
                writer.WriteNumberValue(STag.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(GatewayManagerETag))
            {
                writer.WritePropertyName("gatewayManagerEtag"u8);
                writer.WriteStringValue(GatewayManagerETag);
            }
            if (Optional.IsDefined(GlobalReachEnabled))
            {
                writer.WritePropertyName("globalReachEnabled"u8);
                writer.WriteBooleanValue(GlobalReachEnabled.Value);
            }
            if (Optional.IsDefined(AuthorizationKey))
            {
                writer.WritePropertyName("authorizationKey"u8);
                writer.WriteStringValue(AuthorizationKey);
            }
            if (options.Format != "W" && Optional.IsDefined(AuthorizationStatus))
            {
                writer.WritePropertyName("authorizationStatus"u8);
                writer.WriteStringValue(AuthorizationStatus);
            }
            if (Optional.IsDefined(EnableDirectPortRateLimit))
            {
                writer.WritePropertyName("enableDirectPortRateLimit"u8);
                writer.WriteBooleanValue(EnableDirectPortRateLimit.Value);
            }
            writer.WriteEndObject();
        }

        ExpressRouteCircuitData IJsonModel<ExpressRouteCircuitData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteCircuitData(document.RootElement, options);
        }

        internal static ExpressRouteCircuitData DeserializeExpressRouteCircuitData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExpressRouteCircuitSku sku = default;
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            bool? allowClassicOperations = default;
            string circuitProvisioningState = default;
            ServiceProviderProvisioningState? serviceProviderProvisioningState = default;
            IList<ExpressRouteCircuitAuthorizationData> authorizations = default;
            IList<ExpressRouteCircuitPeeringData> peerings = default;
            string serviceKey = default;
            string serviceProviderNotes = default;
            ExpressRouteCircuitServiceProviderProperties serviceProviderProperties = default;
            WritableSubResource expressRoutePort = default;
            float? bandwidthInGbps = default;
            int? stag = default;
            NetworkProvisioningState? provisioningState = default;
            string gatewayManagerETag = default;
            bool? globalReachEnabled = default;
            string authorizationKey = default;
            string authorizationStatus = default;
            bool? enableDirectPortRateLimit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ExpressRouteCircuitSku.DeserializeExpressRouteCircuitSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("allowClassicOperations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowClassicOperations = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("circuitProvisioningState"u8))
                        {
                            circuitProvisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceProviderProvisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceProviderProvisioningState = new ServiceProviderProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("authorizations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteCircuitAuthorizationData> array = new List<ExpressRouteCircuitAuthorizationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteCircuitAuthorizationData.DeserializeExpressRouteCircuitAuthorizationData(item, options));
                            }
                            authorizations = array;
                            continue;
                        }
                        if (property0.NameEquals("peerings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteCircuitPeeringData> array = new List<ExpressRouteCircuitPeeringData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteCircuitPeeringData.DeserializeExpressRouteCircuitPeeringData(item, options));
                            }
                            peerings = array;
                            continue;
                        }
                        if (property0.NameEquals("serviceKey"u8))
                        {
                            serviceKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceProviderNotes"u8))
                        {
                            serviceProviderNotes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceProviderProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceProviderProperties = ExpressRouteCircuitServiceProviderProperties.DeserializeExpressRouteCircuitServiceProviderProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("expressRoutePort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRoutePort = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property0.Value.GetRawText())), options, AzureResourceManagerNetworkContext.Default);
                            continue;
                        }
                        if (property0.NameEquals("bandwidthInGbps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bandwidthInGbps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("stag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stag = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("gatewayManagerEtag"u8))
                        {
                            gatewayManagerETag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("globalReachEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            globalReachEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("authorizationKey"u8))
                        {
                            authorizationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authorizationStatus"u8))
                        {
                            authorizationStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableDirectPortRateLimit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDirectPortRateLimit = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExpressRouteCircuitData(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                sku,
                etag,
                allowClassicOperations,
                circuitProvisioningState,
                serviceProviderProvisioningState,
                authorizations ?? new ChangeTrackingList<ExpressRouteCircuitAuthorizationData>(),
                peerings ?? new ChangeTrackingList<ExpressRouteCircuitPeeringData>(),
                serviceKey,
                serviceProviderNotes,
                serviceProviderProperties,
                expressRoutePort,
                bandwidthInGbps,
                stag,
                provisioningState,
                gatewayManagerETag,
                globalReachEnabled,
                authorizationKey,
                authorizationStatus,
                enableDirectPortRateLimit);
        }

        BinaryData IPersistableModel<ExpressRouteCircuitData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteCircuitData)} does not support writing '{options.Format}' format.");
            }
        }

        ExpressRouteCircuitData IPersistableModel<ExpressRouteCircuitData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExpressRouteCircuitData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteCircuitData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteCircuitData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
