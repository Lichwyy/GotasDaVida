namespace GotasDaVida.Domain.Entities;

public class SaudeMaterna
{
    public Guid Id { get; private set; }
    public bool Hipertensao { get; private set; }
    public bool Diabetes { get; private set; }
    public bool Hepatite { get; private set; }
    public bool CirurgiaRecente { get; private set; }
    public bool TratamentoMedicoAtivo { get; private set; }
    public string? Detalhes { get; private set; }

    public SaudeMaterna(
        bool hipertensao,
        bool diabetes,
        bool hepatite,
        bool cirurgiaRecente,
        bool tratamentoMedicoAtivo,
        string? detalhes)
    {
        Id = Guid.NewGuid();
        Hipertensao = hipertensao;
        Diabetes = diabetes;
        Hepatite = hepatite;
        CirurgiaRecente = cirurgiaRecente;
        TratamentoMedicoAtivo = tratamentoMedicoAtivo;
        Detalhes = detalhes;
    }
}
