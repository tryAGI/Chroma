
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEmbeddingIncludeItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Embeddings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEmbeddingIncludeItemVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEmbeddingIncludeItemVariant2 value)
        {
            return value switch
            {
                GetEmbeddingIncludeItemVariant2.Embeddings => "embeddings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEmbeddingIncludeItemVariant2? ToEnum(string value)
        {
            return value switch
            {
                "embeddings" => GetEmbeddingIncludeItemVariant2.Embeddings,
                _ => null,
            };
        }
    }
}