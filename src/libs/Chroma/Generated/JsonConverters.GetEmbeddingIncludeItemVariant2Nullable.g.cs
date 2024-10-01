#nullable enable

namespace Chroma.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetEmbeddingIncludeItemVariant2NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Chroma.GetEmbeddingIncludeItemVariant2?>
    {
        /// <inheritdoc />
        public override global::Chroma.GetEmbeddingIncludeItemVariant2? Read(
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
                        return global::Chroma.GetEmbeddingIncludeItemVariant2Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Chroma.GetEmbeddingIncludeItemVariant2)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Chroma.GetEmbeddingIncludeItemVariant2? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Chroma.GetEmbeddingIncludeItemVariant2Extensions.ToValueString(value.Value));
            }
        }
    }
}
