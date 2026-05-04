namespace Fireworks;

public sealed partial class FireworksClient
{
    /// <summary>
    /// Serverless endpoint for the Fireworks <c>whisper-v3</c> audio model.
    /// </summary>
    public static readonly Uri WhisperV3BaseUri = new("https://audio-prod.api.fireworks.ai/v1/");

    /// <summary>
    /// Serverless endpoint for the Fireworks <c>whisper-v3-turbo</c> audio model.
    /// </summary>
    public static readonly Uri WhisperV3TurboBaseUri = new("https://audio-turbo.api.fireworks.ai/v1/");
}
