#nullable enable

namespace Chroma
{
    public partial interface ITenantClient
    {
        /// <summary>
        /// Update tenant<br/>
        /// Updates an existing tenant by name.
        /// </summary>
        /// <param name="tenantName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.UpdateTenantResponse> UpdateTenantAsync(
            string tenantName,

            global::Chroma.UpdateTenantPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update tenant<br/>
        /// Updates an existing tenant by name.
        /// </summary>
        /// <param name="tenantName"></param>
        /// <param name="resourceName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.UpdateTenantResponse> UpdateTenantAsync(
            string tenantName,
            string resourceName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}