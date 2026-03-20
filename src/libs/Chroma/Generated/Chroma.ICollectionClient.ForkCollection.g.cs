#nullable enable

namespace Chroma
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Fork collection<br/>
        /// Creates a fork of an existing collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// const forked = await collection.fork({ name: 'forked_collection' });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.Collection> ForkCollectionAsync(
            string tenant,
            string database,
            string collectionId,

            global::Chroma.ForkCollectionPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork collection<br/>
        /// Creates a fork of an existing collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="newName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Collection> ForkCollectionAsync(
            string tenant,
            string database,
            string collectionId,
            string newName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}