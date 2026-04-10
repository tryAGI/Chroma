#nullable enable

namespace Chroma
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Delete collection<br/>
        /// Deletes a collection in a database.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// await client.deleteCollection({ name: 'my_collection' });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.DeleteCollectionResponse> DeleteCollectionAsync(
            string tenant,
            string database,
            string collectionId,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}