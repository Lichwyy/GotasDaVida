// GotasDaVida.Api/Controllers/ChatController.cs
using GotasDaVida.Application.DTOs;
using GotasDaVida.Application.Services;
using GotasDaVida.Application.UseCases;
using GotasDaVida.Application.UseCases.CreateCadastro;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GotasDaVida.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChatController : ControllerBase
{
    private readonly IFoundryService _foundry;
    private readonly CreateCadastroUseCase _createCadastro;
    private readonly ILogger<ChatController> _logger;

    public ChatController(
        IFoundryService foundry,
        CreateCadastroUseCase createCadastro,
        ILogger<ChatController> logger)
    {
        _foundry = foundry;
        _createCadastro = createCadastro;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ChatRequestDto request)
    {
        if (string.IsNullOrWhiteSpace(request.Message))
            return BadRequest("Mensagem não pode ser vazia.");

        var foundryResponse = await _foundry.SendMessageAsync(
            request.Message,
            request.PreviousResponseId
        );

        bool cadastroSalvo = false;
        string? erro = null;

        if (foundryResponse.HasJson && foundryResponse.RawJson is not null)
        {
            try
            {
                // ✅ Usando CreateCadastroDto que você já tem
                var dto = JsonSerializer.Deserialize<CreateCadastroDto>(
                    foundryResponse.RawJson,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                );

                if (dto is not null)
                {
                    await _createCadastro.ExecuteAsync(dto);
                    cadastroSalvo = true;
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "Falha ao salvar cadastro do JSON detectado.");
                erro = "Dados identificados mas houve erro ao salvar.";
            }
        }

        return Ok(new ChatResponseDto(
            Text: foundryResponse.Text,
            ResponseId: foundryResponse.ResponseId,
            CadastroSalvo: cadastroSalvo,
            ErroDoSalvamento: erro
        ));
    }
}