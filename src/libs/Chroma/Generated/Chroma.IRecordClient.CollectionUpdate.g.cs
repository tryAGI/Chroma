#nullable enable

namespace Chroma
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Update records<br/>
        /// Updates records in a collection by ID.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// await collection.update({ ids: ['id1'], documents: ['updated doc'], metadatas: [{ key: 'value' }] });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.UpdateCollectionRecordsResponse> CollectionUpdateAsync(
            string tenant,
            string database,
            string collectionId,

            global::Chroma.UpdateCollectionRecordsPayload request,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update records<br/>
        /// Updates records in a collection by ID.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// await collection.update({ ids: ['id1'], documents: ['updated doc'], metadatas: [{ key: 'value' }] });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.AutoSDKHttpResponse<global::Chroma.UpdateCollectionRecordsResponse>> CollectionUpdateAsResponseAsync(
            string tenant,
            string database,
            string collectionId,

            global::Chroma.UpdateCollectionRecordsPayload request,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update records<br/>
        /// Updates records in a collection by ID.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="documents"></param>
        /// <param name="embeddings"></param>
        /// <param name="ids"></param>
        /// <param name="metadatas"></param>
        /// <param name="uris"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.UpdateCollectionRecordsResponse> CollectionUpdateAsync(
            string tenant,
            string database,
            string collectionId,
            global::System.Collections.Generic.IList<string> ids,
            global::System.Collections.Generic.IList<string>? documents = default,
            global::Chroma.OneOf<object, global::Chroma.UpdateEmbeddingsPayload?>? embeddings = default,
            global::System.Collections.Generic.IList<global::Chroma.OneOf<object, global::Chroma.HashMap>>? metadatas = default,
            global::System.Collections.Generic.IList<string>? uris = default,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}