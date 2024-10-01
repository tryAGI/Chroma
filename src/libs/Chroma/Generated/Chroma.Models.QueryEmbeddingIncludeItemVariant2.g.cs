
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryEmbeddingIncludeItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Embeddings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryEmbeddingIncludeItemVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryEmbeddingIncludeItemVariant2 value)
        {
            return value switch
            {
                QueryEmbeddingIncludeItemVariant2.Embeddings => "embeddings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryEmbeddingIncludeItemVariant2? ToEnum(string value)
        {
            return value switch
            {
                "embeddings" => QueryEmbeddingIncludeItemVariant2.Embeddings,
                _ => null,
            };
        }
    }
}