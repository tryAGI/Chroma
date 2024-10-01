#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Get Nearest Neighbors
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.QueryResult> GetNearestNeighborsAsync(
            string collectionId,
            global::Chroma.QueryEmbedding request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Nearest Neighbors
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="where"></param>
        /// <param name="whereDocument"></param>
        /// <param name="queryEmbeddings"></param>
        /// <param name="nResults">
        /// Default Value: 10
        /// </param>
        /// <param name="include">
        /// Default Value: [metadatas, documents, distances]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.QueryResult> GetNearestNeighborsAsync(
            string collectionId,
            global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>> queryEmbeddings,
            global::Chroma.QueryEmbeddingWhere? where = default,
            global::Chroma.QueryEmbeddingWhereDocument? whereDocument = default,
            int? nResults = 10,
            global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::Chroma.QueryEmbeddingIncludeItemVariant1?, global::Chroma.QueryEmbeddingIncludeItemVariant2?, global::Chroma.QueryEmbeddingIncludeItemVariant3?, global::Chroma.QueryEmbeddingIncludeItemVariant4?>>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}