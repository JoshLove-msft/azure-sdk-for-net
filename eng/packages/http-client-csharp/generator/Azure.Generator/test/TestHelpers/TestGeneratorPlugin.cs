// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.TypeSpec.Generator;

namespace Azure.Generator.Tests
{
    /// <summary>
    /// A test plugin that registers <see cref="TestPluginVisitor"/>.
    /// Used by <see cref="PluginLoadingTests"/> to verify plugin loading from assemblies.
    /// </summary>
    public class TestGeneratorPlugin : GeneratorPlugin
    {
        /// <inheritdoc/>
        public override void Apply(CodeModelGenerator generator)
        {
            generator.AddVisitor(new TestPluginVisitor());
        }
    }
}
