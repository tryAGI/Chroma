#nullable enable

namespace Chroma
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Get fork count<br/>
        /// Returns the number of forks for a collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// const count = await collection.forkCount();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.ForkCountResponse> ForkCountAsync(
            string tenant,
            string database,
            string collectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}