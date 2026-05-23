// GotasDaVida.Application/DTOs/ChatResponseDto.cs
namespace GotasDaVida.Application.DTOs;

public record ChatResponseDto(
    string Text,
    string ResponseId,          // frontend deve guardar e reenviar
    bool CadastroSalvo,
    string? ErroDoSalvamento
);