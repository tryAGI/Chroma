#nullable enable

namespace Chroma
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Search records<br/>
        /// Searches records from a collection with dense, sparse, or hybrid vector search.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.SearchResponse> CollectionSearchAsync(
            string tenant,
            string database,
            string collectionId,

            global::Chroma.SearchRequestPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search records<br/>
        /// Searches records from a collection with dense, sparse, or hybrid vector search.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="readLevel">
        /// Specifies whether to include unindexed data in the search results.
        /// </param>
        /// <param name="searches"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.SearchResponse> CollectionSearchAsync(
            string tenant,
            string database,
            string collectionId,
            global::System.Collections.Generic.IList<global::Chroma.SearchPayload> searches,
            global::Chroma.ReadLevel? readLevel = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}