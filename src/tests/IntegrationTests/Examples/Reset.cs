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
    //// Reset the Chroma database. The server must allow resets for this endpoint to succeed.

/*
 * In order to reset the ChromaDB server, 
 * you need to set the "allow_reset" option to true in the ChromaDB configuration file (config.yaml).
 
########################
# HTTP server settings #
########################
port: 8000
listen_address: "0.0.0.0"
max_payload_size_bytes: 41943040
cors_allow_origins: ["*"]

####################
# General settings #
####################
persist_path: "./chroma"
allow_reset: true # defaults to false
sqlitedb:
  hash_type: "md5" # or "sha256"
  migration_mode: "apply" # or "validate"
sysdb:
  sqlite:
    log_topic_namespace: "default"
    log_tenant: "default" 
 */

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
