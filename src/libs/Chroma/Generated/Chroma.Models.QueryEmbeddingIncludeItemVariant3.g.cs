
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryEmbeddingIncludeItemVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Metadatas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryEmbeddingIncludeItemVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryEmbeddingIncludeItemVariant3 value)
        {
            return value switch
            {
                QueryEmbeddingIncludeItemVariant3.Metadatas => "metadatas",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryEmbeddingIncludeItemVariant3? ToEnum(string value)
        {
            return value switch
            {
                "metadatas" => QueryEmbeddingIncludeItemVariant3.Metadatas,
                _ => null,
            };
        }
    }
}