
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Chroma.JsonConverters.EmbeddingFunctionConfigurationVariant1TypeJsonConverter),
            typeof(global::Chroma.JsonConverters.EmbeddingFunctionConfigurationVariant1TypeNullableJsonConverter),
            typeof(global::Chroma.JsonConverters.EmbeddingFunctionConfigurationVariant2TypeJsonConverter),
            typeof(global::Chroma.JsonConverters.EmbeddingFunctionConfigurationVariant2TypeNullableJsonConverter),
            typeof(global::Chroma.JsonConverters.EmbeddingFunctionConfigurationVariant3TypeJsonConverter),
            typeof(global::Chroma.JsonConverters.EmbeddingFunctionConfigurationVariant3TypeNullableJsonConverter),
            typeof(global::Chroma.JsonConverters.Space2JsonConverter),
            typeof(global::Chroma.JsonConverters.Space2NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.QuantizationJsonConverter),
            typeof(global::Chroma.JsonConverters.QuantizationNullableJsonConverter),
            typeof(global::Chroma.JsonConverters.IncludeJsonConverter),
            typeof(global::Chroma.JsonConverters.IncludeNullableJsonConverter),
            typeof(global::Chroma.JsonConverters.KeyVariant1JsonConverter),
            typeof(global::Chroma.JsonConverters.KeyVariant1NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.KeyVariant2JsonConverter),
            typeof(global::Chroma.JsonConverters.KeyVariant2NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.KeyVariant3JsonConverter),
            typeof(global::Chroma.JsonConverters.KeyVariant3NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.KeyVariant4JsonConverter),
            typeof(global::Chroma.JsonConverters.KeyVariant4NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.ReadLevelJsonConverter),
            typeof(global::Chroma.JsonConverters.ReadLevelNullableJsonConverter),
            typeof(global::Chroma.JsonConverters.EmbeddingsPayloadJsonConverter),
            typeof(global::Chroma.JsonConverters.EmbeddingFunctionConfigurationJsonConverter),
            typeof(global::Chroma.JsonConverters.DeleteCollectionRecordsPayloadJsonConverter),
            typeof(global::Chroma.JsonConverters.GetRequestPayloadJsonConverter),
            typeof(global::Chroma.JsonConverters.KeyJsonConverter),
            typeof(global::Chroma.JsonConverters.QueryRequestPayloadJsonConverter),
            typeof(global::Chroma.JsonConverters.UpdateEmbeddingsPayloadJsonConverter),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<bool?, long?, double?, string, global::Chroma.SparseVector, global::System.Collections.Generic.IList<bool>, global::System.Collections.Generic.IList<long>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<string>>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::System.Guid?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.BoolInvertedIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.EmbeddingFunctionConfiguration?>),
            typeof(global::Chroma.JsonConverters.AllOfJsonConverter<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.HnswConfiguration>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Space2?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.SpannConfiguration>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Space2?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Schema3>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.BoolValueType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.FloatValueType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.FloatInvertedIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.FloatListValueType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.VectorIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.EmbeddingFunctionConfiguration?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.HnswIndexConfig>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Space2?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.SpannIndexConfig>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.IntValueType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.IntInvertedIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.SparseVectorValueType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.SparseVectorIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.EmbeddingFunctionConfiguration?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.StringValueType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.FtsIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.StringInvertedIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.CollectionConfiguration>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Schema3>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.EmbeddingFunctionConfiguration?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.UpdateHnswConfiguration>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.UpdateSpannConfiguration>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.UpdateCollectionConfiguration>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.UpdateEmbeddingsPayload?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Schema3>),
            typeof(global::Chroma.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}