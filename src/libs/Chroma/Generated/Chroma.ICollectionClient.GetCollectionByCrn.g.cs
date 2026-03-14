#nullable enable

namespace Chroma
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Get collection by CRN<br/>
        /// Returns a collection by Chroma Resource Name.
        /// </summary>
        /// <param name="crn"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Chroma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Chroma.Collection> GetCollectionByCrnAsync(
            string crn,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}