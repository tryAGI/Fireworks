# Transcribe

Create a client for Fireworks pre-recorded audio transcription.

This example assumes `using Fireworks;` is in scope and `apiKey` contains your Fireworks API key.

```csharp
using var client = new FireworksClient(apiKey);

var audioPath = Environment.GetEnvironmentVariable("FIREWORKS_SAMPLE_AUDIO_PATH") is { Length: > 0 } path
    ? path
    : "sample.wav";

var audioBytes = await File.ReadAllBytesAsync(audioPath);
var response = await client.CreateTranscriptionAsync(
    file: audioBytes,
    filename: Path.GetFileName(audioPath),
    model: AudioModel.WhisperV3);
```