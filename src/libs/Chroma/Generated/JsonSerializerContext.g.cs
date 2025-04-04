
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
            typeof(global::Chroma.JsonConverters.GetEmbeddingIncludeItemVariant1JsonConverter),
            typeof(global::Chroma.JsonConverters.GetEmbeddingIncludeItemVariant1NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.GetEmbeddingIncludeItemVariant2JsonConverter),
            typeof(global::Chroma.JsonConverters.GetEmbeddingIncludeItemVariant2NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.GetEmbeddingIncludeItemVariant3JsonConverter),
            typeof(global::Chroma.JsonConverters.GetEmbeddingIncludeItemVariant3NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.GetEmbeddingIncludeItemVariant4JsonConverter),
            typeof(global::Chroma.JsonConverters.GetEmbeddingIncludeItemVariant4NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.QueryEmbeddingIncludeItemVariant1JsonConverter),
            typeof(global::Chroma.JsonConverters.QueryEmbeddingIncludeItemVariant1NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.QueryEmbeddingIncludeItemVariant2JsonConverter),
            typeof(global::Chroma.JsonConverters.QueryEmbeddingIncludeItemVariant2NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.QueryEmbeddingIncludeItemVariant3JsonConverter),
            typeof(global::Chroma.JsonConverters.QueryEmbeddingIncludeItemVariant3NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.QueryEmbeddingIncludeItemVariant4JsonConverter),
            typeof(global::Chroma.JsonConverters.QueryEmbeddingIncludeItemVariant4NullableJsonConverter),
            typeof(global::Chroma.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>),
            typeof(global::Chroma.JsonConverters.AnyOfJsonConverter<string, int?, float?, bool?>),
            typeof(global::Chroma.JsonConverters.AnyOfJsonConverter<global::Chroma.GetEmbeddingIncludeItemVariant1?, global::Chroma.GetEmbeddingIncludeItemVariant2?, global::Chroma.GetEmbeddingIncludeItemVariant3?, global::Chroma.GetEmbeddingIncludeItemVariant4?>),
            typeof(global::Chroma.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>),
            typeof(global::Chroma.JsonConverters.AnyOfJsonConverter<string, int?>),
            typeof(global::Chroma.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>),
            typeof(global::Chroma.JsonConverters.AnyOfJsonConverter<global::Chroma.QueryEmbeddingIncludeItemVariant1?, global::Chroma.QueryEmbeddingIncludeItemVariant2?, global::Chroma.QueryEmbeddingIncludeItemVariant3?, global::Chroma.QueryEmbeddingIncludeItemVariant4?>),
            typeof(global::Chroma.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>),
            typeof(global::Chroma.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>),
            typeof(global::Chroma.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}