// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.Communication.Messages
{
    [CodeGenSuppress("MessageTemplateBindings")]
    public partial class MessageTemplateBindings
    {
        /// <summary> Initializes a new instance of <see cref="MessageTemplateBindings"/>. </summary>
        protected MessageTemplateBindings() : this(default)
        {
        }
    }
}
