
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
            typeof(global::Chroma.JsonConverters.QuantizationJsonConverter),
            typeof(global::Chroma.JsonConverters.QuantizationNullableJsonConverter),
            typeof(global::Chroma.JsonConverters.ReadLevelJsonConverter),
            typeof(global::Chroma.JsonConverters.ReadLevelNullableJsonConverter),
            typeof(global::Chroma.JsonConverters.Space2JsonConverter),
            typeof(global::Chroma.JsonConverters.Space2NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.DeleteCollectionRecordsPayloadJsonConverter),
            typeof(global::Chroma.JsonConverters.EmbeddingFunctionConfigurationJsonConverter),
            typeof(global::Chroma.JsonConverters.EmbeddingsPayloadJsonConverter),
            typeof(global::Chroma.JsonConverters.GetRequestPayloadJsonConverter),
            typeof(global::Chroma.JsonConverters.KeyJsonConverter),
            typeof(global::Chroma.JsonConverters.QueryRequestPayloadJsonConverter),
            typeof(global::Chroma.JsonConverters.UpdateEmbeddingsPayloadJsonConverter),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::System.Guid?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.BoolInvertedIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Schema3>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.EmbeddingFunctionConfiguration?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.HnswConfiguration>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.SpannConfiguration>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.CollectionConfiguration>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Schema3>),
            typeof(global::Chroma.JsonConverters.AllOfJsonConverter<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.VectorIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.FloatInvertedIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<bool?, long?, double?, string, global::Chroma.SparseVector, global::System.Collections.Generic.IList<bool>, global::System.Collections.Generic.IList<long>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<string>>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Space2?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.IntInvertedIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Space2?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.EmbeddingFunctionConfiguration?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.SparseVectorIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.FtsIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.StringInvertedIndexType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.EmbeddingFunctionConfiguration?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.UpdateHnswConfiguration>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.UpdateSpannConfiguration>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.UpdateCollectionConfiguration>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.UpdateEmbeddingsPayload?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.BoolValueType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.FloatValueType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.FloatListValueType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.IntValueType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.SparseVectorValueType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.StringValueType>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Schema3>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.EmbeddingFunctionConfiguration?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.HnswIndexConfig>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.Space2?>),
            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.SpannIndexConfig>),
            typeof(global::Chroma.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AddCollectionRecordsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AttachFunctionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AttachFunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AttachedFunctionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AttachedFunctionApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::System.Guid?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.BoolInvertedIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.BoolInvertedIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.BoolValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.BoolInvertedIndexType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.ChecklistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Collection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.CollectionConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.Schema3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Schema3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.EmbeddingFunctionConfiguration?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.HnswConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.HnswConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.SpannConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SpannConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.CreateCollectionPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.CollectionConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.CreateDatabasePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.CreateTenantPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Database))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.DeleteCollectionRecordsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.RawWhereFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.DeleteCollectionRecordsPayloadVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.DeleteCollectionRecordsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.DetachFunctionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.DetachFunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionNewConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant3Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.FloatInvertedIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.FloatInvertedIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.FloatListValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.VectorIndexType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.VectorIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.FloatValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.FloatInvertedIndexType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.ForkCollectionPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.FtsIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.FtsIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.GetAttachedFunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.GetRequestPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.GetRequestPayloadVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Chroma.Include>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.GetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Include))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.GetTenantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.GetUserIdentityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<bool?, long?, double?, string, global::Chroma.SparseVector, global::System.Collections.Generic.IList<bool>, global::System.Collections.Generic.IList<long>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SparseVector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.HeartbeatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.Space2?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Space2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.HnswIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.IndexStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.IntInvertedIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.IntInvertedIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.IntValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.IntInvertedIndexType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Key))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.KeyVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.KeyVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.KeyVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.KeyVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.KeyVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Quantization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.QueryRequestPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.QueryRequestPayloadVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.QueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.ReadLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.ValueTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Chroma.ValueTypes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SearchPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SearchPayloadFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SearchPayloadGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SearchPayloadLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SearchPayloadSelect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SearchRequestPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Chroma.SearchPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Chroma.Key>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Chroma.Key>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SpannIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SparseVectorIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SparseVectorIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SparseVectorValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.SparseVectorIndexType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.StringInvertedIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.StringInvertedIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.StringValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.FtsIndexType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.StringInvertedIndexType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateCollectionConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.UpdateHnswConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateHnswConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.UpdateSpannConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateSpannConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateCollectionPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.UpdateCollectionConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateCollectionRecordsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.UpdateEmbeddingsPayload?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateEmbeddingsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateTenantPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpsertCollectionRecordsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.BoolValueType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.FloatValueType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.FloatListValueType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.IntValueType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.SparseVectorValueType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.StringValueType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Chroma.VecItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.VecItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.VectorIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.HnswIndexConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<object, global::Chroma.SpannIndexConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Chroma.Include>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<bool?, long?, double?, string, global::Chroma.SparseVector, global::System.Collections.Generic.List<bool>, global::System.Collections.Generic.List<long>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Chroma.SearchPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Chroma.Key>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Chroma.Key>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Chroma.VecItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}