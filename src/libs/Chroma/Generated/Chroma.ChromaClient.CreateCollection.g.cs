
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
            string? tenant = default,
            string? database = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateCollectionArguments(
                httpClient: HttpClient,
                tenant: ref tenant,
                database: ref database,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/collections",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("tenant", tenant) 
                .AddOptionalParameter("database", database) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateCollectionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                tenant: tenant,
                database: database,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateCollectionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateCollectionResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Chroma.Collection.FromJson(__content, JsonSerializerContext) ??
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
            string? tenant = default,
            string? database = default,
            object? metadata = default,
            bool? getOrCreate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Chroma.CreateCollection
            {
                Name = name,
                Metadata = metadata,
                GetOrCreate = getOrCreate,
            };

            return await CreateCollectionAsync(
                tenant: tenant,
                database: database,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}