#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Create Database
        /// </summary>
        /// <param name="tenant">
        /// Default Value: default_tenant
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Database> CreateDatabaseAsync(
            global::Chroma.CreateDatabase request,
            string? tenant = "default_tenant",
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Database
        /// </summary>
        /// <param name="tenant">
        /// Default Value: default_tenant
        /// </param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Database> CreateDatabaseAsync(
            string name,
            string? tenant = "default_tenant",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}