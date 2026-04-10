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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.UpdateTenantResponse> UpdateTenantAsync(
            string tenantName,

            global::Chroma.UpdateTenantPayload request,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update tenant<br/>
        /// Updates an existing tenant by name.
        /// </summary>
        /// <param name="tenantName"></param>
        /// <param name="resourceName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.UpdateTenantResponse> UpdateTenantAsync(
            string tenantName,
            string resourceName,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}