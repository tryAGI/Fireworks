/*
order: 10
title: Transcribe
slug: transcribe

Create a client for Fireworks pre-recorded audio transcription.
*/

namespace Fireworks.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Transcribe()
    {
        using var client = GetAuthenticatedClient();

        var audioPath = Environment.GetEnvironmentVariable("FIREWORKS_SAMPLE_AUDIO_PATH") is { Length: > 0 } path
            ? path
            : "sample.wav";

        var audioBytes = await File.ReadAllBytesAsync(audioPath);
        var response = await client.CreateTranscriptionAsync(
            file: audioBytes,
            filename: Path.GetFileName(audioPath),
            model: AudioModel.WhisperV3);

        response.Text.Should().NotBeNullOrWhiteSpace();
    }
}
