namespace GotasDaVida.Domain.Entities;

public class HistoricoGestacional
{
    public Guid Id { get; private set; }
    public int NumeroGestacoes { get; private set; }
    public bool Complicacoes { get; private set; }
    public string? DescricaoComplicacoes { get; private set; }

    public HistoricoGestacional(
        int numeroGestacoes,
        bool complicacoes,
        string? descricaoComplicacoes)
    {
        Id = Guid.NewGuid();
        NumeroGestacoes = numeroGestacoes;
        Complicacoes = complicacoes;
        DescricaoComplicacoes = descricaoComplicacoes;
    }
}
