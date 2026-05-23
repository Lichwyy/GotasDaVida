// GotasDaVida.Infrastructure/Services/FoundryService.cs
using Azure.AI.Extensions.OpenAI;
using Azure.AI.Projects;
using Azure.AI.Projects.Agents;
using Azure.Identity;
using GotasDaVida.Application.Services;
using Microsoft.Extensions.Configuration;
using OpenAI.Responses;
using System.Text.RegularExpressions;

#pragma warning disable OPENAI001

namespace GotasDaVida.Application.Services;

public class FoundryService : IFoundryService
{
    private readonly ProjectResponsesClient _client;

    public FoundryService(IConfiguration configuration)
    {
        var section = configuration.GetSection("AzureFoundry");
        var endpoint = section["Endpoint"]!;
        var agentName = section["AgentName"]!;
        var agentVersion = section["AgentVersion"]!;

        // ✅ Abre o navegador para login — sem TenantId, ClientId ou ClientSecret
        var credential = new InteractiveBrowserCredential();

        var projectClient = new AIProjectClient(
            endpoint: new Uri(endpoint),
            tokenProvider: credential
        );

        var agentRef = new AgentReference(name: agentName, version: agentVersion);
        _client = projectClient.OpenAI.GetProjectResponsesClientForAgent(agentRef);
    }

    public async Task<FoundryResponse> SendMessageAsync(string message, string? previousResponseId = null)
    {
        var options = new CreateResponseOptions(
            model: "gpt-4.1",
            inputItems: new List<ResponseItem>
            {
            ResponseItem.CreateUserMessageItem(message)
            }
        );

        if (!string.IsNullOrEmpty(previousResponseId))
            options.PreviousResponseId = previousResponseId;

        var result = await _client.CreateResponseAsync(options);
        var response = result.Value;
        var text = response.GetOutputText();

        var (hasJson, rawJson) = ExtractJson(text);

        return new FoundryResponse(
            Text: text,
            ResponseId: response.Id,
            HasJson: hasJson,
            RawJson: rawJson
        );
    }

    private static (bool hasJson, string? rawJson) ExtractJson(string text)
    {
        var mdMatch = Regex.Match(text, @"```(?:json)?\s*(\{[\s\S]*?\})\s*```");
        if (mdMatch.Success)
            return (true, mdMatch.Groups[1].Value.Trim());

        var jsonMatch = Regex.Match(text, @"\{[\s\S]*\}");
        if (jsonMatch.Success)
        {
            try
            {
                System.Text.Json.JsonDocument.Parse(jsonMatch.Value);
                return (true, jsonMatch.Value.Trim());
            }
            catch { /* não é JSON válido */ }
        }

        return (false, null);
    }
}