﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

extern alias BaseBlobs;

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Storage.Stress;
using BaseBlobs::Azure.Storage.Blobs.Models;

namespace Azure.Storage.DataMovement.Blobs.Stress
{
    public class UploadBlockBlobDirectoryScenario : UploadBlobDirectoryScenarioBase
    {
        public UploadBlockBlobDirectoryScenario(
            Uri destinationBlobUri,
            int? blobSize,
            int? blobCount,
            TransferManagerOptions transferManagerOptions,
            TransferOptions transferOptions,
            TokenCredential tokenCredential,
            Metrics metrics,
            string testRunId)
            : base(destinationBlobUri, blobSize, blobCount, transferManagerOptions, transferOptions, tokenCredential, metrics, testRunId)
        {
        }

        public override string Name => DataMovementBlobStressConstants.TestScenarioNameStr.UploadDirectoryBlockBlob;

        public override Task RunTestAsync(CancellationToken cancellationToken)
            => RunTestInternalAsync(BlobType.Block, cancellationToken);
    }
}
