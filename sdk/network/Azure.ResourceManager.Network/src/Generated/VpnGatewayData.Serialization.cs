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
    public partial class VpnGatewayData : IUtf8JsonSerializable, IJsonModel<VpnGatewayData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnGatewayData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VpnGatewayData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnGatewayData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub"u8);
                ((IJsonModel<WritableSubResource>)VirtualHub).Write(writer, options);
            }
            if (Optional.IsCollectionDefined(Connections))
            {
                writer.WritePropertyName("connections"u8);
                writer.WriteStartArray();
                foreach (var item in Connections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BgpSettings))
            {
                writer.WritePropertyName("bgpSettings"u8);
                writer.WriteObjectValue(BgpSettings, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(VpnGatewayScaleUnit))
            {
                writer.WritePropertyName("vpnGatewayScaleUnit"u8);
                writer.WriteNumberValue(VpnGatewayScaleUnit.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableBgpRouteTranslationForNat))
            {
                writer.WritePropertyName("enableBgpRouteTranslationForNat"u8);
                writer.WriteBooleanValue(EnableBgpRouteTranslationForNat.Value);
            }
            if (Optional.IsDefined(IsRoutingPreferenceInternet))
            {
                writer.WritePropertyName("isRoutingPreferenceInternet"u8);
                writer.WriteBooleanValue(IsRoutingPreferenceInternet.Value);
            }
            if (Optional.IsCollectionDefined(NatRules))
            {
                writer.WritePropertyName("natRules"u8);
                writer.WriteStartArray();
                foreach (var item in NatRules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        VpnGatewayData IJsonModel<VpnGatewayData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnGatewayData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnGatewayData(document.RootElement, options);
        }

        internal static VpnGatewayData DeserializeVpnGatewayData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            WritableSubResource virtualHub = default;
            IList<VpnConnectionData> connections = default;
            BgpSettings bgpSettings = default;
            NetworkProvisioningState? provisioningState = default;
            int? vpnGatewayScaleUnit = default;
            IReadOnlyList<VpnGatewayIPConfiguration> ipConfigurations = default;
            bool? enableBgpRouteTranslationForNat = default;
            bool? isRoutingPreferenceInternet = default;
            IList<VpnGatewayNatRuleData> natRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("virtualHub"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualHub = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property0.Value.GetRawText())), options, AzureResourceManagerNetworkContext.Default);
                            continue;
                        }
                        if (property0.NameEquals("connections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnConnectionData> array = new List<VpnConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnConnectionData.DeserializeVpnConnectionData(item, options));
                            }
                            connections = array;
                            continue;
                        }
                        if (property0.NameEquals("bgpSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bgpSettings = BgpSettings.DeserializeBgpSettings(property0.Value, options);
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
                        if (property0.NameEquals("vpnGatewayScaleUnit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnGatewayScaleUnit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnGatewayIPConfiguration> array = new List<VpnGatewayIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnGatewayIPConfiguration.DeserializeVpnGatewayIPConfiguration(item, options));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("enableBgpRouteTranslationForNat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBgpRouteTranslationForNat = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isRoutingPreferenceInternet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isRoutingPreferenceInternet = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("natRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnGatewayNatRuleData> array = new List<VpnGatewayNatRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnGatewayNatRuleData.DeserializeVpnGatewayNatRuleData(item, options));
                            }
                            natRules = array;
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
            return new VpnGatewayData(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                etag,
                virtualHub,
                connections ?? new ChangeTrackingList<VpnConnectionData>(),
                bgpSettings,
                provisioningState,
                vpnGatewayScaleUnit,
                ipConfigurations ?? new ChangeTrackingList<VpnGatewayIPConfiguration>(),
                enableBgpRouteTranslationForNat,
                isRoutingPreferenceInternet,
                natRules ?? new ChangeTrackingList<VpnGatewayNatRuleData>());
        }

        BinaryData IPersistableModel<VpnGatewayData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VpnGatewayData)} does not support writing '{options.Format}' format.");
            }
        }

        VpnGatewayData IPersistableModel<VpnGatewayData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVpnGatewayData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnGatewayData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnGatewayData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
