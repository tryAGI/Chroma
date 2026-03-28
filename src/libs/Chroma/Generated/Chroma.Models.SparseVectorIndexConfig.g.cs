
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SparseVectorIndexConfig
    {
        /// <summary>
        /// Whether this embedding is BM25
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bm25")]
        public bool? Bm25 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_function")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.EmbeddingFunctionConfiguration?>))]
        public global::Chroma.OneOf<object, global::Chroma.EmbeddingFunctionConfiguration?>? EmbeddingFunction { get; set; }

        /// <summary>
        /// Key to source the sparse vector from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_key")]
        public string? SourceKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorIndexConfig" /> class.
        /// </summary>
        /// <param name="bm25">
        /// Whether this embedding is BM25
        /// </param>
        /// <param name="embeddingFunction"></param>
        /// <param name="sourceKey">
        /// Key to source the sparse vector from
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseVectorIndexConfig(
            bool? bm25,
            global::Chroma.OneOf<object, global::Chroma.EmbeddingFunctionConfiguration?>? embeddingFunction,
            string? sourceKey)
        {
            this.Bm25 = bm25;
            this.EmbeddingFunction = embeddingFunction;
            this.SourceKey = sourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorIndexConfig" /> class.
        /// </summary>
        public SparseVectorIndexConfig()
        {
        }
    }
}