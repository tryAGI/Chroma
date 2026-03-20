#nullable enable

namespace Chroma
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Create collection<br/>
        /// Creates a new collection in a database.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// const collection = await client.createCollection({ name: 'my_collection' });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.Collection> CreateCollectionAsync(
            string tenant,
            string database,

            global::Chroma.CreateCollectionPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create collection<br/>
        /// Creates a new collection in a database.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="configuration"></param>
        /// <param name="getOrCreate"></param>
        /// <param name="metadata"></param>
        /// <param name="name"></param>
        /// <param name="schema"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Collection> CreateCollectionAsync(
            string tenant,
            string database,
            string name,
            global::Chroma.OneOf<object, global::Chroma.CollectionConfiguration>? configuration = default,
            bool? getOrCreate = default,
            object? metadata = default,
            global::Chroma.OneOf<object, global::Chroma.Schema3>? schema = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}