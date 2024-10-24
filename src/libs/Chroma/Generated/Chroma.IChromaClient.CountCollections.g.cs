#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Count Collections
        /// </summary>
        /// <param name="tenant">
        /// Default Value: default_tenant
        /// </param>
        /// <param name="database">
        /// Default Value: default_database
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<int> CountCollectionsAsync(
            string? tenant = default,
            string? database = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}