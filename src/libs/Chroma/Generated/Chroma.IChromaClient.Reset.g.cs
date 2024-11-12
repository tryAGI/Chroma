#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Reset
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> ResetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}