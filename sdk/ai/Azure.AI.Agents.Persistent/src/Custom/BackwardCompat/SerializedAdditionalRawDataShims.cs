// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
using Azure.Core;
// backward-compat: In the 1.0.0 baseline the code-generator emitted a
// protected-internal FIELD named SerializedAdditionalRawData.  The new
// generator renamed it to _additionalBinaryDataProperties.  To satisfy
// ApiCompat we re-declare the old field name and wire it to the same backing
// instance during construction.
namespace Azure.AI.Agents.Persistent
{
    public abstract partial class MessageDeltaTextAnnotation
    {
#pragma warning disable SA1307 // Accessible fields should begin with upper-case letter
#pragma warning disable SA1401 // Fields should be private
        /// <summary> Backward-compat alias for <c>_additionalBinaryDataProperties</c>. </summary>
        protected internal IDictionary<string, BinaryData> SerializedAdditionalRawData;
#pragma warning restore SA1401
#pragma warning restore SA1307
    }
    public abstract partial class RunStepDeltaToolCall
    {
#pragma warning disable SA1307
#pragma warning disable SA1401
        /// <summary> Backward-compat alias for <c>_additionalBinaryDataProperties</c>. </summary>
        protected internal IDictionary<string, BinaryData> SerializedAdditionalRawData;
#pragma warning restore SA1401
#pragma warning restore SA1307
    }
}
