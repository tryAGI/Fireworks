
#nullable enable

namespace Fireworks
{
    /// <summary>
    /// Response format requested from the API.<br/>
    /// Default Value: json
    /// </summary>
    public enum ResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        VerboseJson,
        /// <summary>
        /// 
        /// </summary>
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormat value)
        {
            return value switch
            {
                ResponseFormat.Json => "json",
                ResponseFormat.Srt => "srt",
                ResponseFormat.Text => "text",
                ResponseFormat.VerboseJson => "verbose_json",
                ResponseFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => ResponseFormat.Json,
                "srt" => ResponseFormat.Srt,
                "text" => ResponseFormat.Text,
                "verbose_json" => ResponseFormat.VerboseJson,
                "vtt" => ResponseFormat.Vtt,
                _ => null,
            };
        }
    }
}