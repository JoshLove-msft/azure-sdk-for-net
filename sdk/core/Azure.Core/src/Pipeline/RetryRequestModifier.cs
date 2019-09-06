using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.Http;

namespace Azure.Core.Pipeline
{
    public class RetryRequestModifier
    {
        public virtual void onBeforeRetryPolicy(HttpPipelineMessage message)
        {

        }
    }
}
