
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
        public global::Chroma.EmbeddingFunctionConfiguration? EmbeddingFunction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hnsw")]
        public global::Chroma.HnswConfiguration? Hnsw { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spann")]
        public global::Chroma.SpannConfiguration? Spann { get; set; }

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
            global::Chroma.EmbeddingFunctionConfiguration? embeddingFunction,
            global::Chroma.HnswConfiguration? hnsw,
            global::Chroma.SpannConfiguration? spann)
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