// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using Microsoft.TypeSpec.Generator.Customizations;

// backward-compat: return enum types instead of string for constant discriminator properties.
namespace Azure.AI.Agents.Persistent
{
    [CodeGenSuppress("Type")]
    public partial class AzureFunctionBinding
    {
        /// <summary> The type of binding, which is always 'storage_queue'. </summary>
        public AzureFunctionBindingType Type { get; } = new AzureFunctionBindingType("storage_queue");
    }

    [CodeGenSuppress("Type")]
    public partial class FileSearchToolCallContent
    {
        /// <summary> The type of the content. </summary>
        public FileSearchToolCallContentType Type { get; } = new FileSearchToolCallContentType("text");
    }

    [CodeGenSuppress("Object")]
    public partial class MessageDeltaChunk
    {
        /// <summary> The object type, which is always `thread.message.delta`. </summary>
        public MessageDeltaChunkObject Object { get; } = new MessageDeltaChunkObject("thread.message.delta");
    }

    [CodeGenSuppress("Object")]
    public partial class PersistentAgentsVectorStore
    {
        /// <summary> The object type, which is always `vector_store`. </summary>
        public PersistentAgentsVectorStoreObject Object { get; } = new PersistentAgentsVectorStoreObject("vector_store");
    }

    [CodeGenSuppress("Type")]
    public partial class ResponseFormatJsonSchemaType
    {
        /// <summary> Type. </summary>
        public ResponseFormatJsonSchemaTypeType Type { get; } = new ResponseFormatJsonSchemaTypeType("json_schema");
    }

    [CodeGenSuppress("Object")]
    public partial class RunStepDeltaChunk
    {
        /// <summary> The object type, which is always `thread.run.step.delta`. </summary>
        public RunStepDeltaChunkObject Object { get; } = new RunStepDeltaChunkObject("thread.run.step.delta");
    }

    [CodeGenSuppress("Object")]
    public partial class VectorStoreFileBatch
    {
        /// <summary> The object type, which is always `vector_store.file_batch`. </summary>
        public VectorStoreFileBatchObject Object { get; } = new VectorStoreFileBatchObject("vector_store.files_batch");
    }

    [CodeGenSuppress("Object")]
    public partial class VectorStoreFile
    {
        /// <summary> The object type, which is always `vector_store.file`. </summary>
        public VectorStoreFileObject Object { get; } = new VectorStoreFileObject("vector_store.file");
    }
}
