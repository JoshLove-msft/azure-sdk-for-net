using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core.Http;
using Azure.Core.Pipeline;

namespace Azure.Storage.Blobs
{
    class StorageRetryRequestModifier : RetryRequestModifier
    {
        public StorageRetryRequestModifier(Uri PrimaryUri, Uri SecondaryUri)
            :base()
        {
            this.PrimaryUri = PrimaryUri;
            this.SecondaryUri = SecondaryUri;
        }
        public override void onBeforeRetryPolicy(HttpPipelineMessage message)
        {
            this.toggleUri(message);
            base.onBeforeRetryPolicy(message);
        }

        private void toggleUri(HttpPipelineMessage message)
        {
            if (message.Request.Method == RequestMethod.Get && // only GET requests support secondary URI currently
                this.PrimaryUri != null && this.SecondaryUri != null)
            {
                message.Request.UriBuilder.Uri = message.Request.UriBuilder.Uri.AbsoluteUri != this.SecondaryUri.AbsoluteUri ? this.SecondaryUri : this.PrimaryUri;
            }
        }
        public Uri PrimaryUri { get; set; }

        public Uri SecondaryUri { get; set; }
    }
}
