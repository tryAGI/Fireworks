# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Fireworks audio SDK does not currently expose a direct [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai) adapter. Fireworks chat models are available through the OpenAI-compatible provider helpers in `tryAGI.OpenAI`.

## Installation

```bash
dotnet add package tryAGI.Fireworks
```

## Usage

```csharp
using Microsoft.Extensions.AI;
using Fireworks;

using var client = new FireworksClient(
    apiKey: Environment.GetEnvironmentVariable("FIREWORKS_API_KEY")!);
```

## Next Steps

- Check the [Examples](../index.md) for complete working code
- See the [centralized MEAI docs](https://tryagi.github.io/docs/meai/) for cross-SDK comparisons
- Visit the [Microsoft.Extensions.AI documentation](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai) for framework details
