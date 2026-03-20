namespace Chroma.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static bool _chromaAvailable;

    [AssemblyInitialize]
    public static async Task AssemblyInit(TestContext context)
    {
        try
        {
            using var client = new ChromaClient();
            await client.System.HeartbeatAsync();
            _chromaAvailable = true;
        }
        catch
        {
            _chromaAvailable = false;
        }
    }

    [TestInitialize]
    public void CheckChromaAvailable()
    {
        if (!_chromaAvailable)
        {
            throw new AssertInconclusiveException(
                "Chroma server is not available at localhost:8000. Skipping integration tests.");
        }
    }
}
