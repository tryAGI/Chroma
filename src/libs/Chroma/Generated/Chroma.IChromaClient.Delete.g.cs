#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Guid>> DeleteAsync(
            string collectionId,
            global::Chroma.DeleteEmbedding request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="ids"></param>
        /// <param name="where"></param>
        /// <param name="whereDocument"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Guid>> DeleteAsync(
            string collectionId,
            global::System.Collections.Generic.IList<string>? ids = default,
            object? where = default,
            object? whereDocument = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}