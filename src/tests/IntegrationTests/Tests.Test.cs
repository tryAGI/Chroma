namespace Chroma.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Generate()
    {
        using var client = new ChromaClient();

        client.Authentication.HttpClient.Should().BeSameAs(client.HttpClient);
        client.Collection.HttpClient.Should().BeSameAs(client.HttpClient);
        client.System.HttpClient.Should().BeSameAs(client.HttpClient);
        client.Tenant.HttpClient.Should().BeSameAs(client.HttpClient);
        client.Database.HttpClient.Should().BeSameAs(client.HttpClient);
        client.Record.HttpClient.Should().BeSameAs(client.HttpClient);
        client.Function.HttpClient.Should().BeSameAs(client.HttpClient);
    }
}
