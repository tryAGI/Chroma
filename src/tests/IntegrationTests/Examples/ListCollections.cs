/*
order: 40
title: List Collections
slug: list-collections
*/

namespace Chroma.IntegrationTests;

public partial class Tests
{
    //// List all collections in the Chroma database.

    [TestMethod]
    public async Task Example_ListCollections()
    {
        using var client = new ChromaClient();

        var collections = await client.Collection.ListCollectionsAsync(
            tenant: "default_tenant",
            database: "default_database");

        collections.Should().NotBeNull();

        foreach (var collection in collections)
        {
            Console.WriteLine($"Collection: {collection}");
        }
    }
}
