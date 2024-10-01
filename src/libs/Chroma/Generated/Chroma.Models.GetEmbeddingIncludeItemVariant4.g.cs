
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEmbeddingIncludeItemVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Distances,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEmbeddingIncludeItemVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEmbeddingIncludeItemVariant4 value)
        {
            return value switch
            {
                GetEmbeddingIncludeItemVariant4.Distances => "distances",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEmbeddingIncludeItemVariant4? ToEnum(string value)
        {
            return value switch
            {
                "distances" => GetEmbeddingIncludeItemVariant4.Distances,
                _ => null,
            };
        }
    }
}