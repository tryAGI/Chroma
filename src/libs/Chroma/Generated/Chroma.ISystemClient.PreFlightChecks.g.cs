#nullable enable

namespace Chroma
{
    public partial interface ISystemClient
    {
        /// <summary>
        /// Pre-flight checks<br/>
        /// Returns basic readiness information.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.ChecklistResponse> PreFlightChecksAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}