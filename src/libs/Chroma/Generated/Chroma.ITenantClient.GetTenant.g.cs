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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.GetTenantResponse> GetTenantAsync(
            string tenantName,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get tenant<br/>
        /// Returns an existing tenant by name.
        /// </summary>
        /// <param name="tenantName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.AutoSDKHttpResponse<global::Chroma.GetTenantResponse>> GetTenantAsResponseAsync(
            string tenantName,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}