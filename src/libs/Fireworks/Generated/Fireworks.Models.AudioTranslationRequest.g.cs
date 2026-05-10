
#nullable enable

namespace Fireworks
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranslationRequest
    {
        /// <summary>
        /// Audio file to translate. Fireworks also accepts a public URL in this form field, but the generated SDK models the documented file upload path as a binary field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// Audio file to translate. Fireworks also accepts a public URL in this form field, but the generated SDK models the documented file upload path as a binary field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// ASR model name.<br/>
        /// Default Value: whisper-v3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fireworks.JsonConverters.AudioModelJsonConverter))]
        public global::Fireworks.AudioModel? Model { get; set; }

        /// <summary>
        /// Voice activity detection model.<br/>
        /// Default Value: silero
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vad_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fireworks.JsonConverters.VadModelJsonConverter))]
        public global::Fireworks.VadModel? VadModel { get; set; }

        /// <summary>
        /// Alignment model used for timestamps.<br/>
        /// Default Value: mms_fa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fireworks.JsonConverters.AlignmentModelJsonConverter))]
        public global::Fireworks.AlignmentModel? AlignmentModel { get; set; }

        /// <summary>
        /// Source language for translation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Prompt used to guide transcription style or vocabulary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Sampling temperature used while decoding text tokens.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Response format requested from the API.<br/>
        /// Default Value: json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fireworks.JsonConverters.ResponseFormatJsonConverter))]
        public global::Fireworks.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Timestamp granularities to populate when response_format is verbose_json.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_granularities")]
        public global::System.Collections.Generic.IList<global::Fireworks.TimestampGranularity>? TimestampGranularities { get; set; }

        /// <summary>
        /// Audio preprocessing mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preprocessing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fireworks.JsonConverters.PreprocessingModeJsonConverter))]
        public global::Fireworks.PreprocessingMode? Preprocessing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranslationRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Audio file to translate. Fireworks also accepts a public URL in this form field, but the generated SDK models the documented file upload path as a binary field.
        /// </param>
        /// <param name="filename">
        /// Audio file to translate. Fireworks also accepts a public URL in this form field, but the generated SDK models the documented file upload path as a binary field.
        /// </param>
        /// <param name="model">
        /// ASR model name.<br/>
        /// Default Value: whisper-v3
        /// </param>
        /// <param name="vadModel">
        /// Voice activity detection model.<br/>
        /// Default Value: silero
        /// </param>
        /// <param name="alignmentModel">
        /// Alignment model used for timestamps.<br/>
        /// Default Value: mms_fa
        /// </param>
        /// <param name="language">
        /// Source language for translation.
        /// </param>
        /// <param name="prompt">
        /// Prompt used to guide transcription style or vocabulary.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature used while decoding text tokens.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="responseFormat">
        /// Response format requested from the API.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="timestampGranularities">
        /// Timestamp granularities to populate when response_format is verbose_json.
        /// </param>
        /// <param name="preprocessing">
        /// Audio preprocessing mode.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranslationRequest(
            byte[] file,
            string filename,
            global::Fireworks.AudioModel? model,
            global::Fireworks.VadModel? vadModel,
            global::Fireworks.AlignmentModel? alignmentModel,
            string? language,
            string? prompt,
            double? temperature,
            global::Fireworks.ResponseFormat? responseFormat,
            global::System.Collections.Generic.IList<global::Fireworks.TimestampGranularity>? timestampGranularities,
            global::Fireworks.PreprocessingMode? preprocessing)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Model = model;
            this.VadModel = vadModel;
            this.AlignmentModel = alignmentModel;
            this.Language = language;
            this.Prompt = prompt;
            this.Temperature = temperature;
            this.ResponseFormat = responseFormat;
            this.TimestampGranularities = timestampGranularities;
            this.Preprocessing = preprocessing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranslationRequest" /> class.
        /// </summary>
        public AudioTranslationRequest()
        {
        }

    }
}