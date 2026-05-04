
#nullable enable

namespace Fireworks
{
    /// <summary>
    /// Task performed by the API.
    /// </summary>
    public enum AudioResponseTask
    {
        /// <summary>
        /// 
        /// </summary>
        Transcribe,
        /// <summary>
        /// 
        /// </summary>
        Translate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioResponseTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioResponseTask value)
        {
            return value switch
            {
                AudioResponseTask.Transcribe => "transcribe",
                AudioResponseTask.Translate => "translate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioResponseTask? ToEnum(string value)
        {
            return value switch
            {
                "transcribe" => AudioResponseTask.Transcribe,
                "translate" => AudioResponseTask.Translate,
                _ => null,
            };
        }
    }
}