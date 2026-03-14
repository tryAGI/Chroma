#nullable enable

namespace Chroma
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Add records<br/>
        /// Adds records to a collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CollectionAddAsync(
            string tenant,
            string database,
            string collectionId,

            global::Chroma.AddCollectionRecordsPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add records<br/>
        /// Adds records to a collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="documents"></param>
        /// <param name="embeddings">
        /// Embeddings for each record. Can contain the raw f32 arrays or base64 encoded strings.
        /// </param>
        /// <param name="ids">
        /// Unique identifiers for each record.
        /// </param>
        /// <param name="metadatas"></param>
        /// <param name="uris"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CollectionAddAsync(
            string tenant,
            string database,
            string collectionId,
            global::Chroma.EmbeddingsPayload embeddings,
            global::System.Collections.Generic.IList<string> ids,
            global::System.Collections.Generic.IList<string>? documents = default,
            global::System.Collections.Generic.IList<object>? metadatas = default,
            global::System.Collections.Generic.IList<string>? uris = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}