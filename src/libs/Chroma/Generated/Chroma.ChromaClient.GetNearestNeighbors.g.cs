
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
                client: HttpClient);
            PrepareGetNearestNeighborsArguments(
                httpClient: HttpClient,
                collectionId: ref collectionId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/collections/{collectionId}/query",
                baseUri: HttpClient.BaseAddress); 
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
            PrepareGetNearestNeighborsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                collectionId: collectionId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetNearestNeighborsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetNearestNeighborsResponseContent(
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
                global::Chroma.QueryResult.FromJson(__content, JsonSerializerContext) ??
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
            int? nResults = default,
            global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::Chroma.QueryEmbeddingIncludeItemVariant1?, global::Chroma.QueryEmbeddingIncludeItemVariant2?, global::Chroma.QueryEmbeddingIncludeItemVariant3?, global::Chroma.QueryEmbeddingIncludeItemVariant4?>>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Chroma.QueryEmbedding
            {
                Where = where,
                WhereDocument = whereDocument,
                QueryEmbeddings = queryEmbeddings,
                NResults = nResults,
                Include = include,
            };

            return await GetNearestNeighborsAsync(
                collectionId: collectionId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}