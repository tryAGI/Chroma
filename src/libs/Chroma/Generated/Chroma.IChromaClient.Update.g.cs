#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> UpdateAsync(
            string collectionId,
            global::Chroma.UpdateEmbedding request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="embeddings"></param>
        /// <param name="metadatas"></param>
        /// <param name="documents"></param>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> UpdateAsync(
            string collectionId,
            global::System.Collections.Generic.IList<string> ids,
            global::Chroma.UpdateEmbeddingEmbeddings? embeddings = default,
            global::System.Collections.Generic.IList<global::Chroma.UpdateEmbeddingMetadata>? metadatas = default,
            global::System.Collections.Generic.IList<string>? documents = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}