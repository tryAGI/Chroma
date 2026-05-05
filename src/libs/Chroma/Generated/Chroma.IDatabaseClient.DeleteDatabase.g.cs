#nullable enable

namespace Chroma
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Delete database<br/>
        /// Deletes a database by name.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// chroma db delete my-db
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.DeleteDatabaseResponse> DeleteDatabaseAsync(
            string tenant,
            string database,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete database<br/>
        /// Deletes a database by name.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// chroma db delete my-db
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Chroma.AutoSDKHttpResponse<global::Chroma.DeleteDatabaseResponse>> DeleteDatabaseAsResponseAsync(
            string tenant,
            string database,
            global::Chroma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}