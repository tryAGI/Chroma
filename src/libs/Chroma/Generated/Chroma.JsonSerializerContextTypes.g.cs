
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
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<bool?, long?, double?, string, global::Chroma.SparseVector, global::System.Collections.Generic.IList<bool>, global::System.Collections.Generic.IList<long>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<string>>? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SparseVector? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<bool>? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.AttachFunctionRequest? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.AttachFunctionResponse? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.AttachedFunctionInfo? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.AttachedFunctionApiResponse? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::System.Guid?>? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.BoolInvertedIndexConfig? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.BoolInvertedIndexType? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.BoolValueType? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.BoolInvertedIndexType>? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.ChecklistResponse? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Collection? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.CollectionConfiguration? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.EmbeddingFunctionConfiguration?>? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfiguration? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfigurationVariant1? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfigurationVariant1Type? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionNewConfiguration? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfigurationVariant22? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfigurationVariant2Type? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfigurationVariant3? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.EmbeddingFunctionConfigurationVariant3Type? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.HnswConfiguration>? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.HnswConfiguration? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.Space2?>? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Space2? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.SpannConfiguration>? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SpannConfiguration? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.Schema3>? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Schema3? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.ValueTypes? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.BoolValueType>? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.FloatValueType>? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.FloatValueType? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.FloatInvertedIndexType>? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.FloatInvertedIndexType? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.FloatInvertedIndexConfig? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.FloatListValueType>? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.FloatListValueType? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.VectorIndexType>? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.VectorIndexType? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.VectorIndexConfig? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.HnswIndexConfig>? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.HnswIndexConfig? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.SpannIndexConfig>? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SpannIndexConfig? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Quantization? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.IntValueType>? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.IntValueType? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.IntInvertedIndexType>? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.IntInvertedIndexType? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.IntInvertedIndexConfig? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.SparseVectorValueType>? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SparseVectorValueType? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.SparseVectorIndexType>? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SparseVectorIndexType? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SparseVectorIndexConfig? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.StringValueType>? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.StringValueType? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.FtsIndexType>? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.FtsIndexType? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.FtsIndexConfig? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.StringInvertedIndexType>? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.StringInvertedIndexType? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.StringInvertedIndexConfig? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Chroma.ValueTypes>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.CreateCollectionPayload? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.CollectionConfiguration>? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.CreateDatabasePayload? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.CreateTenantPayload? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Database? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.DeleteCollectionRecordsPayload? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.RawWhereFields? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.DeleteCollectionRecordsPayloadVariant2? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.DeleteCollectionRecordsResponse? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.DetachFunctionRequest? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.DetachFunctionResponse? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.ErrorResponse? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.ForkCollectionPayload? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.GetAttachedFunctionResponse? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.GetRequestPayload? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.GetRequestPayloadVariant2? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Chroma.Include>? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Include? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.GetResponse? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.GetTenantResponse? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.GetUserIdentityResponse? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.HeartbeatResponse? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.IndexStatusResponse? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.Key? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.KeyVariant1? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.KeyVariant2? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.KeyVariant3? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.KeyVariant4? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.KeyVariant5? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.QueryRequestPayload? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.QueryRequestPayloadVariant2? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.QueryResponse? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.ReadLevel? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchPayload? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchPayloadFilter? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchPayloadGroupBy? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchPayloadLimit? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchPayloadSelect? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchRequestPayload? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Chroma.SearchPayload>? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.SearchResponse? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Chroma.Key>>? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Chroma.Key>? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateCollectionConfiguration? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.UpdateHnswConfiguration>? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateHnswConfiguration? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.UpdateSpannConfiguration>? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateSpannConfiguration? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateCollectionPayload? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.UpdateCollectionConfiguration>? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateCollectionRecordsPayload? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<object, global::Chroma.UpdateEmbeddingsPayload?>? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateEmbeddingsPayload? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpdateTenantPayload? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.UpsertCollectionRecordsPayload? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Chroma.VecItem>? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.VecItem? Type145 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Chroma.OneOf<bool?, long?, double?, string, global::Chroma.SparseVector, global::System.Collections.Generic.List<bool>, global::System.Collections.Generic.List<long>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<string>>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType5 { get; set; }
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
        public global::System.Collections.Generic.List<global::Chroma.Include>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Chroma.SearchPayload>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Chroma.Key>>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Chroma.Key>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Chroma.VecItem>? ListType16 { get; set; }
    }
}