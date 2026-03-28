
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorIndexConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_function")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.EmbeddingFunctionConfiguration?>))]
        public global::Chroma.OneOf<object, global::Chroma.EmbeddingFunctionConfiguration?>? EmbeddingFunction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hnsw")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.HnswIndexConfig>))]
        public global::Chroma.OneOf<object, global::Chroma.HnswIndexConfig>? Hnsw { get; set; }

        /// <summary>
        /// Key to source the vector from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_key")]
        public string? SourceKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Space2?>))]
        public global::Chroma.OneOf<object, global::Chroma.Space2?>? Space { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spann")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.SpannIndexConfig>))]
        public global::Chroma.OneOf<object, global::Chroma.SpannIndexConfig>? Spann { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorIndexConfig" /> class.
        /// </summary>
        /// <param name="embeddingFunction"></param>
        /// <param name="hnsw"></param>
        /// <param name="sourceKey">
        /// Key to source the vector from
        /// </param>
        /// <param name="space"></param>
        /// <param name="spann"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorIndexConfig(
            global::Chroma.OneOf<object, global::Chroma.EmbeddingFunctionConfiguration?>? embeddingFunction,
            global::Chroma.OneOf<object, global::Chroma.HnswIndexConfig>? hnsw,
            string? sourceKey,
            global::Chroma.OneOf<object, global::Chroma.Space2?>? space,
            global::Chroma.OneOf<object, global::Chroma.SpannIndexConfig>? spann)
        {
            this.EmbeddingFunction = embeddingFunction;
            this.Hnsw = hnsw;
            this.SourceKey = sourceKey;
            this.Space = space;
            this.Spann = spann;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorIndexConfig" /> class.
        /// </summary>
        public VectorIndexConfig()
        {
        }
    }
}