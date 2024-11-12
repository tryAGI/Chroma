
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>>> Embeddings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Documents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadatas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>> Metadatas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Distances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResult" /> class.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="embeddings"></param>
        /// <param name="documents"></param>
        /// <param name="metadatas"></param>
        /// <param name="distances"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public QueryResult(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> ids,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Chroma.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>>> embeddings,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> documents,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>> metadatas,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> distances)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.Embeddings = embeddings ?? throw new global::System.ArgumentNullException(nameof(embeddings));
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.Metadatas = metadatas ?? throw new global::System.ArgumentNullException(nameof(metadatas));
            this.Distances = distances ?? throw new global::System.ArgumentNullException(nameof(distances));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResult" /> class.
        /// </summary>
        public QueryResult()
        {
        }
    }
}