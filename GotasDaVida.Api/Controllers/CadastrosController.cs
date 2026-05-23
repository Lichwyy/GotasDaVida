using GotasDaVida.Application.DTOs;
using GotasDaVida.Application.UseCases.CreateCadastro;
using Microsoft.AspNetCore.Mvc;

namespace GotasDaVida.API.Controllers;

[ApiController]
[Route("api/cadastros")]
public class CadastrosController : ControllerBase
{
    private readonly CreateCadastroUseCase _createCadastroUseCase;

    public CadastrosController(
        CreateCadastroUseCase createCadastroUseCase)
    {
        _createCadastroUseCase = createCadastroUseCase;
    }

    [HttpPost]
    [ProducesResponseType(
        typeof(CreateCadastroDtoResponse),
        StatusCodes.Status201Created)]
    [ProducesResponseType(
        StatusCodes.Status400BadRequest)]
    [ProducesResponseType(
        StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Create(
        [FromBody] CreateCadastroDto request,
        CancellationToken cancellationToken)
    {
        if (request is null)
            return BadRequest("Payload inválido.");

        var response = await _createCadastroUseCase.ExecuteAsync(
            request,
            cancellationToken);

        return CreatedAtAction(
            nameof(Create),
            new { id = response.CadastroId },
            response);
    }
}