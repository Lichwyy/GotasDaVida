using GotasDaVida.Domain.Cadastros.ValueObjects;
using GotasDaVida.Domain.Common;

namespace GotasDaVida.Domain.Entities;

public class Doadora : Entity
{
    public Guid CadastroId { get; private set; }

    public string NomeCompleto { get; private set; }

    public DateTime DataNascimento { get; private set; }

    public Whatsapp Whatsapp { get; private set; }

    public Email Email { get; private set; }

    public string Bairro { get; private set; }

    public string Cidade { get; private set; }

    public string Estado { get; private set; }

    public bool SusPossui { get; private set; }

    public string? SusNumero { get; private set; }

    private Doadora()
    {
    }

    public Doadora(
        Guid cadastroId,
        string nomeCompleto,
        DateTime dataNascimento,
        Whatsapp whatsapp,
        Email email,
        string bairro,
        string cidade,
        string estado,
        bool susPossui,
        string? susNumero)
    {
        CadastroId = cadastroId;
        NomeCompleto = nomeCompleto;
        DataNascimento = dataNascimento;
        Whatsapp = whatsapp;
        Email = email;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
        SusPossui = susPossui;
        SusNumero = susNumero;
    }
}