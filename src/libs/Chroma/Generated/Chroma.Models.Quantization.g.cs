
#nullable enable

namespace Chroma
{
    /// <summary>
    /// Quantization implementation for SPANN vector index.
    /// </summary>
    public enum Quantization
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        FourBitRabitQWithUSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QuantizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Quantization value)
        {
            return value switch
            {
                Quantization.None => "none",
                Quantization.FourBitRabitQWithUSearch => "four_bit_rabit_q_with_u_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Quantization? ToEnum(string value)
        {
            return value switch
            {
                "none" => Quantization.None,
                "four_bit_rabit_q_with_u_search" => Quantization.FourBitRabitQWithUSearch,
                _ => null,
            };
        }
    }
}