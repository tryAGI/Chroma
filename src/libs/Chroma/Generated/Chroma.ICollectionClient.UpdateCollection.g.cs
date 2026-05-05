#nullable enable

namespace Chroma
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Update collection<br/>
        /// Updates an existing collection's name or metadata.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// await collection.modify({ name: 'new_name', metadata: { key: 'value' } });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.UpdateCollectionResponse> UpdateCollectionAsync(
            string tenant,
            string database,
            string collectionId,

            global::Chroma.UpdateCollectionPayload request,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update collection<br/>
        /// Updates an existing collection's name or metadata.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// await collection.modify({ name: 'new_name', metadata: { key: 'value' } });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.AutoSDKHttpResponse<global::Chroma.UpdateCollectionResponse>> UpdateCollectionAsResponseAsync(
            string tenant,
            string database,
            string collectionId,

            global::Chroma.UpdateCollectionPayload request,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update collection<br/>
        /// Updates an existing collection's name or metadata.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="newConfiguration"></param>
        /// <param name="newMetadata"></param>
        /// <param name="newName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.UpdateCollectionResponse> UpdateCollectionAsync(
            string tenant,
            string database,
            string collectionId,
            global::Chroma.OneOf<object, global::Chroma.UpdateCollectionConfiguration>? newConfiguration = default,
            global::Chroma.OneOf<object, global::Chroma.HashMap>? newMetadata = default,
            string? newName = default,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}