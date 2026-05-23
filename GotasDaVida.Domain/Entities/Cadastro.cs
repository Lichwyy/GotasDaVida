using GotasDaVida.Domain.Enums;

namespace GotasDaVida.Domain.Entities;

public class Cadastro
{
    public Guid Id { get; private set; }
    public DateTime DataCadastro { get; private set; }
    public StatusCadastro Status { get; private set; }

    public Doadora Doadora { get; private set; }
    public Bebe Bebe { get; private set; }
    public Triagem Triagem { get; private set; }
    public SaudeMaterna SaudeMaterna { get; private set; }
    public HistoricoGestacional HistoricoGestacional { get; private set; }

    public Cadastro(
        Doadora doadora,
        Bebe bebe,
        Triagem triagem,
        SaudeMaterna saudeMaterna,
        HistoricoGestacional historicoGestacional)
    {
        Id = Guid.NewGuid();
        DataCadastro = DateTime.UtcNow;
        Status = StatusCadastro.PendenteAvaliacao;

        Doadora = doadora;
        Bebe = bebe;
        Triagem = triagem;
        SaudeMaterna = saudeMaterna;
        HistoricoGestacional = historicoGestacional;
    }

    internal void AtualizarStatus(StatusCadastro status)
    {
        Status = status;
        Triagem.AplicarResultado(status);
    }
}
