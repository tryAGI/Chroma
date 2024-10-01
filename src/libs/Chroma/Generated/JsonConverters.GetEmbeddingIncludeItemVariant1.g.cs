#nullable enable

namespace Chroma.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetEmbeddingIncludeItemVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Chroma.GetEmbeddingIncludeItemVariant1>
    {
        /// <inheritdoc />
        public override global::Chroma.GetEmbeddingIncludeItemVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Chroma.GetEmbeddingIncludeItemVariant1Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Chroma.GetEmbeddingIncludeItemVariant1)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Chroma.GetEmbeddingIncludeItemVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Chroma.GetEmbeddingIncludeItemVariant1Extensions.ToValueString(value));
        }
    }
}
