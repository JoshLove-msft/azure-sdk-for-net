// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Generator.Tests.TestHelpers;
using Microsoft.TypeSpec.Generator.ClientModel;
using NUnit.Framework;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Azure.Generator.Tests
{
    public class PluginLoadingTests
    {
        [Test]
        public void NoPluginOption_DoesNotThrow()
        {
            // When no plugin option is specified, Configure() should work normally
            var generator = MockHelpers.LoadMockGenerator();
            Assert.IsNotNull(generator.Object.Visitors);
            Assert.IsTrue(generator.Object.Visitors.Count > 0);
        }

        [Test]
        public void EmptyPluginOption_DoesNotThrow()
        {
            // When plugin option is empty, it should be ignored
            var generator = MockHelpers.LoadMockGenerator(
                configurationJson: "{ \"package-name\": \"Test\", \"plugin\": \"\" }");
            Assert.IsNotNull(generator.Object.Visitors);
        }

        [Test]
        public void InvalidPluginPath_ThrowsInvalidOperationException()
        {
            // When plugin path doesn't exist, it should throw
            Assert.Throws<TargetInvocationException>(() =>
            {
                MockHelpers.LoadMockGenerator(
                    configurationJson: "{ \"package-name\": \"Test\", \"plugin\": \"/nonexistent/path/plugin.dll\" }");
            });
        }

        [Test]
        public void ValidPluginDll_LoadsAndAppliesPlugin()
        {
            // Point to the test assembly itself, which contains TestGeneratorPlugin
            var testAssemblyPath = typeof(PluginLoadingTests).Assembly.Location;

            var configJson = $"{{ \"package-name\": \"Test\", \"plugin\": \"{testAssemblyPath.Replace("\\", "\\\\")}\" }}";
            var generator = MockHelpers.LoadMockGenerator(configurationJson: configJson);

            // Verify that TestGeneratorPlugin's visitor was applied
            Assert.IsTrue(
                generator.Object.Visitors.Any(v => v is TestPluginVisitor),
                "TestPluginVisitor should have been added by TestGeneratorPlugin");
        }

        [Test]
        public void ValidPluginDirectory_LoadsPlugins()
        {
            // Point to the directory containing the test assembly
            var testAssemblyDir = Path.GetDirectoryName(typeof(PluginLoadingTests).Assembly.Location)!;

            var configJson = $"{{ \"package-name\": \"Test\", \"plugin\": \"{testAssemblyDir.Replace("\\", "\\\\")}\" }}";
            var generator = MockHelpers.LoadMockGenerator(configurationJson: configJson);

            // Verify that TestGeneratorPlugin's visitor was applied
            Assert.IsTrue(
                generator.Object.Visitors.Any(v => v is TestPluginVisitor),
                "TestPluginVisitor should have been added by TestGeneratorPlugin from directory scan");
        }
    }
}
