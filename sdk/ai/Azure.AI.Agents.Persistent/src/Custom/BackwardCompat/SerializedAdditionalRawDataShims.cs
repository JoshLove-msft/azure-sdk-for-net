// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
// backward-compat: shim for renamed _additionalBinaryDataProperties field.
namespace Azure.AI.Agents.Persistent
{
    public partial class MessageDeltaTextAnnotation
    {
        /// <summary> Backward-compat shim for the renamed additional data property. </summary>
        protected internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set { if (value != null) foreach (var kvp in value) _additionalBinaryDataProperties[kvp.Key] = kvp.Value; }
        }
    }
    public partial class RunStepDeltaToolCall
    {
        /// <summary> Backward-compat shim for the renamed additional data property. </summary>
        protected internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set { if (value != null) foreach (var kvp in value) _additionalBinaryDataProperties[kvp.Key] = kvp.Value; }
        }
    }
}
