#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Pre Flight Checks
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<object> PreFlightChecksAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}