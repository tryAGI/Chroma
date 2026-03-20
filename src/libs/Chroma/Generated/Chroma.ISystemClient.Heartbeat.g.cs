#nullable enable

namespace Chroma
{
    public partial interface ISystemClient
    {
        /// <summary>
        /// Heartbeat<br/>
        /// Returns a nanosecond timestamp of the current time.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// const timestamp = await client.heartbeat();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.HeartbeatResponse> HeartbeatAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}