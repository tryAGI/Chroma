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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteCollectionAsync(
            string tenant,
            string database,
            string collectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}