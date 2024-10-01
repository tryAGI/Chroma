#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Create Tenant
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Tenant> CreateTenantAsync(
            global::Chroma.CreateTenant request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Tenant
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Tenant> CreateTenantAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}