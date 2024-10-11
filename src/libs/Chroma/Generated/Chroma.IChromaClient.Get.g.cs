#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.GetResult> GetAsync(
            string collectionId,
            global::Chroma.GetEmbedding request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="ids"></param>
        /// <param name="where"></param>
        /// <param name="whereDocument"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="include">
        /// Default Value: [ns, documents]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.GetResult> GetAsync(
            string collectionId,
            global::System.Collections.Generic.IList<string>? ids = default,
            object? where = default,
            object? whereDocument = default,
            string? sort = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::Chroma.GetEmbeddingIncludeItemVariant1?, global::Chroma.GetEmbeddingIncludeItemVariant2?, global::Chroma.GetEmbeddingIncludeItemVariant3?, global::Chroma.GetEmbeddingIncludeItemVariant4?>>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}