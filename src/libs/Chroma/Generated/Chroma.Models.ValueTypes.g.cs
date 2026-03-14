
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Chroma
{
    /// <summary>
    /// Strongly-typed value type configurations<br/>
    /// Contains optional configurations for each supported value type
    /// </summary>
    public sealed partial class ValueTypes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.BoolValueType>))]
        public global::Chroma.OneOf<object, global::Chroma.BoolValueType>? Bool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("float")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.FloatValueType>))]
        public global::Chroma.OneOf<object, global::Chroma.FloatValueType>? Float { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("float_list")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.FloatListValueType>))]
        public global::Chroma.OneOf<object, global::Chroma.FloatListValueType>? FloatList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("int")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.IntValueType>))]
        public global::Chroma.OneOf<object, global::Chroma.IntValueType>? Int { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_vector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.SparseVectorValueType>))]
        public global::Chroma.OneOf<object, global::Chroma.SparseVectorValueType>? SparseVector { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.StringValueType>))]
        public global::Chroma.OneOf<object, global::Chroma.StringValueType>? String { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueTypes" /> class.
        /// </summary>
        /// <param name="bool"></param>
        /// <param name="float"></param>
        /// <param name="floatList"></param>
        /// <param name="int"></param>
        /// <param name="sparseVector"></param>
        /// <param name="string"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValueTypes(
            global::Chroma.OneOf<object, global::Chroma.BoolValueType>? @bool,
            global::Chroma.OneOf<object, global::Chroma.FloatValueType>? @float,
            global::Chroma.OneOf<object, global::Chroma.FloatListValueType>? floatList,
            global::Chroma.OneOf<object, global::Chroma.IntValueType>? @int,
            global::Chroma.OneOf<object, global::Chroma.SparseVectorValueType>? sparseVector,
            global::Chroma.OneOf<object, global::Chroma.StringValueType>? @string)
        {
            this.Bool = @bool;
            this.Float = @float;
            this.FloatList = floatList;
            this.Int = @int;
            this.SparseVector = sparseVector;
            this.String = @string;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueTypes" /> class.
        /// </summary>
        public ValueTypes()
        {
        }
    }
}