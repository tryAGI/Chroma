#nullable enable

namespace Chroma
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Get user identity<br/>
        /// Returns the current user's identity, tenant, and databases.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.GetUserIdentityResponse> GetUserIdentityAsync(
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user identity<br/>
        /// Returns the current user's identity, tenant, and databases.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.AutoSDKHttpResponse<global::Chroma.GetUserIdentityResponse>> GetUserIdentityAsResponseAsync(
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}