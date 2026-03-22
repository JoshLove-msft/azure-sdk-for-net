// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
// backward-compat: overloads with IReadOnlyDictionary metadata instead of IDictionary.
namespace Azure.AI.Agents.Persistent
{
#pragma warning disable AZC0002
    public partial class PersistentAgentsAdministrationClient
    {
        public virtual Response<PersistentAgent> CreateAgent(string model, string name, string description, string instructions, IEnumerable<ToolDefinition> tools, ToolResources toolResources, float? temperature, float? topP, BinaryData responseFormat, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return CreateAgent(model, name, description, instructions, tools, toolResources, temperature, topP, responseFormat, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken); }
        public virtual async Task<Response<PersistentAgent>> CreateAgentAsync(string model, string name, string description, string instructions, IEnumerable<ToolDefinition> tools, ToolResources toolResources, float? temperature, float? topP, BinaryData responseFormat, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return await CreateAgentAsync(model, name, description, instructions, tools, toolResources, temperature, topP, responseFormat, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken).ConfigureAwait(false); }
        public virtual Response<PersistentAgent> UpdateAgent(string assistantId, string model, string name, string description, string instructions, IEnumerable<ToolDefinition> tools, ToolResources toolResources, float? temperature, float? topP, BinaryData responseFormat, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return UpdateAgent(assistantId, model, name, description, instructions, tools, toolResources, temperature, topP, responseFormat, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken); }
        public virtual async Task<Response<PersistentAgent>> UpdateAgentAsync(string assistantId, string model, string name, string description, string instructions, IEnumerable<ToolDefinition> tools, ToolResources toolResources, float? temperature, float? topP, BinaryData responseFormat, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return await UpdateAgentAsync(assistantId, model, name, description, instructions, tools, toolResources, temperature, topP, responseFormat, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken).ConfigureAwait(false); }
    }
    public partial class VectorStores
    {
        public virtual Response<PersistentAgentsVectorStore> CreateVectorStore(IEnumerable<string> fileIds, string name, VectorStoreConfiguration storeConfiguration, VectorStoreExpirationPolicy expiresAfter, VectorStoreChunkingStrategy chunkingStrategy, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return CreateVectorStore(fileIds, name, storeConfiguration, expiresAfter, chunkingStrategy, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken); }
        public virtual async Task<Response<PersistentAgentsVectorStore>> CreateVectorStoreAsync(IEnumerable<string> fileIds, string name, VectorStoreConfiguration storeConfiguration, VectorStoreExpirationPolicy expiresAfter, VectorStoreChunkingStrategy chunkingStrategy, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return await CreateVectorStoreAsync(fileIds, name, storeConfiguration, expiresAfter, chunkingStrategy, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken).ConfigureAwait(false); }
        public virtual Response<PersistentAgentsVectorStore> ModifyVectorStore(string vectorStoreId, string name, VectorStoreExpirationPolicy expiresAfter, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return ModifyVectorStore(vectorStoreId, name, expiresAfter, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken); }
        public virtual async Task<Response<PersistentAgentsVectorStore>> ModifyVectorStoreAsync(string vectorStoreId, string name, VectorStoreExpirationPolicy expiresAfter, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return await ModifyVectorStoreAsync(vectorStoreId, name, expiresAfter, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken).ConfigureAwait(false); }
    }
    public partial class Threads
    {
        public virtual Response<PersistentAgentThread> CreateThread(IEnumerable<ThreadMessageOptions> messages, ToolResources toolResources, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return CreateThread(messages, toolResources, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken); }
        public virtual async Task<Response<PersistentAgentThread>> CreateThreadAsync(IEnumerable<ThreadMessageOptions> messages, ToolResources toolResources, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return await CreateThreadAsync(messages, toolResources, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken).ConfigureAwait(false); }
        public virtual Response<PersistentAgentThread> UpdateThread(string threadId, ToolResources toolResources, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return UpdateThread(threadId, toolResources, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken); }
        public virtual async Task<Response<PersistentAgentThread>> UpdateThreadAsync(string threadId, ToolResources toolResources, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return await UpdateThreadAsync(threadId, toolResources, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken).ConfigureAwait(false); }
    }
    public partial class ThreadMessages
    {
        public virtual Response<PersistentThreadMessage> CreateMessage(string threadId, MessageRole role, BinaryData content, IEnumerable<MessageAttachment> attachments, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return CreateMessage(threadId, role, content, attachments, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken); }
        public virtual async Task<Response<PersistentThreadMessage>> CreateMessageAsync(string threadId, MessageRole role, BinaryData content, IEnumerable<MessageAttachment> attachments, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return await CreateMessageAsync(threadId, role, content, attachments, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken).ConfigureAwait(false); }
        public virtual Response<PersistentThreadMessage> UpdateMessage(string threadId, string messageId, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return UpdateMessage(threadId, messageId, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken); }
        public virtual async Task<Response<PersistentThreadMessage>> UpdateMessageAsync(string threadId, string messageId, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return await UpdateMessageAsync(threadId, messageId, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken).ConfigureAwait(false); }
    }
    public partial class ThreadRuns
    {
        public virtual Response<ThreadRun> UpdateRun(string threadId, string runId, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return UpdateRun(threadId, runId, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken); }
        public virtual async Task<Response<ThreadRun>> UpdateRunAsync(string threadId, string runId, IReadOnlyDictionary<string, string> metadata, CancellationToken cancellationToken)
        { return await UpdateRunAsync(threadId, runId, (IDictionary<string, string>)(metadata?.ToDictionary(k => k.Key, k => k.Value)), cancellationToken).ConfigureAwait(false); }
    }
#pragma warning restore AZC0002
}
