
#nullable enable

namespace Fireworks
{
    /// <summary>
    /// ASR model name.<br/>
    /// Default Value: whisper-v3
    /// </summary>
    public enum AudioModel
    {
        /// <summary>
        /// 
        /// </summary>
        WhisperV3,
        /// <summary>
        /// 
        /// </summary>
        WhisperV3Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioModel value)
        {
            return value switch
            {
                AudioModel.WhisperV3 => "whisper-v3",
                AudioModel.WhisperV3Turbo => "whisper-v3-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioModel? ToEnum(string value)
        {
            return value switch
            {
                "whisper-v3" => AudioModel.WhisperV3,
                "whisper-v3-turbo" => AudioModel.WhisperV3Turbo,
                _ => null,
            };
        }
    }
}