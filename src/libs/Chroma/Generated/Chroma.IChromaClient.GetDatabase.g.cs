#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Get Database
        /// </summary>
        /// <param name="tenant">
        /// Default Value: default_tenant
        /// </param>
        /// <param name="database"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Database> GetDatabaseAsync(
            string database,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}