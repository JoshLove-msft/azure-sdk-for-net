// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.Agents.Persistent
{
    // Protected constructors required for backward compat with 1.0.0 baseline
    // and for deserialization of derived types.

    public partial class MessageContent
    {
        protected MessageContent() : this(null) { }
    }

    public partial class MessageDeltaContent
    {
        protected MessageDeltaContent(int index) : this(index, null) { }
    }

    public partial class MessageDeltaTextAnnotation
    {
        protected MessageDeltaTextAnnotation(int index) : this(index, null) { }
    }

    public partial class MessageInputContentBlock
    {
        protected MessageInputContentBlock() : this(null) { }
    }

    public partial class MessageTextAnnotation
    {
        protected MessageTextAnnotation(string text) : this(null, text) { }
    }

    public partial class OpenApiAuthDetails
    {
        protected OpenApiAuthDetails() : this(null) { }
    }

    public partial class RequiredAction
    {
        protected RequiredAction() : this(null) { }
    }

    public partial class RunStepCodeInterpreterToolCallOutput
    {
        protected RunStepCodeInterpreterToolCallOutput() : this(null) { }
    }

    public partial class RunStepDeltaCodeInterpreterOutput
    {
        protected RunStepDeltaCodeInterpreterOutput(int index) : this(index, null) { }
    }

    public partial class RunStepDeltaDetail
    {
        protected RunStepDeltaDetail() : this(null) { }
    }

    public partial class RunStepDeltaToolCall
    {
        protected RunStepDeltaToolCall(int index, string id) : this(index, null, id) { }
    }

    public partial class RunStepDetails
    {
        protected RunStepDetails() : this(null) { }
    }

    public partial class RunStepToolCall
    {
        protected RunStepToolCall(string id) : this(null, id) { }
    }

    public partial class ToolDefinition
    {
        protected ToolDefinition() : this(null) { }
    }

    public partial class VectorStoreChunkingStrategy
    {
        protected VectorStoreChunkingStrategy() : this(null) { }
    }

    public partial class VectorStoreChunkingStrategyResponse
    {
        protected VectorStoreChunkingStrategyResponse() : this(null) { }
    }
}
