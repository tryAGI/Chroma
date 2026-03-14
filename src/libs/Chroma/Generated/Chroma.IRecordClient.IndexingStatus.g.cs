#nullable enable

namespace Chroma
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Get indexing status<br/>
        /// Returns the indexing status of a collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.IndexStatusResponse> IndexingStatusAsync(
            string tenant,
            string database,
            string collectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}