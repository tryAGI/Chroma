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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        /// <remarks>
        /// chroma db delete my-db
        /// </remarks>
        global::System.Threading.Tasks.Task<string> DeleteDatabaseAsync(
            string tenant,
            string database,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}