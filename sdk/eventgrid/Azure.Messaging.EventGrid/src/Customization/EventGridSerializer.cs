// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using Azure.Core;

namespace Azure.Messaging.EventGrid
{
    internal class EventGridSerializer : IUtf8JsonSerializable
    {
        public BinaryData _data;
        public CancellationToken _cancellationToken;
        public ObjectSerializer _serializer;

        public EventGridSerializer(BinaryData data, ObjectSerializer serializer, CancellationToken cancellationToken)
        {
            _data = data;
            _serializer = serializer;
            _cancellationToken = cancellationToken;
        }
        public void Write(Utf8JsonWriter writer)
        {
            Stream stream;
            if (_data.Format != BinaryDataFormat.JsonObjectSerializer)
            {
                stream = new MemoryStream();
                _serializer.Serialize(stream, _data, _data.GetType(), _cancellationToken);
                stream.Seek(0, SeekOrigin.Begin);
            }
            else
            {
                stream = _data.ToStream();
            }
            JsonDocument.Parse(stream).WriteTo(writer);
        }
    }
}
