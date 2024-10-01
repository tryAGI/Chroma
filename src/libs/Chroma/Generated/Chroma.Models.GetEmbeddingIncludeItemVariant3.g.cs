
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEmbeddingIncludeItemVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Metadatas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEmbeddingIncludeItemVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEmbeddingIncludeItemVariant3 value)
        {
            return value switch
            {
                GetEmbeddingIncludeItemVariant3.Metadatas => "metadatas",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEmbeddingIncludeItemVariant3? ToEnum(string value)
        {
            return value switch
            {
                "metadatas" => GetEmbeddingIncludeItemVariant3.Metadatas,
                _ => null,
            };
        }
    }
}