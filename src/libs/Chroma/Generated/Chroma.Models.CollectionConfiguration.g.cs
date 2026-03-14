
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionConfiguration
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.HnswConfiguration>))]
        public global::Chroma.OneOf<object, global::Chroma.HnswConfiguration>? Hnsw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spann")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.SpannConfiguration>))]
        public global::Chroma.OneOf<object, global::Chroma.SpannConfiguration>? Spann { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionConfiguration" /> class.
        /// </summary>
        /// <param name="embeddingFunction"></param>
        /// <param name="hnsw"></param>
        /// <param name="spann"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionConfiguration(
            global::Chroma.OneOf<object, global::Chroma.EmbeddingFunctionConfiguration?>? embeddingFunction,
            global::Chroma.OneOf<object, global::Chroma.HnswConfiguration>? hnsw,
            global::Chroma.OneOf<object, global::Chroma.SpannConfiguration>? spann)
        {
            this.EmbeddingFunction = embeddingFunction;
            this.Hnsw = hnsw;
            this.Spann = spann;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionConfiguration" /> class.
        /// </summary>
        public CollectionConfiguration()
        {
        }
    }
}