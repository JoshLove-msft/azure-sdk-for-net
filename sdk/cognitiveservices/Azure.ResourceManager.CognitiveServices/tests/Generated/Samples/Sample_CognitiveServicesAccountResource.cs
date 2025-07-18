// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CognitiveServices.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CognitiveServices.Samples
{
    public partial class Sample_CognitiveServicesAccountResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAccount()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/examples/GetAccount.json
            // this example is just showing the usage of "Accounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myResourceGroup";
            string accountName = "myAccount";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // invoke the operation
            CognitiveServicesAccountResource result = await cognitiveServicesAccount.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CognitiveServicesAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAccount()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/examples/DeleteAccount.json
            // this example is just showing the usage of "Accounts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myResourceGroup";
            string accountName = "PropTest01";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // invoke the operation
            await cognitiveServicesAccount.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAccount()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/examples/UpdateAccount.json
            // this example is just showing the usage of "Accounts_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "bvttest";
            string accountName = "bingSearch";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // invoke the operation
            CognitiveServicesAccountData data = new CognitiveServicesAccountData(new AzureLocation("global"))
            {
                Sku = new CognitiveServicesSku("S2"),
            };
            ArmOperation<CognitiveServicesAccountResource> lro = await cognitiveServicesAccount.UpdateAsync(WaitUntil.Completed, data);
            CognitiveServicesAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CognitiveServicesAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetKeys_ListKeys()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/examples/ListKeys.json
            // this example is just showing the usage of "Accounts_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myResourceGroup";
            string accountName = "myAccount";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // invoke the operation
            ServiceAccountApiKeys result = await cognitiveServicesAccount.GetKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RegenerateKey_RegenerateKeys()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/examples/RegenerateKey.json
            // this example is just showing the usage of "Accounts_RegenerateKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myResourceGroup";
            string accountName = "myAccount";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // invoke the operation
            RegenerateServiceAccountKeyContent content = new RegenerateServiceAccountKeyContent(ServiceAccountKeyName.Key2);
            ServiceAccountApiKeys result = await cognitiveServicesAccount.RegenerateKeyAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSkus_ListSKUs()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/examples/ListSkus.json
            // this example is just showing the usage of "Accounts_ListSkus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myResourceGroup";
            string accountName = "myAccount";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // invoke the operation and iterate over the result
            await foreach (CognitiveServicesAccountSku item in cognitiveServicesAccount.GetSkusAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetUsages_GetUsages()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/examples/GetUsages.json
            // this example is just showing the usage of "Accounts_ListUsages" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "5a4f5c2e-6983-4ccb-bd34-2196d5b5bbd3";
            string resourceGroupName = "myResourceGroup";
            string accountName = "TestUsage02";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // invoke the operation and iterate over the result
            await foreach (ServiceAccountUsage item in cognitiveServicesAccount.GetUsagesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetModels_ListAccountModels()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/examples/ListAccountModels.json
            // this example is just showing the usage of "Accounts_ListModels" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // invoke the operation and iterate over the result
            await foreach (CognitiveServicesAccountModel item in cognitiveServicesAccount.GetModelsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetPrivateLinkResources_ListPrivateLinkResources()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/examples/ListPrivateLinkResources.json
            // this example is just showing the usage of "PrivateLinkResources_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // invoke the operation and iterate over the result
            await foreach (CognitiveServicesPrivateLinkResource item in cognitiveServicesAccount.GetPrivateLinkResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
