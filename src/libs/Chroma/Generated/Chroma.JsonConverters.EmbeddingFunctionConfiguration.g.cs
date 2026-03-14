#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Chroma.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingFunctionConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Chroma.EmbeddingFunctionConfiguration>
    {
        /// <inheritdoc />
        public override global::Chroma.EmbeddingFunctionConfiguration Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Chroma.EmbeddingFunctionConfigurationVariant1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.EmbeddingFunctionConfigurationVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.EmbeddingFunctionConfigurationVariant1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Chroma.EmbeddingFunctionConfigurationVariant3? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.EmbeddingFunctionConfigurationVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.EmbeddingFunctionConfigurationVariant3).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::Chroma.EmbeddingFunctionConfiguration(
                value1,

                value2,

                value3
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.EmbeddingFunctionConfigurationVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.EmbeddingFunctionConfigurationVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.EmbeddingFunctionConfigurationVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.EmbeddingFunctionConfigurationVariant3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Chroma.EmbeddingFunctionConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.EmbeddingFunctionConfigurationVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.EmbeddingFunctionConfigurationVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.AllOf<global::Chroma.EmbeddingFunctionNewConfiguration, global::Chroma.EmbeddingFunctionConfigurationVariant22>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.EmbeddingFunctionConfigurationVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.EmbeddingFunctionConfigurationVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.EmbeddingFunctionConfigurationVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
        }
    }
}