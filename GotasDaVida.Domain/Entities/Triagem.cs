using GotasDaVida.Domain.Enums;
using GotasDaVida.Domain.Common;

namespace GotasDaVida.Domain.Entities;
public class Triagem : Entity
{
    public Guid CadastroId { get; private set; }

    public bool LactacaoAtiva { get; private set; }

    public bool UsoDrogasIlicitas { get; private set; }

    public bool Fuma { get; private set; }

    public int? CigarrosPorDia { get; private set; }

    public bool AlcoolConsome { get; private set; }

    public FrequenciaAlcool AlcoolFrequencia { get; private set; }

    public bool TatuagemRealizou { get; private set; }

    public string? TatuagemMesAno { get; private set; }

    public bool TransfusaoRealizou { get; private set; }

    public string? TransfusaoMesAno { get; private set; }

    public bool MedicamentoUsa { get; private set; }

    public string? MedicamentoQual { get; private set; }

    public bool VacinaFebreAmarela { get; private set; }

    public bool VacinaDtpa { get; private set; }

    public ResultadoTriagem Resultado { get; private set; }

    private Triagem()
    {
    }

    public Triagem(
        Guid cadastroId,
        bool lactacaoAtiva,
        bool usoDrogasIlicitas,
        bool fuma,
        int? cigarrosPorDia,
        bool alcoolConsome,
        FrequenciaAlcool alcoolFrequencia,
        bool tatuagemRealizou,
        string? tatuagemMesAno,
        bool transfusaoRealizou,
        string? transfusaoMesAno,
        bool medicamentoUsa,
        string? medicamentoQual,
        bool vacinaFebreAmarela,
        bool vacinaDtpa,
        ResultadoTriagem resultado)
    {
        CadastroId = cadastroId;
        LactacaoAtiva = lactacaoAtiva;
        UsoDrogasIlicitas = usoDrogasIlicitas;
        Fuma = fuma;
        CigarrosPorDia = cigarrosPorDia;
        AlcoolConsome = alcoolConsome;
        AlcoolFrequencia = alcoolFrequencia;
        TatuagemRealizou = tatuagemRealizou;
        TatuagemMesAno = tatuagemMesAno;
        TransfusaoRealizou = transfusaoRealizou;
        TransfusaoMesAno = transfusaoMesAno;
        MedicamentoUsa = medicamentoUsa;
        MedicamentoQual = medicamentoQual;
        VacinaFebreAmarela = vacinaFebreAmarela;
        VacinaDtpa = vacinaDtpa;
        Resultado = resultado;
    }
}