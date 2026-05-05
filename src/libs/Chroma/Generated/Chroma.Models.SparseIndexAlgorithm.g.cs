
#nullable enable

namespace Chroma
{
    /// <summary>
    /// Sparse vector index algorithm.<br/>
    /// Controls which posting list format and query engine are used for<br/>
    /// sparse vector search within a collection.
    /// </summary>
    public enum SparseIndexAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        MaxScore,
        /// <summary>
        /// 
        /// </summary>
        Wand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SparseIndexAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SparseIndexAlgorithm value)
        {
            return value switch
            {
                SparseIndexAlgorithm.MaxScore => "max_score",
                SparseIndexAlgorithm.Wand => "wand",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SparseIndexAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "max_score" => SparseIndexAlgorithm.MaxScore,
                "wand" => SparseIndexAlgorithm.Wand,
                _ => null,
            };
        }
    }
}