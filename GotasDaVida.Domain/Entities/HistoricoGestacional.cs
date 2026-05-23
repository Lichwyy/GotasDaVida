using GotasDaVida.Domain.Common;
using GotasDaVida.Domain.Common;

namespace GotasDaVida.Domain.Entities;

public class HistoricoGestacional : Entity
{
    public Guid CadastroId { get; private set; }

    public int NumeroGestacoes { get; private set; }

    public bool Complicacoes { get; private set; }

    public string? DescricaoComplicacoes { get; private set; }

    private HistoricoGestacional()
    {
    }

    public HistoricoGestacional(
        Guid cadastroId,
        int numeroGestacoes,
        bool complicacoes,
        string? descricaoComplicacoes)
    {
        CadastroId = cadastroId;
        NumeroGestacoes = numeroGestacoes;
        Complicacoes = complicacoes;
        DescricaoComplicacoes = descricaoComplicacoes;
    }
}