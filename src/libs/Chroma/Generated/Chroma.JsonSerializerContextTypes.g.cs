
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.AddCollectionRecordsPayload? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingsPayload? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.AttachFunctionRequest? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.AttachFunctionResponse? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.AttachedFunctionInfo? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.AttachedFunctionApiResponse? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::System.Guid?>? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.BoolInvertedIndexConfig? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.BoolInvertedIndexType? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.BoolValueType? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.BoolInvertedIndexType>? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.ChecklistResponse? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Collection? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.CollectionConfiguration? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.Schema3>? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Schema3? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.EmbeddingFunctionConfiguration?>? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfiguration? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.HnswConfiguration>? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.HnswConfiguration? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.SpannConfiguration>? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SpannConfiguration? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.CreateCollectionPayload? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.CollectionConfiguration>? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.CreateDatabasePayload? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.CreateTenantPayload? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Database? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.DeleteCollectionRecordsPayload? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.RawWhereFields? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.DeleteCollectionRecordsPayloadVariant2? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.DeleteCollectionRecordsResponse? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.DetachFunctionRequest? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.DetachFunctionResponse? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfigurationVariant1? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfigurationVariant1Type? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionNewConfiguration? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfigurationVariant22? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfigurationVariant2Type? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfigurationVariant3? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfigurationVariant3Type? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.ErrorResponse? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.FloatInvertedIndexConfig? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.FloatInvertedIndexType? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.FloatListValueType? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.VectorIndexType>? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.VectorIndexType? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.FloatValueType? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.FloatInvertedIndexType>? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.ForkCollectionPayload? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.FtsIndexConfig? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.FtsIndexType? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.GetAttachedFunctionResponse? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.GetRequestPayload? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.GetRequestPayloadVariant2? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Chroma.Include>? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.GetResponse? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Include? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.GetTenantResponse? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.GetUserIdentityResponse? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<bool?, long?, double?, string, global::Chroma.SparseVector, global::System.Collections.Generic.IList<bool>, global::System.Collections.Generic.IList<long>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<string>>? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SparseVector? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<bool>? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.HeartbeatResponse? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.Space2?>? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Space2? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.HnswIndexConfig? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.IndexStatusResponse? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.IntInvertedIndexConfig? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.IntInvertedIndexType? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.IntValueType? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.IntInvertedIndexType>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Key? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.KeyVariant1? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.KeyVariant2? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.KeyVariant3? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.KeyVariant4? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.KeyVariant5? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Quantization? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.QueryRequestPayload? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.QueryRequestPayloadVariant2? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.QueryResponse? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.ReadLevel? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.ValueTypes? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Chroma.ValueTypes>? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchPayload? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchPayloadFilter? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchPayloadGroupBy? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchPayloadLimit? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchPayloadSelect? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchRequestPayload? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Chroma.SearchPayload>? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchResponse? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Chroma.Key>>? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Chroma.Key>? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SpannIndexConfig? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SparseVectorIndexConfig? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SparseVectorIndexType? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SparseVectorValueType? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.SparseVectorIndexType>? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.StringInvertedIndexConfig? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.StringInvertedIndexType? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.StringValueType? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.FtsIndexType>? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.StringInvertedIndexType>? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateCollectionConfiguration? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.UpdateHnswConfiguration>? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateHnswConfiguration? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.UpdateSpannConfiguration>? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateSpannConfiguration? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateCollectionPayload? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.UpdateCollectionConfiguration>? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateCollectionRecordsPayload? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.UpdateEmbeddingsPayload?>? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateEmbeddingsPayload? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateTenantPayload? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpsertCollectionRecordsPayload? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.BoolValueType>? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.FloatValueType>? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.FloatListValueType>? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.IntValueType>? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.SparseVectorValueType>? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.StringValueType>? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Chroma.VecItem>? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.VecItem? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.VectorIndexConfig? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.HnswIndexConfig>? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.SpannIndexConfig>? Type145 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Chroma.Include>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<bool?, long?, double?, string, global::Chroma.SparseVector, global::System.Collections.Generic.List<bool>, global::System.Collections.Generic.List<long>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<string>>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<bool>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Chroma.SearchPayload>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Chroma.Key>>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Chroma.Key>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Chroma.VecItem>? ListType16 { get; set; }
    }
}