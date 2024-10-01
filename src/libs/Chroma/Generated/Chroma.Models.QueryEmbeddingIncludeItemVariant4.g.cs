
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryEmbeddingIncludeItemVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Distances,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryEmbeddingIncludeItemVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryEmbeddingIncludeItemVariant4 value)
        {
            return value switch
            {
                QueryEmbeddingIncludeItemVariant4.Distances => "distances",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryEmbeddingIncludeItemVariant4? ToEnum(string value)
        {
            return value switch
            {
                "distances" => QueryEmbeddingIncludeItemVariant4.Distances,
                _ => null,
            };
        }
    }
}