#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Update Collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Collection> UpdateCollectionAsync(
            string collectionName,
            global::Chroma.UpdateCollection request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="newName"></param>
        /// <param name="newMetadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Collection> UpdateCollectionAsync(
            string collectionName,
            string? newName = default,
            object? newMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}