#nullable enable

namespace Chroma
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Create database<br/>
        /// Creates a new database for a tenant.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateDatabaseAsync(
            string tenant,

            global::Chroma.CreateDatabasePayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create database<br/>
        /// Creates a new database for a tenant.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateDatabaseAsync(
            string tenant,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}