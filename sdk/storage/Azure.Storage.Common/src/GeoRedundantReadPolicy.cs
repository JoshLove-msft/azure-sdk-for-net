using System;
using System.Net;
using Azure.Core.Pipeline;

namespace Azure.Storage.Common
{
    internal class GeoRedundantReadPolicy : SynchronousHttpPipelinePolicy
    {
        private const string PreviousHostSetting = "Azure.Storage.Common.PreviousHost";
        private const string ResourceNotReplicatedToSecondaryStorage = "Azure.Storage.Common.ResourceNotReplicatedToSecondaryStorage";

        public string _secondaryStorageHost;

        public GeoRedundantReadPolicy(Uri secondaryStorageUri) => this._secondaryStorageHost = secondaryStorageUri.Host;

        public override void OnSendingRequest(HttpPipelineMessage message)
        {
            if (this._secondaryStorageHost == null)
            {
                return;
            }
            var resourceNotReplicatedToSecondaryStorage = message.TryGetProperty(ResourceNotReplicatedToSecondaryStorage, out var resourceNotReplicatedValue) ? false : (bool)resourceNotReplicatedValue;
            if (resourceNotReplicatedToSecondaryStorage) // if the flag has been set, then we must currently be using the primary storage host and we do not want to allow switching to the secondary host. As a result, we don't need to worry about the case of getting stuck on the secondary host, so it is safe to just return here.
            {
                return;
            }
            var currentHost = message.Request.UriBuilder.Host;
            var previousHost = !message.TryGetProperty(PreviousHostSetting, out var previousHostObj) ? previousHostObj as string : null;
            if (message.Request.Method == RequestMethod.Get || message.Request.Method == RequestMethod.Head)
            {
                if ((HttpStatusCode)message.Response.Status == HttpStatusCode.NotFound && currentHost == this._secondaryStorageHost)
                {
                    message.SetProperty(ResourceNotReplicatedToSecondaryStorage, true); // set flag to indicate not to try secondary host again as the resource may not have propagated there yet
                }
                message.SetProperty(PreviousHostSetting, currentHost);
                message.Request.UriBuilder.Host = previousHost ?? this._secondaryStorageHost; // previousHost will be null for initial retry only
            }
        }
    }
}
