
#nullable enable

namespace Fireworks
{
    /// <summary>
    /// Alignment model used for timestamps.<br/>
    /// Default Value: mms_fa
    /// </summary>
    public enum AlignmentModel
    {
        /// <summary>
        /// 
        /// </summary>
        MmsFa,
        /// <summary>
        /// 
        /// </summary>
        TdnnFfn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlignmentModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlignmentModel value)
        {
            return value switch
            {
                AlignmentModel.MmsFa => "mms_fa",
                AlignmentModel.TdnnFfn => "tdnn_ffn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlignmentModel? ToEnum(string value)
        {
            return value switch
            {
                "mms_fa" => AlignmentModel.MmsFa,
                "tdnn_ffn" => AlignmentModel.TdnnFfn,
                _ => null,
            };
        }
    }
}