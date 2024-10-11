#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> AddAsync(
            string collectionId,
            global::Chroma.AddEmbedding request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="embeddings"></param>
        /// <param name="metadatas"></param>
        /// <param name="documents"></param>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> AddAsync(
            string collectionId,
            global::System.Collections.Generic.IList<string> ids,
            global::Chroma.AddEmbeddingEmbeddings? embeddings = default,
            global::System.Collections.Generic.IList<object>? metadatas = default,
            global::System.Collections.Generic.IList<string>? documents = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}