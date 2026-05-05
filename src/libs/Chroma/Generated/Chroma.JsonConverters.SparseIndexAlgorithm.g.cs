#nullable enable

namespace Chroma.JsonConverters
{
    /// <inheritdoc />
    public sealed class SparseIndexAlgorithmJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Chroma.SparseIndexAlgorithm>
    {
        /// <inheritdoc />
        public override global::Chroma.SparseIndexAlgorithm Read(
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
                        return global::Chroma.SparseIndexAlgorithmExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Chroma.SparseIndexAlgorithm)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Chroma.SparseIndexAlgorithm);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Chroma.SparseIndexAlgorithm value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Chroma.SparseIndexAlgorithmExtensions.ToValueString(value));
        }
    }
}
