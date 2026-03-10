// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Communication.Messages
{
    public partial class MessageTemplateItem
    {
        /// <summary> Initializes a new instance of <see cref="MessageTemplateItem"/>. </summary>
        /// <param name="language"> The template's language, in the ISO 639 format, consist of a two letter language code followed by an optional two letter country code, e.g., 'en' or 'en_US'. </param>
        /// <param name="status"> The aggregated template status. </param>
        protected MessageTemplateItem(string language, MessageTemplateStatus status) : this(language, status, default)
        {
        }
    }
}
