#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Get Collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="tenant">
        /// Default Value: default_tenant
        /// </param>
        /// <param name="database">
        /// Default Value: default_database
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Collection> GetCollectionAsync(
            string collectionName,
            string? tenant = default,
            string? database = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}