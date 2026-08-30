/*
order: 40
title: Reset
slug: reset
*/

using System.Net;
using System.Net.Http.Headers;

namespace Chroma.IntegrationTests;

public partial class Tests
{
    //// Reset permanently deletes all data and is disabled by default on the Chroma server.
    //// Enable it only in a disposable environment with `allow_reset: true` in the YAML
    //// configuration, or with the `CHROMA_ALLOW_RESET=true` environment override.

    [TestMethod]
    public async Task Example_Reset()
    {
        var handler = new ResetRequestHandler();
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("http://localhost:8000"),
        };
        using var client = new ChromaClient(
            apiKey: "test-token",
            httpClient: httpClient,
            disposeHttpClient: false);

        var result = await client.System.ResetAsync();

        result.Should().Be("true");
        handler.Method.Should().Be(HttpMethod.Post);
        handler.RequestUri.Should().Be(new Uri("http://localhost:8000/api/v2/reset"));
        handler.ApiKey.Should().Be("test-token");
    }

    private sealed class ResetRequestHandler : HttpMessageHandler
    {
        public HttpMethod? Method { get; private set; }
        public Uri? RequestUri { get; private set; }
        public string? ApiKey { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Method = request.Method;
            RequestUri = request.RequestUri;
            ApiKey = request.Headers.GetValues("x-chroma-token").Single();

            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("true")
                {
                    Headers = { ContentType = new MediaTypeHeaderValue("text/plain") },
                },
            });
        }
    }
}
