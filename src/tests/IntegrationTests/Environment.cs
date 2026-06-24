using System.Diagnostics;
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
                    apiKey: "test",
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
                    apiKey: "test",
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
        if (System.Environment.GetEnvironmentVariable("CHROMA_TEST_ENVIRONMENT") is { Length: > 0 } environmentValue &&
            Enum.TryParse<EnvironmentType>(environmentValue, ignoreCase: true, out var environmentType))
        {
            return environmentType;
        }

        if (IsDockerAvailable())
        {
            return EnvironmentType.Container;
        }

#if DEBUG
        return EnvironmentType.Local;
#else
        return EnvironmentType.Container;
#endif
    }

    private static bool IsDockerAvailable()
    {
        try
        {
            using var process = Process.Start(new ProcessStartInfo
            {
                FileName = "docker",
                ArgumentList = { "info", "--format", "{{.ServerVersion}}" },
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            });

            return process is not null &&
                   process.WaitForExit(milliseconds: 5000) &&
                   process.ExitCode == 0;
        }
        catch
        {
            return false;
        }
    }
}

public enum EnvironmentType
{
    Local,
    Container,
}
