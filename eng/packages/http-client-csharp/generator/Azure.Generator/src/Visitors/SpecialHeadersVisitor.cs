// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.TypeSpec.Generator.ClientModel;
using Microsoft.TypeSpec.Generator.ClientModel.Providers;
using Microsoft.TypeSpec.Generator.Expressions;
using Microsoft.TypeSpec.Generator.Input;
using Microsoft.TypeSpec.Generator.Providers;
using Microsoft.TypeSpec.Generator.Statements;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.TypeSpec.Generator.Snippets.Snippet;

namespace Azure.Generator.Visitors
{
    /// <summary>
    /// Visitor to handle removing special header parameters from service methods and adding them to the request.
    /// </summary>
    internal class SpecialHeadersVisitor : ScmLibraryVisitor
    {
        private readonly bool _includeClientRequestIdInRequest;
        private const string ReturnClientRequestIdParameterName = "return-client-request-id";
        private const string XMsClientRequestIdParameterName = "x-ms-client-request-id";
        private readonly Dictionary<InputServiceMethod, (InputMethodParameter? ReturnClientRequestId, InputMethodParameter? XmsClientRequestId)> _serviceMethodParameterMap;

        public SpecialHeadersVisitor(bool includeXmsClientRequestIdInRequest = false)
        {
            _includeClientRequestIdInRequest = includeXmsClientRequestIdInRequest;
            _serviceMethodParameterMap = [];
        }

        protected override ScmMethodProviderCollection? Visit(
            InputServiceMethod serviceMethod,
            ClientProvider client,
            ScmMethodProviderCollection? methods)
        {
            var returnClientRequestIdParameter =
                serviceMethod.Parameters.FirstOrDefault(p => p.SerializedName == ReturnClientRequestIdParameterName);
            var xMsClientRequestIdParameter =
                serviceMethod.Parameters.FirstOrDefault(p => p.SerializedName == XMsClientRequestIdParameterName);

            if (returnClientRequestIdParameter != null || xMsClientRequestIdParameter != null)
            {
                serviceMethod.Update(parameters: [.. serviceMethod.Parameters.Where(p => p.SerializedName != ReturnClientRequestIdParameterName && p.SerializedName != XMsClientRequestIdParameterName)]);
                serviceMethod.Operation.Update(parameters: [.. serviceMethod.Operation.Parameters.Where(p => p.SerializedName != ReturnClientRequestIdParameterName && p.SerializedName != XMsClientRequestIdParameterName)]);

                // Create a new method collection with the updated service method
                methods = new ScmMethodProviderCollection(serviceMethod, client);

                // Store the parameters for the CreateRequest method
                _serviceMethodParameterMap.TryAdd(serviceMethod, (returnClientRequestIdParameter, xMsClientRequestIdParameter));

                // Reset the rest client so that its methods are rebuilt reflecting the new signatures
                client.RestClient.Reset();
            }

            return methods;
        }

        protected override ScmMethodProvider? VisitMethod(ScmMethodProvider method)
        {
            if (method.ServiceMethod is null || !_serviceMethodParameterMap.TryGetValue(method.ServiceMethod, out var parameters))
            {
                return method;
            }

            var (returnClientRequestIdParameter, xMsClientRequestIdParameter) = parameters;

            var originalBodyStatements = method.BodyStatements!.ToList();

            // Exclude the last statement which is the return statement. We will add it back later.
            var newStatements = new List<MethodBodyStatement>(originalBodyStatements[..^1]);

            // Find the request variable
            VariableExpression? requestVariable = null;
            foreach (var statement in newStatements)
            {
                if (statement is ExpressionStatement
                    {
                        Expression: AssignmentExpression { Variable: DeclarationExpression declaration }
                    })
                {
                    var variable = declaration.Variable;
                    if (variable.Type.Equals(variable.ToApi<HttpRequestApi>().Type))
                    {
                        requestVariable = variable;
                    }
                }
            }

            var request = requestVariable?.ToApi<HttpRequestApi>();
            if (request != null && returnClientRequestIdParameter?.DefaultValue?.Value != null)
            {
                if (bool.TryParse(returnClientRequestIdParameter.DefaultValue.Value.ToString(), out bool value))
                {
                    // Set the return-client-request-id header
                    newStatements.Add(request.SetHeaders(
                    [
                        Literal(returnClientRequestIdParameter.SerializedName),
                        Literal(value.ToString().ToLowerInvariant())
                    ]));
                }
            }

            if (request != null && _includeClientRequestIdInRequest && xMsClientRequestIdParameter != null)
            {
                // Set the x-ms-client-request-id header
                newStatements.Add(request.SetHeaders(
                [
                    Literal(xMsClientRequestIdParameter.SerializedName),
                    request.Property("ClientRequestId")
                ]));
            }

            // Add the return statement back
            newStatements.Add(originalBodyStatements[^1]);

            method.Update(bodyStatements: newStatements);
            return method;
        }
    }
}