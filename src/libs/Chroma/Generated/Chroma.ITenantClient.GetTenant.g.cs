#nullable enable

namespace Chroma
{
    public partial interface ITenantClient
    {
        /// <summary>
        /// Get tenant<br/>
        /// Returns an existing tenant by name.
        /// </summary>
        /// <param name="tenantName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.GetTenantResponse> GetTenantAsync(
            string tenantName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}