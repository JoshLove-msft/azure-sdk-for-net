// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Diagnostics.CodeAnalysis;
using Azure.AI.Agents.Persistent;
using Azure.Core.Extensions;
// backward-compat: forwarding class for renamed builder extensions.
namespace Microsoft.Extensions.Azure
{
    public static partial class AIAgentsPersistentClientBuilderExtensions
    {
        public static IAzureClientBuilder<PersistentAgentsAdministrationClient, PersistentAgentsAdministrationClientOptions> AddPersistentAgentsAdministrationClient<TBuilder>(this TBuilder builder, Uri endpoint) where TBuilder : IAzureClientFactoryBuilderWithCredential
            => AgentsPersistentClientBuilderExtensions.AddPersistentAgentsAdministrationClient(builder, endpoint);
        [RequiresUnreferencedCode("Requires unreferenced code until we opt into EnableConfigurationBindingGenerator.")]
        [RequiresDynamicCode("Requires unreferenced code until we opt into EnableConfigurationBindingGenerator.")]
        public static IAzureClientBuilder<PersistentAgentsAdministrationClient, PersistentAgentsAdministrationClientOptions> AddPersistentAgentsAdministrationClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
            => AgentsPersistentClientBuilderExtensions.AddPersistentAgentsAdministrationClient<TBuilder, TConfiguration>(builder, configuration);
    }
}
