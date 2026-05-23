using GotasDaVida.Domain.Common;
using GotasDaVida.Domain.Common;

namespace GotasDaVida.Domain.Entities;

public class SaudeMaterna : Entity
{
    public Guid CadastroId { get; private set; }

    public bool Hipertensao { get; private set; }

    public bool Diabetes { get; private set; }

    public bool Hepatite { get; private set; }

    public bool CirurgiaRecente { get; private set; }

    public bool TratamentoMedicoAtivo { get; private set; }

    public string? Detalhes { get; private set; }

    private SaudeMaterna()
    {
    }

    public SaudeMaterna(
        Guid cadastroId,
        bool hipertensao,
        bool diabetes,
        bool hepatite,
        bool cirurgiaRecente,
        bool tratamentoMedicoAtivo,
        string? detalhes)
    {
        CadastroId = cadastroId;
        Hipertensao = hipertensao;
        Diabetes = diabetes;
        Hepatite = hepatite;
        CirurgiaRecente = cirurgiaRecente;
        TratamentoMedicoAtivo = tratamentoMedicoAtivo;
        Detalhes = detalhes;
    }
}