using GotasDaVida.Domain.Common;

namespace GotasDaVida.Domain.Cadastros.ValueObjects;

public sealed class Email : ValueObject
{
    public string Endereco { get; private set; }

    private Email()
    {
    }

    public Email(string endereco)
    {
        if (string.IsNullOrWhiteSpace(endereco))
            throw new ArgumentException("Email inválido.");

        if (!endereco.Contains("@"))
            throw new ArgumentException("Email inválido.");

        Endereco = endereco.Trim().ToLower();
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Endereco;
    }

    public override string ToString()
        => Endereco;
}