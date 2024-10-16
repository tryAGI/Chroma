#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Create Collection
        /// </summary>
        /// <param name="tenant">
        /// Default Value: default_tenant
        /// </param>
        /// <param name="database">
        /// Default Value: default_database
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Collection> CreateCollectionAsync(
            global::Chroma.CreateCollection request,
            string? tenant = "default_tenant",
            string? database = "default_database",
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Collection
        /// </summary>
        /// <param name="tenant">
        /// Default Value: default_tenant
        /// </param>
        /// <param name="database">
        /// Default Value: default_database
        /// </param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="getOrCreate">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Collection> CreateCollectionAsync(
            string name,
            string? tenant = "default_tenant",
            string? database = "default_database",
            object? metadata = default,
            bool? getOrCreate = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}