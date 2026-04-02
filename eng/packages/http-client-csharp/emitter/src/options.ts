// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

import { JSONSchemaType } from "@typespec/compiler";
import {
  CSharpEmitterOptions,
  CSharpEmitterOptionsSchema
} from "@typespec/http-client-csharp";

export interface AzureEmitterOptions extends CSharpEmitterOptions {
  namespace?: string;
  "model-namespace"?: boolean;
  plugin?: string;
}

export const AzureEmitterOptionsSchema: JSONSchemaType<AzureEmitterOptions> = {
  type: "object",
  additionalProperties: false,
  properties: {
    ...CSharpEmitterOptionsSchema.properties,
    namespace: {
      type: "string",
      nullable: true,
      description:
        "The C# namespace to use for the generated code. This will override the TypeSpec namespaces."
    },
    "model-namespace": {
      type: "boolean",
      nullable: true,
      description:
        "Whether to put models under a separate 'Models' sub-namespace. This only applies if the 'namespace' option is set. " +
        " The default value is 'false'."
    },
    plugin: {
      type: "string",
      nullable: true,
      description:
        "Path to a generator plugin assembly (DLL) or a directory containing plugin assemblies. " +
        "The plugin must contain a class that extends GeneratorPlugin. " +
        "This eliminates the need for a separate npm package and emitter-package.json for custom visitors."
    }
  },
  required: []
};
