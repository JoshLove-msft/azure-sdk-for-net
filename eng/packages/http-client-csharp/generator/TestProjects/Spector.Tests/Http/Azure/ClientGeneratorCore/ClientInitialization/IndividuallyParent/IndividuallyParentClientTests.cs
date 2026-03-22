// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestProjects.Spector.Tests.Http.Azure.ClientGeneratorCore.ClientInitialization.IndividuallyParent
{
    public class IndividuallyParentClientTests : SpectorTestBase
    {
        [SpectorTest]
        public Task Azure_ClientGenerator_Core_ClientInitialization_IndividuallyParentClient_IndividuallyParentNestedWithPathClient() => Test(async (host) =>
        {
            await Task.CompletedTask;
        });

        [SpectorTest]
        public Task Azure_ClientGenerator_Core_ClientInitialization_IndividuallyParentClient_IndividuallyParentNestedWithQueryClient() => Test(async (host) =>
        {
            await Task.CompletedTask;
        });

        [SpectorTest]
        public Task Azure_ClientGenerator_Core_ClientInitialization_IndividuallyParentClient_IndividuallyParentNestedWithHeaderClient() => Test(async (host) =>
        {
            await Task.CompletedTask;
        });

        [SpectorTest]
        public Task Azure_ClientGenerator_Core_ClientInitialization_IndividuallyParentClient_IndividuallyParentNestedWithMultipleClient() => Test(async (host) =>
        {
            await Task.CompletedTask;
        });

        [SpectorTest]
        public Task Azure_ClientGenerator_Core_ClientInitialization_IndividuallyParentClient_IndividuallyParentNestedWithMixedClient() => Test(async (host) =>
        {
            await Task.CompletedTask;
        });

        [SpectorTest]
        public Task Azure_ClientGenerator_Core_ClientInitialization_IndividuallyParentClient_IndividuallyParentNestedWithParamAliasClient() => Test(async (host) =>
        {
            await Task.CompletedTask;
        });
    }
}
