/*
order: 30
title: Version
slug: version
*/

namespace Chroma.IntegrationTests;

public partial class Tests
{
    //// Retrieve the version of the running Chroma server.

    [TestMethod]
    public async Task Example_Version()
    {
        using var client = new ChromaClient();

        string version = await client.System.VersionAsync();

        version.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Chroma version: {version}");
    }
}
