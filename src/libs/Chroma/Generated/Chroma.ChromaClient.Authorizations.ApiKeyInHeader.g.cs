
#nullable enable

namespace Chroma
{
    public sealed partial class ChromaClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Chroma.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "x-chroma-token",
                Value = apiKey,
            });
        }
    }
}