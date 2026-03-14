
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Chroma
{
    /// <summary>
    /// String value type index configurations
    /// </summary>
    public sealed partial class StringValueType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fts_index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.FtsIndexType>))]
        public global::Chroma.OneOf<object, global::Chroma.FtsIndexType>? FtsIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string_inverted_index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.StringInvertedIndexType>))]
        public global::Chroma.OneOf<object, global::Chroma.StringInvertedIndexType>? StringInvertedIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StringValueType" /> class.
        /// </summary>
        /// <param name="ftsIndex"></param>
        /// <param name="stringInvertedIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StringValueType(
            global::Chroma.OneOf<object, global::Chroma.FtsIndexType>? ftsIndex,
            global::Chroma.OneOf<object, global::Chroma.StringInvertedIndexType>? stringInvertedIndex)
        {
            this.FtsIndex = ftsIndex;
            this.StringInvertedIndex = stringInvertedIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringValueType" /> class.
        /// </summary>
        public StringValueType()
        {
        }
    }
}