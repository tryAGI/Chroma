using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;

namespace Chroma.IntegrationTests;

public sealed class Environment : IAsyncDisposable
{
    private const string ChromaImage = "chromadb/chroma:latest";
    private const ushort ChromaPort = 8000;
    private static readonly TimeSpan StartupTimeout = TimeSpan.FromMinutes(2);

    public IContainer? Container { get; init; }
    public required ChromaClient Client { get; init; }

    public async ValueTask DisposeAsync()
    {
        Client.Dispose();
        if (Container != null)
        {
            await Container.DisposeAsync();
        }
    }

    public static async Task<Environment> PrepareAsync(EnvironmentType? environmentType = null)
    {
        environmentType ??= InferEnvironment();
        switch (environmentType)
        {
            case EnvironmentType.Local:
            {
                var client = new ChromaClient(
                    baseUri: new Uri($"http://127.0.0.1:{ChromaPort}"));

                return new Environment
                {
                    Client = client,
                };
            }
            case EnvironmentType.Container:
            {
                var container = new ContainerBuilder(ChromaImage)
                    .WithPortBinding(ChromaPort, assignRandomHostPort: true)
                    .WithWaitStrategy(
                        Wait.ForUnixContainer()
                            .UntilHttpRequestIsSucceeded(request => request
                                .ForPath("/api/v2/heartbeat")
                                .ForPort(ChromaPort)))
                    .Build();

                using var cts = new CancellationTokenSource(StartupTimeout);
                await container.StartAsync(cts.Token);

                var client = new ChromaClient(
                    baseUri: new UriBuilder(
                        Uri.UriSchemeHttp,
                        container.Hostname,
                        container.GetMappedPublicPort(ChromaPort)).Uri);

                return new Environment
                {
                    Container = container,
                    Client = client,
                };
            }
            default:
                throw new ArgumentOutOfRangeException(nameof(environmentType), environmentType, null);
        }
    }

    private static EnvironmentType InferEnvironment()
    {
#if DEBUG
        return EnvironmentType.Local;
#else
        return EnvironmentType.Container;
#endif
    }
}

public enum EnvironmentType
{
    Local,
    Container,
}
