// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Communication.Messages
{
    public partial class MessageTemplateValue
    {
        /// <summary> Initializes a new instance of <see cref="MessageTemplateValue"/>. </summary>
        /// <param name="name"> Template binding reference name. </param>
        protected MessageTemplateValue(string name) : this(name, default)
        {
        }
    }
}
