// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.TypeSpec.Generator.ClientModel;

namespace Azure.Generator.Tests
{
    /// <summary>
    /// A test visitor that can be detected in assertions.
    /// Used by <see cref="PluginLoadingTests"/> to verify plugin loading from assemblies.
    /// </summary>
    internal class TestPluginVisitor : ScmLibraryVisitor
    {
    }
}
