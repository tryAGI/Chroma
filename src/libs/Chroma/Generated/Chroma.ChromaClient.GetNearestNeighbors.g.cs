
#nullable enable

namespace Chroma
{
    public partial class ChromaClient
    {
        partial void PrepareGetNearestNeighborsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string collectionId,
            global::Chroma.QueryEmbedding request);
        partial void PrepareGetNearestNeighborsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string collectionId,
            global::Chroma.QueryEmbedding request);
        partial void ProcessGetNearestNeighborsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetNearestNeighborsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Nearest Neighbors
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Chroma.QueryResult> GetNearestNeighborsAsync(
            string collectionId,
            global::Chroma.QueryEmbedding request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareGetNearestNeighborsArguments(
                httpClient: _httpClient,
                collectionId: ref collectionId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/collections/{collectionId}/query",
                baseUri: _httpClient.BaseAddress); 
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
            PrepareGetNearestNeighborsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                collectionId: collectionId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetNearestNeighborsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetNearestNeighborsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Chroma.QueryResult), JsonSerializerContext) as global::Chroma.QueryResult ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Get Nearest Neighbors
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="where"></param>
        /// <param name="whereDocument"></param>
        /// <param name="queryEmbeddings"></param>
        /// <param name="nResults">
        /// Default Value: 10
        /// </param>
        /// <param name="include">
        /// Default Value: [metadatas, documents, distances]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Chroma.QueryResult> GetNearestNeighborsAsync(
            string collectionId,
            global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>> queryEmbeddings,
            object? where = default,
            object? whereDocument = default,
            int? nResults = 10,
            global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::Chroma.QueryEmbeddingIncludeItemVariant1?, global::Chroma.QueryEmbeddingIncludeItemVariant2?, global::Chroma.QueryEmbeddingIncludeItemVariant3?, global::Chroma.QueryEmbeddingIncludeItemVariant4?>>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Chroma.QueryEmbedding
            {
                Where = where,
                WhereDocument = whereDocument,
                QueryEmbeddings = queryEmbeddings,
                NResults = nResults,
                Include = include,
            };

            return await GetNearestNeighborsAsync(
                collectionId: collectionId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}