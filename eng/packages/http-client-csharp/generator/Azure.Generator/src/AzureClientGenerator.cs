// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Generator.Visitors;
using Microsoft.CodeAnalysis;
using Microsoft.TypeSpec.Generator;
using Microsoft.TypeSpec.Generator.ClientModel;
using System;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using Azure.Core.Expressions.DataFactory;
using Azure.Generator.Providers;

namespace Azure.Generator;

/// <summary>
/// The Azure client generator to generate the Azure client SDK.
/// </summary>
[Export(typeof(CodeModelGenerator))]
[ExportMetadata(GeneratorMetadataName, nameof(AzureClientGenerator))]
public class AzureClientGenerator : ScmCodeModelGenerator
{
    private static AzureClientGenerator? _instance;
    internal static new AzureClientGenerator Instance => _instance ?? throw new InvalidOperationException("AzureClientGenerator is not loaded.");

    /// <inheritdoc/>
    public override AzureTypeFactory TypeFactory { get; }

    private AzureOutputLibrary? _azureOutputLibrary;
    /// <inheritdoc/>
    public override AzureOutputLibrary OutputLibrary => _azureOutputLibrary ??= new();

    internal RawRequestUriBuilderExtensionsDefinition RawRequestUriBuilderExtensionsDefinition { get; } = new();

    internal RequestHeaderExtensionsDefinition RequestHeaderExtensionsDefinition { get; } = new();

    internal bool HasDataFactoryElement => _hasDataFactoryElement ??= BuildHasDataFactoryElement();
    private bool? _hasDataFactoryElement;
    internal const string DataFactoryElementIdentity = "Azure.Core.Expressions.DataFactoryElement";

    private bool BuildHasDataFactoryElement()
    {
        foreach (var model in InputLibrary.InputNamespace.Models)
        {
            foreach (var property in model.Properties)
            {
                if (property.Type.External?.Identity == DataFactoryElementIdentity)
                {
                    return true;
                }
            }
        }
        return false;
    }

    /// <summary>
    /// Constructs the Azure client generator used to generate the Azure client SDK.
    /// </summary>
    /// <param name="context"></param>
    [ImportingConstructor]
    public AzureClientGenerator(GeneratorContext context) : base(context)
    {
        TypeFactory = new AzureTypeFactory();
        _instance = this;
    }

    /// <summary>
    /// Customize the generation output for Azure client SDK.
    /// </summary>
    protected override void Configure()
    {
        base.Configure();

        // Include Azure.Core
        AddMetadataReference(MetadataReference.CreateFromFile(typeof(Response).Assembly.Location));
        if (HasDataFactoryElement)
        {
            AddMetadataReference(MetadataReference.CreateFromFile(typeof(DataFactoryElement<>).Assembly.Location));
        }

        var sharedSourceDirectory = Path.Combine(Path.GetDirectoryName(typeof(AzureClientGenerator).Assembly.Location)!, "Shared", "Core");
        AddSharedSourceDirectory(sharedSourceDirectory);

        // Visitors that do any renaming must be added first so that any visitors relying on custom code view will have the CustomCodeView set.
        AddVisitor(new ModelFactoryRenamerVisitor());

        // Rest of the visitors can be added in any order.
        AddVisitor(new NamespaceVisitor());
        AddVisitor(new DistributedTracingVisitor());
        AddVisitor(new PipelinePropertyVisitor());
        AddVisitor(new LroVisitor());
        AddVisitor(new MatchConditionsHeadersVisitor());
        AddVisitor(new ClientRequestIdHeaderVisitor());
        AddVisitor(new SystemTextJsonConverterVisitor());
        AddVisitor(new MultiPartFormDataVisitor());
        AddVisitor(new InvokeDelimitedMethodVisitor());
        AddVisitor(new XmlSerializableVisitor());
        AddVisitor(new ClientSettingsVisitor());

        // Load and apply external plugins specified via the 'plugin' emitter option
        LoadPluginFromConfiguration();
    }

    private const string PluginOptionKey = "plugin";

    /// <summary>
    /// Loads a generator plugin from the path specified in the 'plugin' configuration option.
    /// The plugin assembly must contain a class that extends <see cref="GeneratorPlugin"/>.
    /// </summary>
    private void LoadPluginFromConfiguration()
    {
        if (!Configuration.AdditionalConfigurationOptions.TryGetValue(PluginOptionKey, out var value))
        {
            return;
        }

        var pluginPath = value.ToString().Trim('"');
        if (string.IsNullOrEmpty(pluginPath))
        {
            return;
        }

        var assemblies = LoadPluginAssemblies(pluginPath);
        foreach (var assembly in assemblies)
        {
            ApplyPluginsFromAssembly(assembly);
        }
    }

    private Assembly[] LoadPluginAssemblies(string path)
    {
        if (File.Exists(path) && path.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
        {
            return [Assembly.LoadFrom(path)];
        }

        if (Directory.Exists(path))
        {
            return Directory.GetFiles(path, "*.dll")
                .Select(dll =>
                {
                    try
                    {
                        return Assembly.LoadFrom(dll);
                    }
                    catch
                    {
                        return null;
                    }
                })
                .Where(a => a != null)
                .ToArray()!;
        }

        throw new InvalidOperationException(
            $"Plugin path '{path}' does not exist. " +
            $"Specify a path to a DLL file or a directory containing plugin assemblies.");
    }

    private void ApplyPluginsFromAssembly(Assembly assembly)
    {
        var pluginTypes = assembly.GetTypes()
            .Where(t => typeof(GeneratorPlugin).IsAssignableFrom(t) && !t.IsAbstract);

        foreach (var pluginType in pluginTypes)
        {
            var plugin = (GeneratorPlugin)Activator.CreateInstance(pluginType)!;
            plugin.Apply(this);
        }
    }
}