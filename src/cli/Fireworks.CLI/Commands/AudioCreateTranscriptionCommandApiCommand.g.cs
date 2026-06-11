#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Fireworks.CLI.Commands;

internal static partial class AudioCreateTranscriptionCommandApiCommand
{
    private static Option<byte[]> File { get; } = new(
        name: @"--file")
    {
        Description = @"Audio file to transcribe. Fireworks also accepts a public URL in this form field, but the generated SDK models the documented file upload path as a binary field.
",
        Required = true,
    };

    private static Option<string> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"Audio file to transcribe. Fireworks also accepts a public URL in this form field, but the generated SDK models the documented file upload path as a binary field.
",
        Required = true,
    };

    private static Option<global::Fireworks.AudioModel?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"ASR model name.",
    };

    private static Option<global::Fireworks.VadModel?> VadModel { get; } = new(
        name: @"--vad-model")
    {
        Description = @"Voice activity detection model.",
    };

    private static Option<global::Fireworks.AlignmentModel?> AlignmentModel { get; } = new(
        name: @"--alignment-model")
    {
        Description = @"Alignment model used for timestamps.",
    };

    private static Option<string?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"Target language for transcription.",
    };

    private static Option<string?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Prompt used to guide transcription style or vocabulary.",
    };

    private static Option<double?> Temperature { get; } = new(
        name: @"--temperature")
    {
        Description = @"Sampling temperature used while decoding text tokens.",
    };

    private static Option<global::Fireworks.ResponseFormat?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"Response format requested from the API.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Fireworks.TimestampGranularity>?> TimestampGranularities { get; } = new(
        name: @"--timestamp-granularities")
    {
        Description = @"Timestamp granularities to populate when response_format is verbose_json.",
    };

    private static Option<bool?> Diarize { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--diarize",
        description: @"Enable speaker diarization. Requires verbose_json and word timestamps.");

    private static Option<int?> MinSpeakers { get; } = new(
        name: @"--min-speakers")
    {
        Description = @"Minimum speakers to detect when diarization is enabled.",
    };

    private static Option<int?> MaxSpeakers { get; } = new(
        name: @"--max-speakers")
    {
        Description = @"Maximum speakers to detect when diarization is enabled.",
    };

    private static Option<global::Fireworks.PreprocessingMode?> Preprocessing { get; } = new(
        name: @"--preprocessing")
    {
        Description = @"Audio preprocessing mode.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Fireworks.AudioResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Fireworks.AudioResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-transcription", @"Transcribe audio
Converts a pre-recorded audio file into text using Fireworks AI ASR models. Use the default base URL for `whisper-v3`; override the client base URI to `https://audio-turbo.api.fireworks.ai/v1` when using `whisper-v3-turbo`.
");
                        command.Options.Add(File);
                        command.Options.Add(Filename);
                        command.Options.Add(Model);
                        command.Options.Add(VadModel);
                        command.Options.Add(AlignmentModel);
                        command.Options.Add(Language);
                        command.Options.Add(Prompt);
                        command.Options.Add(Temperature);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(TimestampGranularities);
                        command.Options.Add(Diarize);
                        command.Options.Add(MinSpeakers);
                        command.Options.Add(MaxSpeakers);
                        command.Options.Add(Preprocessing);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Fireworks.AudioTranscriptionRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Fireworks.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var file = parseResult.GetRequiredValue(File);
                        var filename = parseResult.GetRequiredValue(Filename);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : __requestBase is not null ? __requestBase.Model : default;
                        var vadModel = CliRuntime.WasSpecified(parseResult, VadModel) ? parseResult.GetValue(VadModel) : __requestBase is not null ? __requestBase.VadModel : default;
                        var alignmentModel = CliRuntime.WasSpecified(parseResult, AlignmentModel) ? parseResult.GetValue(AlignmentModel) : __requestBase is not null ? __requestBase.AlignmentModel : default;
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : __requestBase is not null ? __requestBase.Language : default;
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : __requestBase is not null ? __requestBase.Prompt : default;
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : __requestBase is not null ? __requestBase.Temperature : default;
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : __requestBase is not null ? __requestBase.ResponseFormat : default;
                        var timestampGranularities = CliRuntime.WasSpecified(parseResult, TimestampGranularities) ? parseResult.GetValue(TimestampGranularities) : __requestBase is not null ? __requestBase.TimestampGranularities : default;
                        var diarize = CliRuntime.WasSpecified(parseResult, Diarize) ? parseResult.GetValue(Diarize) : __requestBase is not null ? __requestBase.Diarize : default;
                        var minSpeakers = CliRuntime.WasSpecified(parseResult, MinSpeakers) ? parseResult.GetValue(MinSpeakers) : __requestBase is not null ? __requestBase.MinSpeakers : default;
                        var maxSpeakers = CliRuntime.WasSpecified(parseResult, MaxSpeakers) ? parseResult.GetValue(MaxSpeakers) : __requestBase is not null ? __requestBase.MaxSpeakers : default;
                        var preprocessing = CliRuntime.WasSpecified(parseResult, Preprocessing) ? parseResult.GetValue(Preprocessing) : __requestBase is not null ? __requestBase.Preprocessing : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateTranscriptionAsync(
                                    file: file,
                                    filename: filename,
                                    model: model,
                                    vadModel: vadModel,
                                    alignmentModel: alignmentModel,
                                    language: language,
                                    prompt: prompt,
                                    temperature: temperature,
                                    responseFormat: responseFormat,
                                    timestampGranularities: timestampGranularities,
                                    diarize: diarize,
                                    minSpeakers: minSpeakers,
                                    maxSpeakers: maxSpeakers,
                                    preprocessing: preprocessing,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Fireworks.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}