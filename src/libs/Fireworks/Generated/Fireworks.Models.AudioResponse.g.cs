
#nullable enable

namespace Fireworks
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioResponse
    {
        /// <summary>
        /// Transcribed or translated text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Task performed by the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fireworks.JsonConverters.AudioResponseTaskJsonConverter))]
        public global::Fireworks.AudioResponseTask? Task { get; set; }

        /// <summary>
        /// Language code or comma-separated detected language codes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Audio duration in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Word-level timestamps and metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Fireworks.Word>? Words { get; set; }

        /// <summary>
        /// Segment-level timestamps and metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::Fireworks.Segment>? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioResponse" /> class.
        /// </summary>
        /// <param name="text">
        /// Transcribed or translated text.
        /// </param>
        /// <param name="task">
        /// Task performed by the API.
        /// </param>
        /// <param name="language">
        /// Language code or comma-separated detected language codes.
        /// </param>
        /// <param name="duration">
        /// Audio duration in seconds.
        /// </param>
        /// <param name="words">
        /// Word-level timestamps and metadata.
        /// </param>
        /// <param name="segments">
        /// Segment-level timestamps and metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioResponse(
            string text,
            global::Fireworks.AudioResponseTask? task,
            string? language,
            double? duration,
            global::System.Collections.Generic.IList<global::Fireworks.Word>? words,
            global::System.Collections.Generic.IList<global::Fireworks.Segment>? segments)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Task = task;
            this.Language = language;
            this.Duration = duration;
            this.Words = words;
            this.Segments = segments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioResponse" /> class.
        /// </summary>
        public AudioResponse()
        {
        }
    }
}