#nullable enable

namespace Chroma
{
    public partial interface IFunctionClient
    {
        /// <summary>
        /// Detach function<br/>
        /// Detaches a function from a collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.DetachFunctionResponse> DetachFunctionAsync(
            string tenant,
            string database,
            string collectionId,
            string name,

            global::Chroma.DetachFunctionRequest request,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detach function<br/>
        /// Detaches a function from a collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="name"></param>
        /// <param name="deleteOutput">
        /// Whether to delete the output collection as well when detaching the function.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.DetachFunctionResponse> DetachFunctionAsync(
            string tenant,
            string database,
            string collectionId,
            string name,
            bool? deleteOutput = default,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}