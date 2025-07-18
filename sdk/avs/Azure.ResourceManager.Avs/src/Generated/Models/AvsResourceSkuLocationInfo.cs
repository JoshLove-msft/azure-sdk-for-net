// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Describes an available Compute SKU Location Information. </summary>
    public partial class AvsResourceSkuLocationInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AvsResourceSkuLocationInfo"/>. </summary>
        /// <param name="location"> Location of the SKU. </param>
        /// <param name="zones"> List of availability zones where the SKU is supported. </param>
        /// <param name="zoneDetails"> Gets details of capabilities available to a SKU in specific zones. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="zones"/> or <paramref name="zoneDetails"/> is null. </exception>
        internal AvsResourceSkuLocationInfo(AzureLocation location, IEnumerable<string> zones, IEnumerable<AvsResourceSkuZoneDetails> zoneDetails)
        {
            Argument.AssertNotNull(zones, nameof(zones));
            Argument.AssertNotNull(zoneDetails, nameof(zoneDetails));

            Location = location;
            Zones = zones.ToList();
            ZoneDetails = zoneDetails.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AvsResourceSkuLocationInfo"/>. </summary>
        /// <param name="location"> Location of the SKU. </param>
        /// <param name="zones"> List of availability zones where the SKU is supported. </param>
        /// <param name="zoneDetails"> Gets details of capabilities available to a SKU in specific zones. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvsResourceSkuLocationInfo(AzureLocation location, IReadOnlyList<string> zones, IReadOnlyList<AvsResourceSkuZoneDetails> zoneDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Zones = zones;
            ZoneDetails = zoneDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AvsResourceSkuLocationInfo"/> for deserialization. </summary>
        internal AvsResourceSkuLocationInfo()
        {
        }

        /// <summary> Location of the SKU. </summary>
        public AzureLocation Location { get; }
        /// <summary> List of availability zones where the SKU is supported. </summary>
        public IReadOnlyList<string> Zones { get; }
        /// <summary> Gets details of capabilities available to a SKU in specific zones. </summary>
        public IReadOnlyList<AvsResourceSkuZoneDetails> ZoneDetails { get; }
    }
}
