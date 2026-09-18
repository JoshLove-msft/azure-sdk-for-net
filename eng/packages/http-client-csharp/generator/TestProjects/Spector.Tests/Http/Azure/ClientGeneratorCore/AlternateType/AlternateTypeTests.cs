// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.GeoJson;
using NUnit.Framework;
using Specs.Azure.ClientGenerator.Core.AlternateType;
using Specs.Azure.ClientGenerator.Core.AlternateType._ExternalType;

namespace TestProjects.Spector.Tests.Http.Azure.ClientGeneratorCore.AlternateType
{
    public class AlternateTypeTests : SpectorTestBase
    {
        [SpectorTest]
        public Task GetModel() => Test(async (host) =>
        {
            var response = await new AlternateTypeClient(host, null).GetExternalTypeClient().GetModelAsync();

            Assert.AreEqual(200, response.GetRawResponse().Status);
            AssertFeature(response.Value);
        });

        [SpectorTest]
        public Task PutModel() => Test(async (host) =>
        {
            var response = await new AlternateTypeClient(host, null).GetExternalTypeClient().PutModelAsync(CreateFeature());

            Assert.AreEqual(204, response.Status);
        });

        [SpectorTest]
        public Task GetProperty() => Test(async (host) =>
        {
            var response = await new AlternateTypeClient(host, null).GetExternalTypeClient().GetPropertyAsync();

            Assert.AreEqual(200, response.GetRawResponse().Status);
            AssertFeature(response.Value.Feature);
            Assert.AreEqual("extra", response.Value.AdditionalProperty);
        });

        [SpectorTest]
        public Task PutProperty() => Test(async (host) =>
        {
            var body = new ModelWithFeatureProperty(CreateFeature(), "extra");
            var response = await new AlternateTypeClient(host, null).GetExternalTypeClient().PutPropertyAsync(body);

            Assert.AreEqual(204, response.Status);
        });

        [SpectorTest]
        public Task GetPoint() => Test(async (host) =>
        {
            var client = new AlternateTypeClient(host, null).GetExternalTypeClient();
            var response = await client.GetPointAsync();

            Assert.AreEqual(200, response.GetRawResponse().Status);
            AssertPoint(response.Value);

            var syncResponse = client.GetPoint();
            Assert.AreEqual(200, syncResponse.GetRawResponse().Status);
            AssertPoint(syncResponse.Value);
        });

        [SpectorTest]
        public Task PutPoint() => Test(async (host) =>
        {
            var client = new AlternateTypeClient(host, null).GetExternalTypeClient();
            var point = new GeoPoint(-122.25, 37.87);
            var response = await client.PutPointAsync(point);

            Assert.AreEqual(204, response.Status);
            Assert.AreEqual(204, client.PutPoint(point).Status);
        });

        [SpectorTest]
        public Task GetPointProperty() => Test(async (host) =>
        {
            var client = new AlternateTypeClient(host, null).GetExternalTypeClient();
            var response = await client.GetPointPropertyAsync();

            Assert.AreEqual(200, response.GetRawResponse().Status);
            AssertPoint(response.Value.Point);
            Assert.AreEqual("extra", response.Value.AdditionalProperty);

            var syncResponse = client.GetPointProperty();
            Assert.AreEqual(200, syncResponse.GetRawResponse().Status);
            AssertPoint(syncResponse.Value.Point);
            Assert.AreEqual("extra", syncResponse.Value.AdditionalProperty);
        });

        [SpectorTest]
        public Task PutPointProperty() => Test(async (host) =>
        {
            var client = new AlternateTypeClient(host, null).GetExternalTypeClient();
            var body = new ModelWithPointProperty(new GeoPoint(-122.25, 37.87), "extra");
            var response = await client.PutPointPropertyAsync(body);

            Assert.AreEqual(204, response.Status);
            Assert.AreEqual(204, client.PutPointProperty(body).Status);
        });

        private static Feature CreateFeature() => new Feature(
            new Geometry("Point", new[] { -122.25, 37.87 }),
            new Dictionary<string, BinaryData>
            {
                ["name"] = BinaryData.FromObjectAsJson("A single point of interest"),
                ["category"] = BinaryData.FromObjectAsJson("landmark"),
                ["elevation"] = BinaryData.FromObjectAsJson(100)
            })
        {
            Id = BinaryData.FromObjectAsJson("feature-1")
        };

        private static void AssertFeature(Feature feature)
        {
            Assert.AreEqual("Feature", feature.Type);
            Assert.AreEqual("Point", feature.Geometry.Type);
            CollectionAssert.AreEqual(new[] { -122.25, 37.87 }, feature.Geometry.Coordinates);
            Assert.AreEqual(3, feature.Properties.Count);
            Assert.AreEqual("A single point of interest", feature.Properties["name"].ToObjectFromJson<string>());
            Assert.AreEqual("landmark", feature.Properties["category"].ToObjectFromJson<string>());
            Assert.AreEqual(100, feature.Properties["elevation"].ToObjectFromJson<int>());
            Assert.AreEqual("feature-1", feature.Id.ToObjectFromJson<string>());
        }

        private static void AssertPoint(GeoPoint point)
        {
            Assert.AreEqual(GeoObjectType.Point, point.Type);
            Assert.AreEqual(-122.25, point.Coordinates.Longitude);
            Assert.AreEqual(37.87, point.Coordinates.Latitude);
            Assert.IsNull(point.Coordinates.Altitude);
            Assert.IsNull(point.BoundingBox);
        }
    }
}
