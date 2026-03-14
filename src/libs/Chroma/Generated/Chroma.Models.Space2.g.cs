
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public enum Space2
    {
        /// <summary>
        /// 
        /// </summary>
        L2,
        /// <summary>
        /// 
        /// </summary>
        Cosine,
        /// <summary>
        /// 
        /// </summary>
        Ip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Space2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Space2 value)
        {
            return value switch
            {
                Space2.L2 => "l2",
                Space2.Cosine => "cosine",
                Space2.Ip => "ip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Space2? ToEnum(string value)
        {
            return value switch
            {
                "l2" => Space2.L2,
                "cosine" => Space2.Cosine,
                "ip" => Space2.Ip,
                _ => null,
            };
        }
    }
}