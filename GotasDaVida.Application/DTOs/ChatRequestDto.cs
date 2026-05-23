// GotasDaVida.Application/DTOs/ChatRequestDto.cs
namespace GotasDaVida.Application.DTOs;

public record ChatRequestDto(
    string Message,
    string? PreviousResponseId  // para manter conversa multi-turno
);