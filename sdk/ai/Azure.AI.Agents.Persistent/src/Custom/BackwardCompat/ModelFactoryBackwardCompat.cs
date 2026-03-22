// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
#nullable disable
using System;
using System.Collections.Generic;
// backward-compat: overloads with old enum-typed parameters that no longer exist in the generated factory.
// The extra enum param is accepted for binary compat but ignored (it was always a constant).
namespace Azure.AI.Agents.Persistent
{
    public static partial class PersistentAgentsModelFactory
    {
        /// <summary> backward-compat: old signature included AzureFunctionBindingType. </summary>
        public static AzureFunctionBinding AzureFunctionBinding(AzureFunctionBindingType type, AzureFunctionStorageQueue storageQueue)
            => AzureFunctionBinding(storageQueue);
        /// <summary> backward-compat: old signature included FileSearchToolCallContentType. </summary>
        public static FileSearchToolCallContent FileSearchToolCallContent(FileSearchToolCallContentType type, string text)
            => FileSearchToolCallContent(text);
        /// <summary> backward-compat: old signature included MessageDeltaChunkObject. </summary>
        public static MessageDeltaChunk MessageDeltaChunk(string id, MessageDeltaChunkObject @object, MessageDelta delta)
            => MessageDeltaChunk(id, delta);
        /// <summary> backward-compat: old signature included ResponseFormatJsonSchemaTypeType. </summary>
        public static ResponseFormatJsonSchemaType ResponseFormatJsonSchemaType(ResponseFormatJsonSchemaTypeType type, ResponseFormatJsonSchema jsonSchema)
            => ResponseFormatJsonSchemaType(jsonSchema);
        /// <summary> backward-compat: old signature included RunStepDeltaChunkObject. </summary>
        public static RunStepDeltaChunk RunStepDeltaChunk(string id, RunStepDeltaChunkObject @object, RunStepDelta delta)
            => RunStepDeltaChunk(id, delta);
        /// <summary> backward-compat: old signature included PersistentAgentsVectorStoreObject. </summary>
        public static PersistentAgentsVectorStore PersistentAgentsVectorStore(string id, PersistentAgentsVectorStoreObject @object, DateTimeOffset createdAt, string name, int usageBytes, VectorStoreFileCount fileCounts, VectorStoreStatus status, VectorStoreExpirationPolicy expiresAfter, DateTimeOffset? expiresAt, DateTimeOffset? lastActiveAt, IReadOnlyDictionary<string, string> metadata)
            => PersistentAgentsVectorStore(id, createdAt, name, usageBytes, fileCounts, status, expiresAfter, expiresAt, lastActiveAt, metadata);
        /// <summary> backward-compat: old signature included VectorStoreFileObject. </summary>
        public static VectorStoreFile VectorStoreFile(string id, VectorStoreFileObject @object, int usageBytes, DateTimeOffset createdAt, string vectorStoreId, VectorStoreFileStatus status, VectorStoreFileError lastError, VectorStoreChunkingStrategyResponse chunkingStrategy)
            => VectorStoreFile(id, usageBytes, createdAt, vectorStoreId, status, lastError, chunkingStrategy);
        /// <summary> backward-compat: old signature included VectorStoreFileBatchObject. </summary>
        public static VectorStoreFileBatch VectorStoreFileBatch(string id, VectorStoreFileBatchObject @object, DateTimeOffset createdAt, string vectorStoreId, VectorStoreFileBatchStatus status, VectorStoreFileCount fileCounts)
            => VectorStoreFileBatch(id, createdAt, vectorStoreId, status, fileCounts);
    }
}
