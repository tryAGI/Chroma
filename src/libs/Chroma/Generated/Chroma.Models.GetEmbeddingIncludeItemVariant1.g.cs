
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEmbeddingIncludeItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Documents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEmbeddingIncludeItemVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEmbeddingIncludeItemVariant1 value)
        {
            return value switch
            {
                GetEmbeddingIncludeItemVariant1.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEmbeddingIncludeItemVariant1? ToEnum(string value)
        {
            return value switch
            {
                "documents" => GetEmbeddingIncludeItemVariant1.Documents,
                _ => null,
            };
        }
    }
}