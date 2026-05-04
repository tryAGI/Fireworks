
#nullable enable

namespace Fireworks
{
    /// <summary>
    /// Voice activity detection model.<br/>
    /// Default Value: silero
    /// </summary>
    public enum VadModel
    {
        /// <summary>
        /// 
        /// </summary>
        Silero,
        /// <summary>
        /// 
        /// </summary>
        WhisperxPyannet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VadModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VadModel value)
        {
            return value switch
            {
                VadModel.Silero => "silero",
                VadModel.WhisperxPyannet => "whisperx-pyannet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VadModel? ToEnum(string value)
        {
            return value switch
            {
                "silero" => VadModel.Silero,
                "whisperx-pyannet" => VadModel.WhisperxPyannet,
                _ => null,
            };
        }
    }
}