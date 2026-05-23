using GotasDaVida.Domain.ValueObjects;

namespace GotasDaVida.Domain.Entities;

public class Doadora
{
    public Guid Id { get; private set; }
    public string NomeCompleto { get; private set; }
    public DateOnly DataNascimento { get; private set; }
    public string Whatsapp { get; private set; }
    public string Email { get; private set; }
    public Endereco Endereco { get; private set; }
    public CartaoSus CartaoSus { get; private set; }

    public Doadora(
        string nomeCompleto,
        DateOnly dataNascimento,
        string whatsapp,
        string email,
        Endereco endereco,
        CartaoSus cartaoSus)
    {
        Id = Guid.NewGuid();
        NomeCompleto = nomeCompleto;
        DataNascimento = dataNascimento;
        Whatsapp = whatsapp;
        Email = email;
        Endereco = endereco;
        CartaoSus = cartaoSus;
    }
}
