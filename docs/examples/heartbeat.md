# Heartbeat



This example assumes `using Chroma;` is in scope and `apiKey` contains your Chroma API key.

```csharp
using var client = new ChromaClient();

HeartbeatResponse heartbeat = await client.System.HeartbeatAsync();

Console.WriteLine($"Heartbeat: {heartbeat.Nanosecond_heartbeat}");
```