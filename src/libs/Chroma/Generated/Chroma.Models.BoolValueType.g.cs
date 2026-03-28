
#nullable enable

namespace Chroma
{
    /// <summary>
    /// Boolean value type index configurations
    /// </summary>
    public sealed partial class BoolValueType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bool_inverted_index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.BoolInvertedIndexType>))]
        public global::Chroma.OneOf<object, global::Chroma.BoolInvertedIndexType>? BoolInvertedIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BoolValueType" /> class.
        /// </summary>
        /// <param name="boolInvertedIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BoolValueType(
            global::Chroma.OneOf<object, global::Chroma.BoolInvertedIndexType>? boolInvertedIndex)
        {
            this.BoolInvertedIndex = boolInvertedIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoolValueType" /> class.
        /// </summary>
        public BoolValueType()
        {
        }
    }
}