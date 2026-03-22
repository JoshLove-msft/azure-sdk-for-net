// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.ComponentModel;
// backward-compat: extensible enum types that existed in the old API surface.
namespace Azure.AI.Agents.Persistent
{
    public readonly partial struct AzureFunctionBindingType : IEquatable<AzureFunctionBindingType>
    {
        private readonly string _value;
        public AzureFunctionBindingType(string value) => _value = value ?? throw new ArgumentNullException(nameof(value));
        public static AzureFunctionBindingType StorageQueue { get; } = new AzureFunctionBindingType("storage_queue");
        public static bool operator ==(AzureFunctionBindingType left, AzureFunctionBindingType right) => left.Equals(right);
        public static bool operator !=(AzureFunctionBindingType left, AzureFunctionBindingType right) => !left.Equals(right);
        public static implicit operator AzureFunctionBindingType(string value) => new AzureFunctionBindingType(value);
        [EditorBrowsable(EditorBrowsableState.Never)] public override bool Equals(object obj) => obj is AzureFunctionBindingType o && Equals(o);
        public bool Equals(AzureFunctionBindingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);
        [EditorBrowsable(EditorBrowsableState.Never)] public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
    public readonly partial struct FileSearchToolCallContentType : IEquatable<FileSearchToolCallContentType>
    {
        private readonly string _value;
        public FileSearchToolCallContentType(string value) => _value = value ?? throw new ArgumentNullException(nameof(value));
        public static FileSearchToolCallContentType Text { get; } = new FileSearchToolCallContentType("text");
        public static bool operator ==(FileSearchToolCallContentType left, FileSearchToolCallContentType right) => left.Equals(right);
        public static bool operator !=(FileSearchToolCallContentType left, FileSearchToolCallContentType right) => !left.Equals(right);
        public static implicit operator FileSearchToolCallContentType(string value) => new FileSearchToolCallContentType(value);
        [EditorBrowsable(EditorBrowsableState.Never)] public override bool Equals(object obj) => obj is FileSearchToolCallContentType o && Equals(o);
        public bool Equals(FileSearchToolCallContentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);
        [EditorBrowsable(EditorBrowsableState.Never)] public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
    public readonly partial struct MessageDeltaChunkObject : IEquatable<MessageDeltaChunkObject>
    {
        private readonly string _value;
        public MessageDeltaChunkObject(string value) => _value = value ?? throw new ArgumentNullException(nameof(value));
        public static MessageDeltaChunkObject ThreadMessageDelta { get; } = new MessageDeltaChunkObject("thread.message.delta");
        public static bool operator ==(MessageDeltaChunkObject left, MessageDeltaChunkObject right) => left.Equals(right);
        public static bool operator !=(MessageDeltaChunkObject left, MessageDeltaChunkObject right) => !left.Equals(right);
        public static implicit operator MessageDeltaChunkObject(string value) => new MessageDeltaChunkObject(value);
        [EditorBrowsable(EditorBrowsableState.Never)] public override bool Equals(object obj) => obj is MessageDeltaChunkObject o && Equals(o);
        public bool Equals(MessageDeltaChunkObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);
        [EditorBrowsable(EditorBrowsableState.Never)] public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
    public readonly partial struct PersistentAgentsVectorStoreObject : IEquatable<PersistentAgentsVectorStoreObject>
    {
        private readonly string _value;
        public PersistentAgentsVectorStoreObject(string value) => _value = value ?? throw new ArgumentNullException(nameof(value));
        public static PersistentAgentsVectorStoreObject VectorStore { get; } = new PersistentAgentsVectorStoreObject("vector_store");
        public static bool operator ==(PersistentAgentsVectorStoreObject left, PersistentAgentsVectorStoreObject right) => left.Equals(right);
        public static bool operator !=(PersistentAgentsVectorStoreObject left, PersistentAgentsVectorStoreObject right) => !left.Equals(right);
        public static implicit operator PersistentAgentsVectorStoreObject(string value) => new PersistentAgentsVectorStoreObject(value);
        [EditorBrowsable(EditorBrowsableState.Never)] public override bool Equals(object obj) => obj is PersistentAgentsVectorStoreObject o && Equals(o);
        public bool Equals(PersistentAgentsVectorStoreObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);
        [EditorBrowsable(EditorBrowsableState.Never)] public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
    public readonly partial struct ResponseFormatJsonSchemaTypeType : IEquatable<ResponseFormatJsonSchemaTypeType>
    {
        private readonly string _value;
        public ResponseFormatJsonSchemaTypeType(string value) => _value = value ?? throw new ArgumentNullException(nameof(value));
        public static ResponseFormatJsonSchemaTypeType JsonSchema { get; } = new ResponseFormatJsonSchemaTypeType("json_schema");
        public static bool operator ==(ResponseFormatJsonSchemaTypeType left, ResponseFormatJsonSchemaTypeType right) => left.Equals(right);
        public static bool operator !=(ResponseFormatJsonSchemaTypeType left, ResponseFormatJsonSchemaTypeType right) => !left.Equals(right);
        public static implicit operator ResponseFormatJsonSchemaTypeType(string value) => new ResponseFormatJsonSchemaTypeType(value);
        [EditorBrowsable(EditorBrowsableState.Never)] public override bool Equals(object obj) => obj is ResponseFormatJsonSchemaTypeType o && Equals(o);
        public bool Equals(ResponseFormatJsonSchemaTypeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);
        [EditorBrowsable(EditorBrowsableState.Never)] public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
    public readonly partial struct RunStepDeltaChunkObject : IEquatable<RunStepDeltaChunkObject>
    {
        private readonly string _value;
        public RunStepDeltaChunkObject(string value) => _value = value ?? throw new ArgumentNullException(nameof(value));
        public static RunStepDeltaChunkObject ThreadRunStepDelta { get; } = new RunStepDeltaChunkObject("thread.run.step.delta");
        public static bool operator ==(RunStepDeltaChunkObject left, RunStepDeltaChunkObject right) => left.Equals(right);
        public static bool operator !=(RunStepDeltaChunkObject left, RunStepDeltaChunkObject right) => !left.Equals(right);
        public static implicit operator RunStepDeltaChunkObject(string value) => new RunStepDeltaChunkObject(value);
        [EditorBrowsable(EditorBrowsableState.Never)] public override bool Equals(object obj) => obj is RunStepDeltaChunkObject o && Equals(o);
        public bool Equals(RunStepDeltaChunkObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);
        [EditorBrowsable(EditorBrowsableState.Never)] public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
    public readonly partial struct VectorStoreFileBatchObject : IEquatable<VectorStoreFileBatchObject>
    {
        private readonly string _value;
        public VectorStoreFileBatchObject(string value) => _value = value ?? throw new ArgumentNullException(nameof(value));
        public static VectorStoreFileBatchObject VectorStoreFilesBatch { get; } = new VectorStoreFileBatchObject("vector_store.files_batch");
        public static bool operator ==(VectorStoreFileBatchObject left, VectorStoreFileBatchObject right) => left.Equals(right);
        public static bool operator !=(VectorStoreFileBatchObject left, VectorStoreFileBatchObject right) => !left.Equals(right);
        public static implicit operator VectorStoreFileBatchObject(string value) => new VectorStoreFileBatchObject(value);
        [EditorBrowsable(EditorBrowsableState.Never)] public override bool Equals(object obj) => obj is VectorStoreFileBatchObject o && Equals(o);
        public bool Equals(VectorStoreFileBatchObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);
        [EditorBrowsable(EditorBrowsableState.Never)] public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
    public readonly partial struct VectorStoreFileObject : IEquatable<VectorStoreFileObject>
    {
        private readonly string _value;
        public VectorStoreFileObject(string value) => _value = value ?? throw new ArgumentNullException(nameof(value));
        public static VectorStoreFileObject VectorStoreFile { get; } = new VectorStoreFileObject("vector_store.file");
        public static bool operator ==(VectorStoreFileObject left, VectorStoreFileObject right) => left.Equals(right);
        public static bool operator !=(VectorStoreFileObject left, VectorStoreFileObject right) => !left.Equals(right);
        public static implicit operator VectorStoreFileObject(string value) => new VectorStoreFileObject(value);
        [EditorBrowsable(EditorBrowsableState.Never)] public override bool Equals(object obj) => obj is VectorStoreFileObject o && Equals(o);
        public bool Equals(VectorStoreFileObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);
        [EditorBrowsable(EditorBrowsableState.Never)] public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
