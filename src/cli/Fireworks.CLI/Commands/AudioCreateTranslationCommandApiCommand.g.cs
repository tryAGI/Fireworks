#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Fireworks.CLI.Commands;

internal static partial class AudioCreateTranslationCommandApiCommand
{
    private static Option<byte[]> File { get; } = new(
        name: @"--file")
    {
        Description = @"Audio file to translate. Fireworks also accepts a public URL in this form field, but the generated SDK models the documented file upload path as a binary field.
",
        Required = true,
    };

    private static Option<string> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"Audio file to translate. Fireworks also accepts a public URL in this form field, but the generated SDK models the documented file upload path as a binary field.
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
        Description = @"Source language for translation.",
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
        var command = new Command(@"create-translation", @"Translate audio to English
Translates a pre-recorded audio file from a supported source language to English. Use the default base URL for `whisper-v3`; override the client base URI to `https://audio-turbo.api.fireworks.ai/v1` when using `whisper-v3-turbo`.
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Fireworks.AudioTranslationRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Fireworks.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var file = parseResult.GetRequiredValue(File);
                        var filename = parseResult.GetRequiredValue(Filename);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var vadModel = CliRuntime.WasSpecified(parseResult, VadModel) ? parseResult.GetValue(VadModel) : (__requestBase is { } __VadModelBaseValue ? __VadModelBaseValue.VadModel : default);
                        var alignmentModel = CliRuntime.WasSpecified(parseResult, AlignmentModel) ? parseResult.GetValue(AlignmentModel) : (__requestBase is { } __AlignmentModelBaseValue ? __AlignmentModelBaseValue.AlignmentModel : default);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : (__requestBase is { } __PromptBaseValue ? __PromptBaseValue.Prompt : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                        var timestampGranularities = CliRuntime.WasSpecified(parseResult, TimestampGranularities) ? parseResult.GetValue(TimestampGranularities) : (__requestBase is { } __TimestampGranularitiesBaseValue ? __TimestampGranularitiesBaseValue.TimestampGranularities : default);
                        var preprocessing = CliRuntime.WasSpecified(parseResult, Preprocessing) ? parseResult.GetValue(Preprocessing) : (__requestBase is { } __PreprocessingBaseValue ? __PreprocessingBaseValue.Preprocessing : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateTranslationAsync(
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