#nullable enable

namespace Chroma
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Update collection<br/>
        /// Updates an existing collection's name or metadata.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// await collection.modify({ name: 'new_name', metadata: { key: 'value' } });
        /// </remarks>
        global::System.Threading.Tasks.Task<string> UpdateCollectionAsync(
            string tenant,
            string database,
            string collectionId,

            global::Chroma.UpdateCollectionPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update collection<br/>
        /// Updates an existing collection's name or metadata.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="newConfiguration"></param>
        /// <param name="newMetadata"></param>
        /// <param name="newName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCollectionAsync(
            string tenant,
            string database,
            string collectionId,
            global::Chroma.OneOf<object, global::Chroma.UpdateCollectionConfiguration>? newConfiguration = default,
            object? newMetadata = default,
            string? newName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}