#nullable enable

namespace Chroma
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Get collection by ID<br/>
        /// Returns a collection by its UUID within a specific tenant and database.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// const collection = await client.getCollectionById({ id: 'collection-uuid-here' });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.Collection> GetCollectionByIdAsync(
            string tenant,
            string database,
            string collectionId,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get collection by ID<br/>
        /// Returns a collection by its UUID within a specific tenant and database.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// const collection = await client.getCollectionById({ id: 'collection-uuid-here' });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.AutoSDKHttpResponse<global::Chroma.Collection>> GetCollectionByIdAsResponseAsync(
            string tenant,
            string database,
            string collectionId,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}