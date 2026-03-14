
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Chroma
{
    /// <summary>
    /// Integer value type index configurations
    /// </summary>
    public sealed partial class IntValueType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("int_inverted_index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.IntInvertedIndexType>))]
        public global::Chroma.OneOf<object, global::Chroma.IntInvertedIndexType>? IntInvertedIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntValueType" /> class.
        /// </summary>
        /// <param name="intInvertedIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntValueType(
            global::Chroma.OneOf<object, global::Chroma.IntInvertedIndexType>? intInvertedIndex)
        {
            this.IntInvertedIndex = intInvertedIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntValueType" /> class.
        /// </summary>
        public IntValueType()
        {
        }
    }
}