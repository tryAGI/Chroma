#nullable enable

namespace Chroma
{
    public partial interface IChromaClient
    {
        /// <summary>
        /// List Collections
        /// </summary>
        /// <param name="tenant">
        /// Default Value: default_tenant
        /// </param>
        /// <param name="database">
        /// Default Value: default_database
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Chroma.Collection>> ListCollectionsAsync(
            string? tenant = default,
            string? database = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}