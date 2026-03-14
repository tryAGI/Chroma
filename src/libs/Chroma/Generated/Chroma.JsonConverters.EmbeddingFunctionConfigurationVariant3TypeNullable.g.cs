#nullable enable

namespace Chroma.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbeddingFunctionConfigurationVariant3TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Chroma.EmbeddingFunctionConfigurationVariant3Type?>
    {
        /// <inheritdoc />
        public override global::Chroma.EmbeddingFunctionConfigurationVariant3Type? Read(
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
                        return global::Chroma.EmbeddingFunctionConfigurationVariant3TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Chroma.EmbeddingFunctionConfigurationVariant3Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Chroma.EmbeddingFunctionConfigurationVariant3Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Chroma.EmbeddingFunctionConfigurationVariant3Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Chroma.EmbeddingFunctionConfigurationVariant3TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
