#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Chroma.JsonConverters
{
    /// <inheritdoc />
    public class KeyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Chroma.Key>
    {
        /// <inheritdoc />
        public override global::Chroma.Key Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            var __score4 = 0;
            if (__jsonProps.Contains("MetadataField")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Chroma.KeyVariant1? value1 = default;
            global::Chroma.KeyVariant2? value2 = default;
            global::Chroma.KeyVariant3? value3 = default;
            global::Chroma.KeyVariant4? value4 = default;
            global::Chroma.KeyVariant5? value5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant1).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant2).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant3).Name}");
                        value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant4).Name}");
                        value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant5).Name}");
                        value5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null && value3 == null && value4 == null && value5 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant1).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant2).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant3).Name}");
                    value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant4).Name}");
                    value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant5).Name}");
                    value5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Chroma.Key(
                value1,

                value2,

                value3,

                value4,

                value5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Chroma.Key value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Chroma.KeyVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Chroma.KeyVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Chroma.KeyVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }
        }
    }
}