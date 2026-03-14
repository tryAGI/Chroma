
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Chroma.SearchPayloadFilter? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::Chroma.SearchPayloadGroupBy? GroupBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public global::Chroma.SearchPayloadLimit? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        public object? Rank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("select")]
        public global::Chroma.SearchPayloadSelect? Select { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPayload" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="groupBy"></param>
        /// <param name="limit"></param>
        /// <param name="rank"></param>
        /// <param name="select"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchPayload(
            global::Chroma.SearchPayloadFilter? filter,
            global::Chroma.SearchPayloadGroupBy? groupBy,
            global::Chroma.SearchPayloadLimit? limit,
            object? rank,
            global::Chroma.SearchPayloadSelect? select)
        {
            this.Filter = filter;
            this.GroupBy = groupBy;
            this.Limit = limit;
            this.Rank = rank;
            this.Select = select;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPayload" /> class.
        /// </summary>
        public SearchPayload()
        {
        }
    }
}