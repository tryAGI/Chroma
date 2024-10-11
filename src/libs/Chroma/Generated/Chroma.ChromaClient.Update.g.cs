
#nullable enable

namespace Chroma
{
    public partial class ChromaClient
    {
        partial void PrepareUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string collectionId,
            global::Chroma.UpdateEmbedding request);
        partial void PrepareUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string collectionId,
            global::Chroma.UpdateEmbedding request);
        partial void ProcessUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<bool> UpdateAsync(
            string collectionId,
            global::Chroma.UpdateEmbedding request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateArguments(
                httpClient: _httpClient,
                collectionId: ref collectionId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/collections/{collectionId}/update",
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
            PrepareUpdateRequest(
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
            ProcessUpdateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(bool?), JsonSerializerContext) as bool? ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="embeddings"></param>
        /// <param name="metadatas"></param>
        /// <param name="documents"></param>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<bool> UpdateAsync(
            string collectionId,
            global::System.Collections.Generic.IList<string> ids,
            global::Chroma.UpdateEmbeddingEmbeddings? embeddings = default,
            global::System.Collections.Generic.IList<object>? metadatas = default,
            global::System.Collections.Generic.IList<string>? documents = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Chroma.UpdateEmbedding
            {
                Embeddings = embeddings,
                Metadatas = metadatas,
                Documents = documents,
                Ids = ids,
            };

            return await UpdateAsync(
                collectionId: collectionId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}