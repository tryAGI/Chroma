#nullable enable

namespace Chroma
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Get collection<br/>
        /// Returns a collection by ID or name.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Collection> GetCollectionAsync(
            string tenant,
            string database,
            string collectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}