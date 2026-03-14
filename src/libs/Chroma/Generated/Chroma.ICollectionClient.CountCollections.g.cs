#nullable enable

namespace Chroma
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Get number of collections<br/>
        /// Returns the total number of collections in a database.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<int> CountCollectionsAsync(
            string tenant,
            string database,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}