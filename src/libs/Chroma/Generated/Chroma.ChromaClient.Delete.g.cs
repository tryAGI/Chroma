
#nullable enable

namespace Chroma
{
    public partial class ChromaClient
    {
        partial void PrepareDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string collectionId,
            global::Chroma.DeleteEmbedding request);
        partial void PrepareDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string collectionId,
            global::Chroma.DeleteEmbedding request);
        partial void ProcessDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Guid>> DeleteAsync(
            string collectionId,
            global::Chroma.DeleteEmbedding request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDeleteArguments(
                httpClient: HttpClient,
                collectionId: ref collectionId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/collections/{collectionId}/delete",
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
            PrepareDeleteRequest(
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
            ProcessDeleteResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::System.Guid>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::System.Guid> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="ids"></param>
        /// <param name="where"></param>
        /// <param name="whereDocument"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Guid>> DeleteAsync(
            string collectionId,
            global::System.Collections.Generic.IList<string>? ids = default,
            object? where = default,
            object? whereDocument = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Chroma.DeleteEmbedding
            {
                Ids = ids,
                Where = where,
                WhereDocument = whereDocument,
            };

            return await DeleteAsync(
                collectionId: collectionId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}