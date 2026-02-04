// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.AI.Language.Conversations
{
    /// <summary>
    /// The <see cref="ConversationAnalysisClient"/> allows for the analysis of conversations.
    /// </summary>
    [CodeGenType("ConversationAnalysis")]
    public partial class ConversationAnalysisClient
    {
        /// <summary>
        /// Gets the service endpoint for this client.
        /// </summary>
        public virtual Uri Endpoint => _endpoint;

        /// <summary>
        /// [Protocol Method] Submits an analysis long running operation for conversations and return the response once processed.
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation{T}"/> representing an asynchronous operation on the service. </returns>
        public virtual Operation<BinaryData> AnalyzeConversations(WaitUntil waitUntil, RequestContent content, RequestContext context = default)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.AnalyzeConversations");
            scope.Start();

            try
            {
                Argument.AssertNotNull(content, nameof(content));

                using HttpMessage message = CreateAnalyzeConversationSubmitOperationRequest(content, context);
                return ProtocolOperationHelpers.ProcessMessage(Pipeline, message, ClientDiagnostics, "ConversationAnalysisClient.AnalyzeConversations", OperationFinalStateVia.OperationLocation, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Submits an analysis long running operation for conversations and return the response once processed.
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation{T}"/> representing an asynchronous operation on the service. </returns>
        public virtual async Task<Operation<BinaryData>> AnalyzeConversationsAsync(WaitUntil waitUntil, RequestContent content, RequestContext context = default)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.AnalyzeConversations");
            scope.Start();

            try
            {
                Argument.AssertNotNull(content, nameof(content));

                using HttpMessage message = CreateAnalyzeConversationSubmitOperationRequest(content, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(Pipeline, message, ClientDiagnostics, "ConversationAnalysisClient.AnalyzeConversations", OperationFinalStateVia.OperationLocation, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
