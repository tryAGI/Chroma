
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

            typeof(global::Chroma.JsonConverters.SpaceJsonConverter),

            typeof(global::Chroma.JsonConverters.SpaceNullableJsonConverter),

            typeof(global::Chroma.JsonConverters.SparseIndexAlgorithmJsonConverter),

            typeof(global::Chroma.JsonConverters.SparseIndexAlgorithmNullableJsonConverter),

            typeof(global::Chroma.JsonConverters.DeleteCollectionRecordsPayloadJsonConverter),

            typeof(global::Chroma.JsonConverters.EmbeddingFunctionConfigurationJsonConverter),

            typeof(global::Chroma.JsonConverters.EmbeddingsPayloadJsonConverter),

            typeof(global::Chroma.JsonConverters.GetRequestPayloadJsonConverter),

            typeof(global::Chroma.JsonConverters.KeyJsonConverter),

            typeof(global::Chroma.JsonConverters.QueryRequestPayloadJsonConverter),

            typeof(global::Chroma.JsonConverters.UpdateEmbeddingsPayloadJsonConverter),

            typeof(global::Chroma.JsonConverters.AllOfJsonConverter<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>),

            typeof(global::Chroma.JsonConverters.OneOfJsonConverter<bool?, long?, double?, string, global::Chroma.SparseVector, global::System.Collections.Generic.IList<bool>, global::System.Collections.Generic.IList<long>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Chroma.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AddCollectionRecordsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingsPayload), TypeInfoPropertyName = "EmbeddingsPayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Chroma.HashMap?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.HashMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AddCollectionRecordsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AttachFunctionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AttachFunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AttachedFunctionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AttachedFunctionApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.BoolInvertedIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.BoolInvertedIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.BoolValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.ChecklistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Collection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.CollectionConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Schema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.HnswConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SpannConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.CreateCollectionPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.CreateDatabasePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.CreateDatabaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.CreateTenantPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.CreateTenantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Database))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.DeleteCollectionRecordsPayload), TypeInfoPropertyName = "DeleteCollectionRecordsPayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.RawWhereFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.DeleteCollectionRecordsPayloadVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.DeleteCollectionRecordsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.DeleteCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.DeleteDatabaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.DetachFunctionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.DetachFunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant1Type), TypeInfoPropertyName = "EmbeddingFunctionConfigurationVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>), TypeInfoPropertyName = "AllOfEmbeddingFunctionNewConfigurationEmbeddingFunctionConfigurationVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionNewConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant2Type), TypeInfoPropertyName = "EmbeddingFunctionConfigurationVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant3Type), TypeInfoPropertyName = "EmbeddingFunctionConfigurationVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>), TypeInfoPropertyName = "IListIListSingle_System_Collections_Generic_IList_global_System_Collections_Generic_IList_float")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>), TypeInfoPropertyName = "IListSingle_System_Collections_Generic_IList_float")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.FloatInvertedIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.FloatInvertedIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.FloatListValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.VectorIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.FloatValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.ForkCollectionPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.ForkCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.FtsIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.FtsIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.GetAttachedFunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.GetRequestPayload), TypeInfoPropertyName = "GetRequestPayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.GetRequestPayloadVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Chroma.Include>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.GetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Include), TypeInfoPropertyName = "Include2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.GetTenantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.GetUserIdentityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<bool?, long?, double?, string, global::Chroma.SparseVector, global::System.Collections.Generic.IList<bool>, global::System.Collections.Generic.IList<long>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfBooleanInt64DoubleStringSparseVectorIListBooleanIListInt64IListDoubleIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SparseVector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.HeartbeatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Space), TypeInfoPropertyName = "Space2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.HnswIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.IndexStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.IntInvertedIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.IntInvertedIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.IntValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Key), TypeInfoPropertyName = "Key2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.KeyVariant1), TypeInfoPropertyName = "KeyVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.KeyVariant2), TypeInfoPropertyName = "KeyVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.KeyVariant3), TypeInfoPropertyName = "KeyVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.KeyVariant4), TypeInfoPropertyName = "KeyVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.KeyVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.Quantization), TypeInfoPropertyName = "Quantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.QueryRequestPayload), TypeInfoPropertyName = "QueryRequestPayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.QueryRequestPayloadVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.QueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float?>>), TypeInfoPropertyName = "IListIListSingle_System_Collections_Generic_IList_global_System_Collections_Generic_IList_float_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float?>), TypeInfoPropertyName = "IListSingle_System_Collections_Generic_IList_float_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string?>>), TypeInfoPropertyName = "IListIListString_System_Collections_Generic_IList_global_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>?>>), TypeInfoPropertyName = "IList_float_f9b521f5e6b0e125")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>?>), TypeInfoPropertyName = "IListIListSingle_System_Collections_Generic_IList_global_System_Collections_Generic_IList_float_4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "IListIListString_System_Collections_Generic_IList_global_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Chroma.HashMap?>>), TypeInfoPropertyName = "IListIListHashMap_System_Collections_Generic_IList_global_System_Collections_Generic_IList_global_Chroma_HashMap")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.ReadLevel), TypeInfoPropertyName = "ReadLevel2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string?>?>), TypeInfoPropertyName = "IListIListString_System_Collections_Generic_IList_global_System_Collections_Generic_IList_string_4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>?>?>), TypeInfoPropertyName = "IList_float_f184b748c9245cca")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Chroma.HashMap?>?>), TypeInfoPropertyName = "IListIListHashMap_System_Collections_Generic_IList_global_System_Collections_Generic_IList_global_Chroma_HashMap_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float?>?>), TypeInfoPropertyName = "IListIListSingle_System_Collections_Generic_IList_global_System_Collections_Generic_IList_float_5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Chroma.Key>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Chroma.Key>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SpannIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SparseIndexAlgorithm), TypeInfoPropertyName = "SparseIndexAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SparseVectorIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SparseVectorIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.SparseVectorValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.StringInvertedIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.StringInvertedIndexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.StringValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateCollectionConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateHnswConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateSpannConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateCollectionPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateCollectionRecordsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateEmbeddingsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateCollectionRecordsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateTenantPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpdateTenantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpsertCollectionRecordsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.UpsertCollectionRecordsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Chroma.VecItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.VecItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.VectorIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Chroma.Database>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Chroma.HashMap?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>), TypeInfoPropertyName = "ListListSingle_System_Collections_Generic_List_global_System_Collections_Generic_List_float")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>), TypeInfoPropertyName = "ListSingle_System_Collections_Generic_List_float")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Chroma.Include>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.OneOf<bool?, long?, double?, string, global::Chroma.SparseVector, global::System.Collections.Generic.List<bool>, global::System.Collections.Generic.List<long>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<float?>>), TypeInfoPropertyName = "ListListSingle_System_Collections_Generic_List_global_System_Collections_Generic_List_float_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float?>), TypeInfoPropertyName = "ListSingle_System_Collections_Generic_List_float_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string?>>), TypeInfoPropertyName = "ListListString_System_Collections_Generic_List_global_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>?>>), TypeInfoPropertyName = "List_float_1999e098a7369f5e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>?>), TypeInfoPropertyName = "ListListSingle_System_Collections_Generic_List_global_System_Collections_Generic_List_float_4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>), TypeInfoPropertyName = "ListListString_System_Collections_Generic_List_global_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Chroma.HashMap?>>), TypeInfoPropertyName = "ListListHashMap_System_Collections_Generic_List_global_System_Collections_Generic_List_global_Chroma_HashMap")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Chroma.SearchPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string?>?>), TypeInfoPropertyName = "ListListString_System_Collections_Generic_List_global_System_Collections_Generic_List_string_4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>?>?>), TypeInfoPropertyName = "List_float_36e16dcf0d3b5792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Chroma.HashMap?>?>), TypeInfoPropertyName = "ListListHashMap_System_Collections_Generic_List_global_System_Collections_Generic_List_global_Chroma_HashMap_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<float?>?>), TypeInfoPropertyName = "ListListSingle_System_Collections_Generic_List_global_System_Collections_Generic_List_float_5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Chroma.Key>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Chroma.Key>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Chroma.VecItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Chroma.Database>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}