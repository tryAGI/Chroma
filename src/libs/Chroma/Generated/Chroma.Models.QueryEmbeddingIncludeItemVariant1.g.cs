
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryEmbeddingIncludeItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Documents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryEmbeddingIncludeItemVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryEmbeddingIncludeItemVariant1 value)
        {
            return value switch
            {
                QueryEmbeddingIncludeItemVariant1.Documents => "documents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryEmbeddingIncludeItemVariant1? ToEnum(string value)
        {
            return value switch
            {
                "documents" => QueryEmbeddingIncludeItemVariant1.Documents,
                _ => null,
            };
        }
    }
}