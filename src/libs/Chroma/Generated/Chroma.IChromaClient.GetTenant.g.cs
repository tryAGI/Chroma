#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Get Tenant
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Tenant> GetTenantAsync(
            string tenant,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}