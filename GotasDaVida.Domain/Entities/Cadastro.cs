using GotasDaVida.Domain.Enums;
using GotasDaVida.Domain.Common;

namespace GotasDaVida.Domain.Entities;

public class Cadastro : AggregateRoot
{
    public CadastroStatus Status { get; private set; }

    public DateTime DataCadastro { get; private set; }

    public Doadora Doadora { get; private set; }


    public Triagem Triagem { get; private set; }

    public SaudeMaterna SaudeMaterna { get; private set; }

    public HistoricoGestacional HistoricoGestacional { get; private set; }

    private Cadastro()
    {
    }

    public Cadastro(
        Doadora doadora,
        Triagem triagem,
        SaudeMaterna saudeMaterna,
        HistoricoGestacional historicoGestacional)
    {
        Status = CadastroStatus.Pendente;
        DataCadastro = DateTime.UtcNow;

        Doadora = doadora;
        Triagem = triagem;
        SaudeMaterna = saudeMaterna;
        HistoricoGestacional = historicoGestacional;
    }

    public void Aprovar()
    {
        Status = CadastroStatus.Aprovado;
    }

    public void Rejeitar()
    {
        Status = CadastroStatus.Rejeitado;
    }

    public void EmAnalise()
    {
        Status = CadastroStatus.EmAnalise;
    }
}