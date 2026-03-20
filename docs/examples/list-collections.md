# List Collections



This example assumes `using Chroma;` is in scope and `apiKey` contains your Chroma API key.

```csharp
using var client = new ChromaClient();

var collections = await client.Collection.ListCollectionsAsync(
    tenant: "default_tenant",
    database: "default_database");

foreach (var collection in collections)
{
    Console.WriteLine($"Collection: {collection}");
}
```