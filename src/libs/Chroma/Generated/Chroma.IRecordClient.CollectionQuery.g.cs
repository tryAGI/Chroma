#nullable enable

namespace Chroma
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Query collection<br/>
        /// Queries a collection using dense vector search with metadata and full-text search filtering.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// const results = await collection.query({ queryEmbeddings: [[0.1, 0.2, 0.3]], nResults: 10 });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.QueryResponse> CollectionQueryAsync(
            string tenant,
            string database,
            string collectionId,

            global::Chroma.QueryRequestPayload request,
            int? limit = default,
            int? offset = default,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query collection<br/>
        /// Queries a collection using dense vector search with metadata and full-text search filtering.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// const results = await collection.query({ queryEmbeddings: [[0.1, 0.2, 0.3]], nResults: 10 });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.AutoSDKHttpResponse<global::Chroma.QueryResponse>> CollectionQueryAsResponseAsync(
            string tenant,
            string database,
            string collectionId,

            global::Chroma.QueryRequestPayload request,
            int? limit = default,
            int? offset = default,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query collection<br/>
        /// Queries a collection using dense vector search with metadata and full-text search filtering.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.QueryResponse> CollectionQueryAsync(
            string tenant,
            string database,
            string collectionId,
            int? limit = default,
            int? offset = default,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}