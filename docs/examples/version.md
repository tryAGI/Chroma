# Version



This example assumes `using Chroma;` is in scope and `apiKey` contains your Chroma API key.

```csharp
using var client = new ChromaClient();

string version = await client.System.VersionAsync();

Console.WriteLine($"Chroma version: {version}");
```