
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Chroma
{
    /// <summary>
    /// Float value type index configurations
    /// </summary>
    public sealed partial class FloatValueType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("float_inverted_index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.FloatInvertedIndexType>))]
        public global::Chroma.OneOf<object, global::Chroma.FloatInvertedIndexType>? FloatInvertedIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatValueType" /> class.
        /// </summary>
        /// <param name="floatInvertedIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FloatValueType(
            global::Chroma.OneOf<object, global::Chroma.FloatInvertedIndexType>? floatInvertedIndex)
        {
            this.FloatInvertedIndex = floatInvertedIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatValueType" /> class.
        /// </summary>
        public FloatValueType()
        {
        }
    }
}