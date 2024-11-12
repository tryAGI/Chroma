
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEmbedding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("where")]
        public object? Where { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("where_document")]
        public object? WhereDocument { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        public string? Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Default Value: [ns, documents]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::Chroma.GetEmbeddingIncludeItemVariant1?, global::Chroma.GetEmbeddingIncludeItemVariant2?, global::Chroma.GetEmbeddingIncludeItemVariant3?, global::Chroma.GetEmbeddingIncludeItemVariant4?>>? Include { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmbedding" /> class.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="where"></param>
        /// <param name="whereDocument"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="include">
        /// Default Value: [ns, documents]
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetEmbedding(
            global::System.Collections.Generic.IList<string>? ids,
            object? where,
            object? whereDocument,
            string? sort,
            int? limit,
            int? offset,
            global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::Chroma.GetEmbeddingIncludeItemVariant1?, global::Chroma.GetEmbeddingIncludeItemVariant2?, global::Chroma.GetEmbeddingIncludeItemVariant3?, global::Chroma.GetEmbeddingIncludeItemVariant4?>>? include)
        {
            this.Ids = ids;
            this.Where = where;
            this.WhereDocument = whereDocument;
            this.Sort = sort;
            this.Limit = limit;
            this.Offset = offset;
            this.Include = include;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmbedding" /> class.
        /// </summary>
        public GetEmbedding()
        {
        }
    }
}