
#nullable enable

namespace Fireworks
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Segment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        public string? SpeakerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Fireworks.Word>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="id"></param>
        /// <param name="language"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="speakerId"></param>
        /// <param name="words"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Segment(
            string text,
            int? id,
            string? language,
            double? start,
            double? end,
            string? speakerId,
            global::System.Collections.Generic.IList<global::Fireworks.Word>? words)
        {
            this.Id = id;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Language = language;
            this.Start = start;
            this.End = end;
            this.SpeakerId = speakerId;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment" /> class.
        /// </summary>
        public Segment()
        {
        }

    }
}