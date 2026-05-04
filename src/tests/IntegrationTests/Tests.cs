namespace Fireworks.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static FireworksClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("FIREWORKS_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("FIREWORKS_API_KEY environment variable is not found.");

        var client = new FireworksClient(apiKey);
        
        return client;
    }
}
