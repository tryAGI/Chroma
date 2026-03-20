/*
order: 20
title: Heartbeat
slug: heartbeat
*/

namespace Chroma.IntegrationTests;

public partial class Tests
{
    //// Check if the Chroma server is alive by calling the heartbeat endpoint.

    [TestMethod]
    public async Task Example_Heartbeat()
    {
        using var client = new ChromaClient();

        HeartbeatResponse heartbeat = await client.System.HeartbeatAsync();

        heartbeat.Should().NotBeNull();

        Console.WriteLine($"Heartbeat: {heartbeat.Nanosecond_heartbeat}");
    }
}
