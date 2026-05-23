using GotasDaVida.Application.DTOs;
using GotasDaVida.Domain.Cadastros.Repositories;
using GotasDaVida.Domain.Cadastros.ValueObjects;
using GotasDaVida.Domain.Common;
using GotasDaVida.Domain.Entities;
using GotasDaVida.Domain.Enums;

namespace GotasDaVida.Application.UseCases.CreateCadastro;

public class CreateCadastroUseCase
{
    private readonly ICadastroRepository _cadastroRepository;


    public CreateCadastroUseCase(
        ICadastroRepository cadastroRepository
        )
    {
        _cadastroRepository = cadastroRepository;
    }

    public async Task<CreateCadastroDtoResponse> ExecuteAsync(
        CreateCadastroDto request,
        CancellationToken cancellationToken = default)
    {
        var cadastroId = Guid.NewGuid();

        var doadora = new Doadora(
            cadastroId,
            request.Cadastro.Doadora.NomeCompleto,
            request.Cadastro.Doadora.DataNascimento,
            new Whatsapp(request.Cadastro.Doadora.Contato.Whatsapp),
            new Email(request.Cadastro.Doadora.Contato.Email),
            request.Cadastro.Doadora.Endereco.Bairro,
            request.Cadastro.Doadora.Endereco.Cidade,
            request.Cadastro.Doadora.Endereco.Estado,
            request.Cadastro.Doadora.CartaoSus.Possui,
            request.Cadastro.Doadora.CartaoSus.Numero
        );


        var triagem = new Triagem(
            cadastroId,
            request.Cadastro.Triagem.LactacaoAtiva,
            request.Cadastro.Triagem.UsoDrogasIlicitas,
            request.Cadastro.Triagem.Tabagismo.Fuma,
            request.Cadastro.Triagem.Tabagismo.CigarrosPorDia,
            request.Cadastro.Triagem.Alcool.Consome,
            MapFrequenciaAlcool(request.Cadastro.Triagem.Alcool.Frequencia),
            request.Cadastro.Triagem.TatuagemPiercing.Realizou,
            request.Cadastro.Triagem.TatuagemPiercing.MesAno,
            request.Cadastro.Triagem.Transfusao.Realizou,
            request.Cadastro.Triagem.Transfusao.MesAno,
            request.Cadastro.Triagem.MedicamentoContinuo.Usa,
            request.Cadastro.Triagem.MedicamentoContinuo.Qual,
            request.Cadastro.Triagem.Vacinas.FebreAmarela,
            request.Cadastro.Triagem.Vacinas.Dtpa,
            ResultadoTriagem.EmAnalise
        );

        var saudeMaterna = new SaudeMaterna(
            cadastroId,
            request.Cadastro.SaudeMaterna.Hipertensao,
            request.Cadastro.SaudeMaterna.Diabetes,
            request.Cadastro.SaudeMaterna.Hepatite,
            request.Cadastro.SaudeMaterna.CirurgiaRecente,
            request.Cadastro.SaudeMaterna.TratamentoMedicoAtivo,
            request.Cadastro.SaudeMaterna.DetalhesSaude
        );

        var historicoGestacional = new HistoricoGestacional(
            cadastroId,
            request.Cadastro.HistoricoGestacional.NumeroGestacoes,
            request.Cadastro.HistoricoGestacional.Complicacoes,
            request.Cadastro.HistoricoGestacional.DescricaoComplicacoes
        );

        var cadastro = new Cadastro(
            doadora,
            triagem,
            saudeMaterna,
            historicoGestacional
        );

        typeof(Cadastro)
            .GetProperty(nameof(Cadastro.Id))!
            .SetValue(cadastro, cadastroId);

        await _cadastroRepository.AddAsync(cadastro);


        return new CreateCadastroDtoResponse
        {
            CadastroId = cadastro.Id
        };
    }

    private static FrequenciaAlcool MapFrequenciaAlcool(
        string frequencia)
    {
        return frequencia.ToLower() switch
        {
            "nunca" => FrequenciaAlcool.Nunca,
            "raramente" => FrequenciaAlcool.Raramente,
            "eventualmente" => FrequenciaAlcool.Raramente,
            "semanalmente" => FrequenciaAlcool.Semanalmente,
            _ => FrequenciaAlcool.Frequentemente
        };
    }
}