using GotasDaVida.Domain.Enums;
using GotasDaVida.Domain.ValueObjects;

namespace GotasDaVida.Domain.Entities;

public class Triagem
{
    public Guid Id { get; private set; }
    public bool LactacaoAtiva { get; private set; }
    public bool UsoDrogasIlicitas { get; private set; }
    public Tabagismo Tabagismo { get; private set; }
    public Alcool Alcool { get; private set; }
    public TatuagemPiercing TatuagemPiercing { get; private set; }
    public Transfusao Transfusao { get; private set; }
    public MedicamentoContinuo MedicamentoContinuo { get; private set; }
    public Vacinas Vacinas { get; private set; }
    public StatusCadastro Resultado { get; private set; }

    public Triagem(
        bool lactacaoAtiva,
        bool usoDrogasIlicitas,
        Tabagismo tabagismo,
        Alcool alcool,
        TatuagemPiercing tatuagemPiercing,
        Transfusao transfusao,
        MedicamentoContinuo medicamentoContinuo,
        Vacinas vacinas)
    {
        Id = Guid.NewGuid();
        LactacaoAtiva = lactacaoAtiva;
        UsoDrogasIlicitas = usoDrogasIlicitas;
        Tabagismo = tabagismo;
        Alcool = alcool;
        TatuagemPiercing = tatuagemPiercing;
        Transfusao = transfusao;
        MedicamentoContinuo = medicamentoContinuo;
        Vacinas = vacinas;
        Resultado = StatusCadastro.PendenteAvaliacao;
    }

    internal void AplicarResultado(StatusCadastro resultado)
    {
        Resultado = resultado;
    }
}
