#nullable enable

namespace Chroma
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Get records<br/>
        /// Returns records from a collection by ID or metadata filter.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.GetResponse> CollectionGetAsync(
            string tenant,
            string database,
            string collectionId,

            global::Chroma.GetRequestPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get records<br/>
        /// Returns records from a collection by ID or metadata filter.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.GetResponse> CollectionGetAsync(
            string tenant,
            string database,
            string collectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}