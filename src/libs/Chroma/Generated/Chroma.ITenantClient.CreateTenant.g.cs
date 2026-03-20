#nullable enable

namespace Chroma
{
    public partial interface ITenantClient
    {
        /// <summary>
        /// Create tenant<br/>
        /// Creates a new tenant.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateTenantAsync(

            global::Chroma.CreateTenantPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create tenant<br/>
        /// Creates a new tenant.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateTenantAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}