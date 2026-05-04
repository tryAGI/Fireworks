<div class="docs-hero">
  <h1>Fireworks</h1>
  <p class="docs-hero-lead">Modern .NET SDK for Fireworks AI audio transcription and translation generated with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/tryAGI.Fireworks/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/tryAGI.Fireworks"></a>
    <a href="https://github.com/tryAGI/Fireworks/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/Fireworks/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/Fireworks/blob/main/LICENSE"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/Fireworks"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from a checked-in OpenAPI document assembled from the public <a href="https://docs.fireworks.ai/api-reference/audio-transcriptions">Fireworks audio API reference</a>.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using Fireworks;

using var client = new FireworksClient(apiKey);
```

<!-- EXAMPLES:START -->
### Transcribe
Create a client for Fireworks pre-recorded audio transcription.

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
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/Fireworks/issues">tryAGI/Fireworks</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/Fireworks/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
