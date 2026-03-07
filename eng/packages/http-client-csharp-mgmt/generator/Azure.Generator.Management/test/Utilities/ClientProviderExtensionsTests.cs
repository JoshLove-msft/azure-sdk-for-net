// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Generator.Management;
using Azure.Generator.Management.Tests.Common;
using Azure.Generator.Management.Tests.TestHelpers;
using Azure.Generator.Management.Utilities;
using Microsoft.TypeSpec.Generator.ClientModel.Providers;
using Microsoft.TypeSpec.Generator.Input;
using NUnit.Framework;

namespace Azure.Generator.Mgmt.Tests.Utilities
{
    internal class ClientProviderExtensionsTests
    {
        [Test]
        public void GetConvenienceMethodByOperation_Sync_ReturnsSyncMethod()
        {
            var (client, restClient) = SetupClientProvider();
            var operation = client.Methods[0].Operation;

            var method = restClient.GetConvenienceMethodByOperation(operation, false);

            Assert.IsNotNull(method);
            Assert.IsFalse(method.Signature.Name.EndsWith("Async"));
        }

        [Test]
        public void GetConvenienceMethodByOperation_Async_ReturnsAsyncMethod()
        {
            var (client, restClient) = SetupClientProvider();
            var operation = client.Methods[0].Operation;

            var method = restClient.GetConvenienceMethodByOperation(operation, true);

            Assert.IsNotNull(method);
            Assert.IsTrue(method.Signature.Name.EndsWith("Async"));
        }

        [Test]
        public void GetConvenienceMethodByOperation_SyncAndAsync_ReturnDifferentMethods()
        {
            var (client, restClient) = SetupClientProvider();
            var operation = client.Methods[0].Operation;

            var syncMethod = restClient.GetConvenienceMethodByOperation(operation, false);
            var asyncMethod = restClient.GetConvenienceMethodByOperation(operation, true);

            Assert.IsNotNull(syncMethod);
            Assert.IsNotNull(asyncMethod);
            Assert.AreNotEqual(syncMethod.Signature.Name, asyncMethod.Signature.Name);
        }

        private static (InputClient Client, ClientProvider RestClient) SetupClientProvider()
        {
            var (client, models) = InputResourceData.ClientWithResource();
            ManagementMockHelpers.LoadMockPlugin(inputModels: () => models, clients: () => [client]);
            var restClient = ManagementClientGenerator.Instance.TypeFactory.CreateClient(client);
            Assert.IsNotNull(restClient);
            return (client, restClient!);
        }
    }
}
