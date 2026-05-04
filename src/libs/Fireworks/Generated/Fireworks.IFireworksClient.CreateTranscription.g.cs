#nullable enable

namespace Fireworks
{
    public partial interface IFireworksClient
    {
        /// <summary>
        /// Transcribe audio<br/>
        /// Converts a pre-recorded audio file into text using Fireworks AI ASR models. Use the default base URL for `whisper-v3`; override the client base URI to `https://audio-turbo.api.fireworks.ai/v1` when using `whisper-v3-turbo`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fireworks.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fireworks.AudioResponse> CreateTranscriptionAsync(

            global::Fireworks.AudioTranscriptionRequest request,
            global::Fireworks.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe audio<br/>
        /// Converts a pre-recorded audio file into text using Fireworks AI ASR models. Use the default base URL for `whisper-v3`; override the client base URI to `https://audio-turbo.api.fireworks.ai/v1` when using `whisper-v3-turbo`.
        /// </summary>
        /// <param name="file">
        /// Audio file to transcribe. Fireworks also accepts a public URL in this form field, but the generated SDK models the documented file upload path as a binary field.
        /// </param>
        /// <param name="filename">
        /// Audio file to transcribe. Fireworks also accepts a public URL in this form field, but the generated SDK models the documented file upload path as a binary field.
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
        /// Target language for transcription.
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
        /// <param name="diarize">
        /// Enable speaker diarization. Requires verbose_json and word timestamps.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="minSpeakers">
        /// Minimum speakers to detect when diarization is enabled.
        /// </param>
        /// <param name="maxSpeakers">
        /// Maximum speakers to detect when diarization is enabled.
        /// </param>
        /// <param name="preprocessing">
        /// Audio preprocessing mode.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fireworks.AudioResponse> CreateTranscriptionAsync(
            byte[] file,
            string filename,
            global::Fireworks.AudioModel? model = default,
            global::Fireworks.VadModel? vadModel = default,
            global::Fireworks.AlignmentModel? alignmentModel = default,
            string? language = default,
            string? prompt = default,
            double? temperature = default,
            global::Fireworks.ResponseFormat? responseFormat = default,
            global::System.Collections.Generic.IList<global::Fireworks.TimestampGranularity>? timestampGranularities = default,
            bool? diarize = default,
            int? minSpeakers = default,
            int? maxSpeakers = default,
            global::Fireworks.PreprocessingMode? preprocessing = default,
            global::Fireworks.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}