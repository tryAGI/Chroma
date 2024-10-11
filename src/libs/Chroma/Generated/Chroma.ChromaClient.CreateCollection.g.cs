
#nullable enable

namespace Chroma
{
    public partial class ChromaClient
    {
        partial void PrepareCreateCollectionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? tenant,
            ref string? database,
            global::Chroma.CreateCollection request);
        partial void PrepareCreateCollectionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? tenant,
            string? database,
            global::Chroma.CreateCollection request);
        partial void ProcessCreateCollectionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateCollectionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Collection
        /// </summary>
        /// <param name="tenant">
        /// Default Value: default_tenant
        /// </param>
        /// <param name="database">
        /// Default Value: default_database
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Chroma.Collection> CreateCollectionAsync(
            global::Chroma.CreateCollection request,
            string? tenant = "default_tenant",
            string? database = "default_database",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateCollectionArguments(
                httpClient: _httpClient,
                tenant: ref tenant,
                database: ref database,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/collections",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("tenant", tenant) 
                .AddOptionalParameter("database", database) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateCollectionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                tenant: tenant,
                database: database,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateCollectionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateCollectionResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Chroma.Collection), JsonSerializerContext) as global::Chroma.Collection ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Collection
        /// </summary>
        /// <param name="tenant">
        /// Default Value: default_tenant
        /// </param>
        /// <param name="database">
        /// Default Value: default_database
        /// </param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="getOrCreate">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Chroma.Collection> CreateCollectionAsync(
            string name,
            string? tenant = "default_tenant",
            string? database = "default_database",
            object? metadata = default,
            bool? getOrCreate = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Chroma.CreateCollection
            {
                Name = name,
                Metadata = metadata,
                GetOrCreate = getOrCreate,
            };

            return await CreateCollectionAsync(
                tenant: tenant,
                database: database,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}