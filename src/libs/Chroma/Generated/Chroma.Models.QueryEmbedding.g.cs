
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryEmbedding
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("query_embeddings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>> QueryEmbeddings { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_results")]
        public int? NResults { get; set; }

        /// <summary>
        /// Default Value: [metadatas, documents, distances]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::Chroma.QueryEmbeddingIncludeItemVariant1?, global::Chroma.QueryEmbeddingIncludeItemVariant2?, global::Chroma.QueryEmbeddingIncludeItemVariant3?, global::Chroma.QueryEmbeddingIncludeItemVariant4?>>? Include { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEmbedding" /> class.
        /// </summary>
        /// <param name="where"></param>
        /// <param name="whereDocument"></param>
        /// <param name="queryEmbeddings"></param>
        /// <param name="nResults">
        /// Default Value: 10
        /// </param>
        /// <param name="include">
        /// Default Value: [metadatas, documents, distances]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryEmbedding(
            global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>> queryEmbeddings,
            object? where,
            object? whereDocument,
            int? nResults,
            global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::Chroma.QueryEmbeddingIncludeItemVariant1?, global::Chroma.QueryEmbeddingIncludeItemVariant2?, global::Chroma.QueryEmbeddingIncludeItemVariant3?, global::Chroma.QueryEmbeddingIncludeItemVariant4?>>? include)
        {
            this.QueryEmbeddings = queryEmbeddings ?? throw new global::System.ArgumentNullException(nameof(queryEmbeddings));
            this.Where = where;
            this.WhereDocument = whereDocument;
            this.NResults = nResults;
            this.Include = include;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEmbedding" /> class.
        /// </summary>
        public QueryEmbedding()
        {
        }
    }
}