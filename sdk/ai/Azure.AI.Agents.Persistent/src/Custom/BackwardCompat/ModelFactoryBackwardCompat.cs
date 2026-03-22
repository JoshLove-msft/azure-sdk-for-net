// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
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

        // --- backward-compat: factory methods that existed in the 1.0.0 API surface but are missing from the generated factory ---

        /// <summary> Initializes a new instance of <see cref="Persistent.AISearchIndexResource"/>. </summary>
        public static AISearchIndexResource AISearchIndexResource(string indexConnectionId = null, string indexName = null, AzureAISearchQueryType? queryType = null, int? topK = null, string filter = null, string indexAssetId = null)
            => new AISearchIndexResource(indexConnectionId, indexName, queryType, topK, filter, indexAssetId, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.IncompleteRunDetails"/>. </summary>
        public static IncompleteRunDetails IncompleteRunDetails(IncompleteDetailsReason reason = default)
            => new IncompleteRunDetails(reason, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDelta"/>. </summary>
        public static MessageDelta MessageDelta(MessageRole role = default, IEnumerable<MessageDeltaContent> content = null)
            => new MessageDelta(role, content?.ToList(), additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDeltaContent"/>. </summary>
        public static MessageDeltaContent MessageDeltaContent(int index = 0, string type = null)
            => new UnknownMessageDeltaContent(index, type, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDeltaImageFileContent"/>. </summary>
        public static MessageDeltaImageFileContent MessageDeltaImageFileContent(int index = 0, MessageDeltaImageFileContentObject imageFile = null)
            => new MessageDeltaImageFileContent(index, "image_file", additionalBinaryDataProperties: null, imageFile);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDeltaImageFileContentObject"/>. </summary>
        public static MessageDeltaImageFileContentObject MessageDeltaImageFileContentObject(string fileId = null)
            => new MessageDeltaImageFileContentObject(fileId, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDeltaTextAnnotation"/>. </summary>
        public static MessageDeltaTextAnnotation MessageDeltaTextAnnotation(int index = 0, string type = null)
            => new UnknownMessageDeltaTextAnnotation(index, type, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDeltaTextContent"/>. </summary>
        public static MessageDeltaTextContent MessageDeltaTextContent(int index = 0, MessageDeltaTextContentObject text = null)
            => new MessageDeltaTextContent(index, "text", additionalBinaryDataProperties: null, text);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDeltaTextContentObject"/>. </summary>
        public static MessageDeltaTextContentObject MessageDeltaTextContentObject(string value = null, IEnumerable<MessageDeltaTextAnnotation> annotations = null)
            => new MessageDeltaTextContentObject(value, annotations?.ToList(), additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDeltaTextFileCitationAnnotation"/>. </summary>
        public static MessageDeltaTextFileCitationAnnotation MessageDeltaTextFileCitationAnnotation(int index = 0, MessageDeltaTextFileCitationAnnotationObject fileCitation = null, string text = null, int? startIndex = null, int? endIndex = null)
            => new MessageDeltaTextFileCitationAnnotation(index, "file_citation", additionalBinaryDataProperties: null, fileCitation, text, startIndex, endIndex);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDeltaTextFileCitationAnnotationObject"/>. </summary>
        public static MessageDeltaTextFileCitationAnnotationObject MessageDeltaTextFileCitationAnnotationObject(string fileId = null, string quote = null)
            => new MessageDeltaTextFileCitationAnnotationObject(fileId, quote, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDeltaTextFilePathAnnotation"/>. </summary>
        public static MessageDeltaTextFilePathAnnotation MessageDeltaTextFilePathAnnotation(int index = 0, MessageDeltaTextFilePathAnnotationObject filePath = null, int? startIndex = null, int? endIndex = null, string text = null)
            => new MessageDeltaTextFilePathAnnotation(index, "file_path", additionalBinaryDataProperties: null, filePath, startIndex, endIndex, text);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDeltaTextFilePathAnnotationObject"/>. </summary>
        public static MessageDeltaTextFilePathAnnotationObject MessageDeltaTextFilePathAnnotationObject(string fileId = null)
            => new MessageDeltaTextFilePathAnnotationObject(fileId, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDeltaTextUriCitationAnnotation"/>. </summary>
        public static MessageDeltaTextUriCitationAnnotation MessageDeltaTextUriCitationAnnotation(int index = 0, MessageDeltaTextUriCitationDetails uriCitation = null, int? startIndex = null, int? endIndex = null)
            => new MessageDeltaTextUriCitationAnnotation(index, "url_citation", additionalBinaryDataProperties: null, uriCitation, startIndex, endIndex);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageDeltaTextUriCitationDetails"/>. </summary>
        public static MessageDeltaTextUriCitationDetails MessageDeltaTextUriCitationDetails(string uri = null, string title = null)
            => new MessageDeltaTextUriCitationDetails(uri, title, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageImageFileParam"/>. </summary>
        public static MessageImageFileParam MessageImageFileParam(string fileId = null, ImageDetailLevel? detail = null)
            => new MessageImageFileParam(fileId, detail, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageImageUriParam"/>. </summary>
        public static MessageImageUriParam MessageImageUriParam(string uri = null, ImageDetailLevel? detail = null)
            => new MessageImageUriParam(uri, detail, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageIncompleteDetails"/>. </summary>
        public static MessageIncompleteDetails MessageIncompleteDetails(MessageIncompleteDetailsReason reason = default)
            => new MessageIncompleteDetails(reason, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageInputImageFileBlock"/>. </summary>
        public static MessageInputImageFileBlock MessageInputImageFileBlock(MessageImageFileParam imageFile = null)
            => new MessageInputImageFileBlock(MessageBlockType.ImageFile, additionalBinaryDataProperties: null, imageFile);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageInputImageUriBlock"/>. </summary>
        public static MessageInputImageUriBlock MessageInputImageUriBlock(MessageImageUriParam imageUrl = null)
            => new MessageInputImageUriBlock(MessageBlockType.ImageUrl, additionalBinaryDataProperties: null, imageUrl);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageInputTextBlock"/>. </summary>
        public static MessageInputTextBlock MessageInputTextBlock(string text = null)
            => new MessageInputTextBlock(MessageBlockType.Text, additionalBinaryDataProperties: null, text);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageTextAnnotation"/>. </summary>
        public static MessageTextAnnotation MessageTextAnnotation(string type = null, string text = null)
            => new UnknownMessageTextAnnotation(type, text, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageTextUriCitationAnnotation"/>. </summary>
        public static MessageTextUriCitationAnnotation MessageTextUriCitationAnnotation(string text = null, MessageTextUriCitationDetails uriCitation = null, int? startIndex = null, int? endIndex = null)
            => new MessageTextUriCitationAnnotation("url_citation", text, additionalBinaryDataProperties: null, uriCitation, startIndex, endIndex);

        /// <summary> Initializes a new instance of <see cref="Persistent.MessageTextUriCitationDetails"/>. </summary>
        public static MessageTextUriCitationDetails MessageTextUriCitationDetails(string uri = null, string title = null)
            => new MessageTextUriCitationDetails(uri, title, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RequiredToolCall"/>. </summary>
        public static RequiredToolCall RequiredToolCall(string type = null, string id = null)
            => new UnknownRequiredToolCall(type, additionalBinaryDataProperties: null, id: id);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunCompletionUsage"/>. </summary>
        public static RunCompletionUsage RunCompletionUsage(long completionTokens = 0, long promptTokens = 0, long totalTokens = 0)
            => new RunCompletionUsage(completionTokens, promptTokens, totalTokens, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunError"/>. </summary>
        public static RunError RunError(string code = null, string message = null)
            => new RunError(code, message, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepAzureAISearchToolCall"/>. </summary>
        public static RunStepAzureAISearchToolCall RunStepAzureAISearchToolCall(string id = null, IReadOnlyDictionary<string, string> azureAISearch = null)
            => new RunStepAzureAISearchToolCall("azure_ai_search", id, additionalBinaryDataProperties: null, azureAISearch ?? new Dictionary<string, string>());

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepBingGroundingToolCall"/>. </summary>
        public static RunStepBingGroundingToolCall RunStepBingGroundingToolCall(string id = null, IReadOnlyDictionary<string, string> bingGrounding = null)
            => new RunStepBingGroundingToolCall("bing_grounding", id, additionalBinaryDataProperties: null, bingGrounding ?? new Dictionary<string, string>());

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepCodeInterpreterImageOutput"/>. </summary>
        public static RunStepCodeInterpreterImageOutput RunStepCodeInterpreterImageOutput(RunStepCodeInterpreterImageReference image = null)
            => new RunStepCodeInterpreterImageOutput("image", additionalBinaryDataProperties: null, image);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepCodeInterpreterImageReference"/>. </summary>
        public static RunStepCodeInterpreterImageReference RunStepCodeInterpreterImageReference(string fileId = null)
            => new RunStepCodeInterpreterImageReference(fileId, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepCodeInterpreterLogOutput"/>. </summary>
        public static RunStepCodeInterpreterLogOutput RunStepCodeInterpreterLogOutput(string logs = null)
            => new RunStepCodeInterpreterLogOutput("logs", additionalBinaryDataProperties: null, logs);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepCompletionUsage"/>. </summary>
        public static RunStepCompletionUsage RunStepCompletionUsage(long completionTokens = 0, long promptTokens = 0, long totalTokens = 0)
            => new RunStepCompletionUsage(completionTokens, promptTokens, totalTokens, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDelta"/>. </summary>
        public static RunStepDelta RunStepDelta(RunStepDeltaDetail stepDetails = null)
            => new RunStepDelta(stepDetails, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaCodeInterpreterDetailItemObject"/>. </summary>
        public static RunStepDeltaCodeInterpreterDetailItemObject RunStepDeltaCodeInterpreterDetailItemObject(string input = null, IEnumerable<RunStepDeltaCodeInterpreterOutput> outputs = null)
            => new RunStepDeltaCodeInterpreterDetailItemObject(input, outputs?.ToList(), additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaCodeInterpreterImageOutput"/>. </summary>
        public static RunStepDeltaCodeInterpreterImageOutput RunStepDeltaCodeInterpreterImageOutput(int index = 0, RunStepDeltaCodeInterpreterImageOutputObject image = null)
            => new RunStepDeltaCodeInterpreterImageOutput(index, "image", additionalBinaryDataProperties: null, image);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaCodeInterpreterImageOutputObject"/>. </summary>
        public static RunStepDeltaCodeInterpreterImageOutputObject RunStepDeltaCodeInterpreterImageOutputObject(string fileId = null)
            => new RunStepDeltaCodeInterpreterImageOutputObject(fileId, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaCodeInterpreterLogOutput"/>. </summary>
        public static RunStepDeltaCodeInterpreterLogOutput RunStepDeltaCodeInterpreterLogOutput(int index = 0, string logs = null)
            => new RunStepDeltaCodeInterpreterLogOutput(index, "logs", additionalBinaryDataProperties: null, logs);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaCodeInterpreterOutput"/>. </summary>
        public static RunStepDeltaCodeInterpreterOutput RunStepDeltaCodeInterpreterOutput(int index = 0, string type = null)
            => new UnknownRunStepDeltaCodeInterpreterOutput(index, type, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaCodeInterpreterToolCall"/>. </summary>
        public static RunStepDeltaCodeInterpreterToolCall RunStepDeltaCodeInterpreterToolCall(int index = 0, string id = null, RunStepDeltaCodeInterpreterDetailItemObject codeInterpreter = null)
            => new RunStepDeltaCodeInterpreterToolCall(index, id, "code_interpreter", additionalBinaryDataProperties: null, codeInterpreter);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaFileSearchToolCall"/>. </summary>
        public static RunStepDeltaFileSearchToolCall RunStepDeltaFileSearchToolCall(int index = 0, string id = null, RunStepFileSearchToolCallResults fileSearch = null)
            => new RunStepDeltaFileSearchToolCall(index, id, "file_search", additionalBinaryDataProperties: null, fileSearch);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaFunction"/>. </summary>
        public static RunStepDeltaFunction RunStepDeltaFunction(string name = null, string arguments = null, string output = null)
            => new RunStepDeltaFunction(name, arguments, output, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaFunctionToolCall"/>. </summary>
        public static RunStepDeltaFunctionToolCall RunStepDeltaFunctionToolCall(int index = 0, string id = null, RunStepDeltaFunction function = null)
            => new RunStepDeltaFunctionToolCall(index, id, "function", additionalBinaryDataProperties: null, function);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaMessageCreation"/>. </summary>
        public static RunStepDeltaMessageCreation RunStepDeltaMessageCreation(RunStepDeltaMessageCreationObject messageCreation = null)
            => new RunStepDeltaMessageCreation("message_creation", additionalBinaryDataProperties: null, messageCreation);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaMessageCreationObject"/>. </summary>
        public static RunStepDeltaMessageCreationObject RunStepDeltaMessageCreationObject(string messageId = null)
            => new RunStepDeltaMessageCreationObject(messageId, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaToolCall"/>. </summary>
        public static RunStepDeltaToolCall RunStepDeltaToolCall(int index = 0, string id = null, string type = null)
            => new UnknownRunStepDeltaToolCall(index, id, type, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepDeltaToolCallObject"/>. </summary>
        public static RunStepDeltaToolCallObject RunStepDeltaToolCallObject(IEnumerable<RunStepDeltaToolCall> toolCalls = null)
            => new RunStepDeltaToolCallObject("tool_calls", additionalBinaryDataProperties: null, toolCalls?.ToList());

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepError"/>. </summary>
        public static RunStepError RunStepError(RunStepErrorCode code = default, string message = null)
            => new RunStepError(code, message, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepFileSearchToolCall"/>. </summary>
        public static RunStepFileSearchToolCall RunStepFileSearchToolCall(string id = null, RunStepFileSearchToolCallResults fileSearch = null)
            => new RunStepFileSearchToolCall("file_search", null, id, fileSearch);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepFileSearchToolCallResult"/>. </summary>
        public static RunStepFileSearchToolCallResult RunStepFileSearchToolCallResult(string fileId = null, string fileName = null, float score = 0f, IEnumerable<FileSearchToolCallContent> content = null)
            => new RunStepFileSearchToolCallResult(fileId, fileName, score, content?.ToList(), additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepFileSearchToolCallResults"/>. </summary>
        public static RunStepFileSearchToolCallResults RunStepFileSearchToolCallResults(FileSearchRankingOptions rankingOptions = null, IEnumerable<RunStepFileSearchToolCallResult> results = null)
            => new RunStepFileSearchToolCallResults(rankingOptions, results?.ToList(), additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepMessageCreationDetails"/>. </summary>
        public static RunStepMessageCreationDetails RunStepMessageCreationDetails(RunStepMessageCreationReference messageCreation = null)
            => new RunStepMessageCreationDetails(RunStepType.MessageCreation, additionalBinaryDataProperties: null, messageCreation);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepMessageCreationReference"/>. </summary>
        public static RunStepMessageCreationReference RunStepMessageCreationReference(string messageId = null)
            => new RunStepMessageCreationReference(messageId, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepOpenAPIToolCall"/>. </summary>
        public static RunStepOpenAPIToolCall RunStepOpenAPIToolCall(string id = null, IReadOnlyDictionary<string, string> openAPI = null)
            => new RunStepOpenAPIToolCall("openapi", id, additionalBinaryDataProperties: null, openAPI ?? new Dictionary<string, string>());

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepToolCall"/>. </summary>
        public static RunStepToolCall RunStepToolCall(string type = null, string id = null)
            => new UnknownRunStepToolCall(type, id, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.RunStepToolCallDetails"/>. </summary>
        public static RunStepToolCallDetails RunStepToolCallDetails(IEnumerable<RunStepToolCall> toolCalls = null)
            => new RunStepToolCallDetails(RunStepType.ToolCalls, additionalBinaryDataProperties: null, toolCalls?.ToList());

        /// <summary> Initializes a new instance of <see cref="Persistent.ThreadMessageOptions"/>. </summary>
        public static ThreadMessageOptions ThreadMessageOptions(MessageRole role = default, BinaryData content = null, IEnumerable<MessageAttachment> attachments = null, IDictionary<string, string> metadata = null)
            => new ThreadMessageOptions(role, content, attachments?.ToList(), metadata, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.VectorStoreFileCount"/>. </summary>
        public static VectorStoreFileCount VectorStoreFileCount(int inProgress = 0, int completed = 0, int failed = 0, int cancelled = 0, int total = 0)
            => new VectorStoreFileCount(inProgress, completed, failed, cancelled, total, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.VectorStoreFileError"/>. </summary>
        public static VectorStoreFileError VectorStoreFileError(VectorStoreFileErrorCode code = default, string message = null)
            => new VectorStoreFileError(code, message, additionalBinaryDataProperties: null);

        /// <summary> Initializes a new instance of <see cref="Persistent.VectorStoreStaticChunkingStrategyRequest"/>. </summary>
        public static VectorStoreStaticChunkingStrategyRequest VectorStoreStaticChunkingStrategyRequest(VectorStoreStaticChunkingStrategyOptions @static = null)
            => new VectorStoreStaticChunkingStrategyRequest(VectorStoreChunkingStrategyRequestType.Static, additionalBinaryDataProperties: null, @static);

        /// <summary> Initializes a new instance of <see cref="Persistent.VectorStoreStaticChunkingStrategyResponse"/>. </summary>
        public static VectorStoreStaticChunkingStrategyResponse VectorStoreStaticChunkingStrategyResponse(VectorStoreStaticChunkingStrategyOptions @static = null)
            => new VectorStoreStaticChunkingStrategyResponse(VectorStoreChunkingStrategyResponseType.Static, additionalBinaryDataProperties: null, @static);
    }
}
