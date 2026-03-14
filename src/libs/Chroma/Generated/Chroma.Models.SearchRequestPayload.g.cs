
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequestPayload
    {
        /// <summary>
        /// Specifies whether to include unindexed data in the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.ReadLevelJsonConverter))]
        public global::Chroma.ReadLevel? ReadLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Chroma.SearchPayload> Searches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestPayload" /> class.
        /// </summary>
        /// <param name="readLevel">
        /// Specifies whether to include unindexed data in the search results.
        /// </param>
        /// <param name="searches"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequestPayload(
            global::System.Collections.Generic.IList<global::Chroma.SearchPayload> searches,
            global::Chroma.ReadLevel? readLevel)
        {
            this.Searches = searches ?? throw new global::System.ArgumentNullException(nameof(searches));
            this.ReadLevel = readLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestPayload" /> class.
        /// </summary>
        public SearchRequestPayload()
        {
        }
    }
}