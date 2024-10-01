#nullable enable

namespace Chroma.JsonConverters
{
    /// <inheritdoc />
    public sealed class QueryEmbeddingIncludeItemVariant2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Chroma.QueryEmbeddingIncludeItemVariant2>
    {
        /// <inheritdoc />
        public override global::Chroma.QueryEmbeddingIncludeItemVariant2 Read(
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
                        return global::Chroma.QueryEmbeddingIncludeItemVariant2Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Chroma.QueryEmbeddingIncludeItemVariant2)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Chroma.QueryEmbeddingIncludeItemVariant2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Chroma.QueryEmbeddingIncludeItemVariant2Extensions.ToValueString(value));
        }
    }
}
