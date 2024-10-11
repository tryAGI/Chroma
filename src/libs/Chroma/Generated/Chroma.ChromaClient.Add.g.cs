
#nullable enable

namespace Chroma
{
    public partial class ChromaClient
    {
        partial void PrepareAddArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string collectionId,
            global::Chroma.AddEmbedding request);
        partial void PrepareAddRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string collectionId,
            global::Chroma.AddEmbedding request);
        partial void ProcessAddResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAddResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<bool> AddAsync(
            string collectionId,
            global::Chroma.AddEmbedding request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareAddArguments(
                httpClient: _httpClient,
                collectionId: ref collectionId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/collections/{collectionId}/add",
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
            PrepareAddRequest(
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
            ProcessAddResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAddResponseContent(
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
        /// Add
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="embeddings"></param>
        /// <param name="metadatas"></param>
        /// <param name="documents"></param>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<bool> AddAsync(
            string collectionId,
            global::System.Collections.Generic.IList<string> ids,
            global::Chroma.AddEmbeddingEmbeddings? embeddings = default,
            global::System.Collections.Generic.IList<object>? metadatas = default,
            global::System.Collections.Generic.IList<string>? documents = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Chroma.AddEmbedding
            {
                Embeddings = embeddings,
                Metadatas = metadatas,
                Documents = documents,
                Ids = ids,
            };

            return await AddAsync(
                collectionId: collectionId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}