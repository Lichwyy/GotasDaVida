using GotasDaVida.Application.DTOs;
using GotasDaVida.Domain.Entities;
using GotasDaVida.Domain.Enums;
using GotasDaVida.Domain.ValueObjects;

namespace GotasDaVida.Application.Mappers;

public static class CadastroMapper
{
    public static Cadastro ParaDominio(CadastroInputDto dto)
    {
        var doadora = MapearDoadora(dto.Doadora);
        var bebe = MapearBebe(dto.Bebe);
        var triagem = MapearTriagem(dto.Triagem);
        var saudeMaterna = MapearSaudeMaterna(dto.SaudeMaterna);
        var historico = MapearHistorico(dto.HistoricoGestacional);

        return new Cadastro(doadora, bebe, triagem, saudeMaterna, historico);
    }

    private static Doadora MapearDoadora(DoadoraInputDto dto) =>
        new(
            nomeCompleto: dto.NomeCompleto,
            dataNascimento: DateOnly.Parse(dto.DataNascimento),
            whatsapp: dto.Contato.Whatsapp,
            email: dto.Contato.Email,
            endereco: new Endereco(dto.Endereco.Bairro, dto.Endereco.Cidade, dto.Endereco.Estado),
            cartaoSus: new CartaoSus(dto.CartaoSus.Possui, dto.CartaoSus.Numero)
        );
        
    private static Bebe MapearBebe(BebeInputDto dto) =>
        new(
            nome: dto.Nome,
            dataNascimento: DateOnly.Parse(dto.DataNascimento),
            pesoNascerGramas: dto.PesoNascerG
        );

    private static Triagem MapearTriagem(TriagemInputDto dto) =>
        new(
            lactacaoAtiva: dto.LactacaoAtiva,
            usoDrogasIlicitas: dto.UsoDrogasIlicitas,
            tabagismo: new Tabagismo(dto.Tabagismo.Fuma, dto.Tabagismo.CigarrosPorDia),
            alcool: new Alcool(dto.Alcool.Consome, MapearFrequencia(dto.Alcool.Frequencia)),
            tatuagemPiercing: new TatuagemPiercing(dto.TatuagemPiercing.Realizou, dto.TatuagemPiercing.MesAno),
            transfusao: new Transfusao(dto.Transfusao.Realizou, dto.Transfusao.MesAno),
            medicamentoContinuo: new MedicamentoContinuo(dto.MedicamentoContinuo.Usa, dto.MedicamentoContinuo.Qual),
            vacinas: new Vacinas(dto.Vacinas.FebreAmarela, dto.Vacinas.Dtpa)
        );

    private static SaudeMaterna MapearSaudeMaterna(SaudeMaternaInputDto dto) =>
        new(
            hipertensao: dto.Hipertensao,
            diabetes: dto.Diabetes,
            hepatite: dto.Hepatite,
            cirurgiaRecente: dto.CirurgiaRecente,
            tratamentoMedicoAtivo: dto.TratamentoMedicoAtivo,
            detalhes: dto.DetalhesSaude
        );

    private static HistoricoGestacional MapearHistorico(HistoricoGestacionalInputDto dto) =>
        new(
            numeroGestacoes: dto.NumeroGestacoes,
            complicacoes: dto.Complicacoes,
            descricaoComplicacoes: dto.DescricaoComplicacoes
        );

    private static FrequenciaAlcool MapearFrequencia(string frequencia) =>
        frequencia.ToLower() switch
        {
            "eventualmente"  => FrequenciaAlcool.Eventualmente,
            "frequentemente" => FrequenciaAlcool.Frequentemente,
            _                => FrequenciaAlcool.NaoConsome
        };
}
