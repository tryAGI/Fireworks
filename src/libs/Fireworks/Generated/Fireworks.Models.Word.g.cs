
#nullable enable

namespace Fireworks
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Word
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        public double? Probability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hallucination_score")]
        public double? HallucinationScore { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Word" /> class.
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="language"></param>
        /// <param name="probability"></param>
        /// <param name="hallucinationScore"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="speakerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Word(
            string word1,
            string? language,
            double? probability,
            double? hallucinationScore,
            double? start,
            double? end,
            string? speakerId)
        {
            this.Word1 = word1 ?? throw new global::System.ArgumentNullException(nameof(word1));
            this.Language = language;
            this.Probability = probability;
            this.HallucinationScore = hallucinationScore;
            this.Start = start;
            this.End = end;
            this.SpeakerId = speakerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Word" /> class.
        /// </summary>
        public Word()
        {
        }
    }
}