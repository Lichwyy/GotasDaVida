// GotasDaVida.Application/Services/IFoundryService.cs
namespace GotasDaVida.Application.Services;

public interface IFoundryService
{
    Task<FoundryResponse> SendMessageAsync(string message, string? previousResponseId = null);
}

public record FoundryResponse(
    string Text,
    string ResponseId,
    bool HasJson,
    string? RawJson
);