using GotasDaVida.Domain.Common;

namespace GotasDaVida.Domain.Cadastros.ValueObjects;

public sealed class Whatsapp : ValueObject
{
    public string Numero { get; private set; }

    private Whatsapp()
    {
    }

    public Whatsapp(string numero)
    {
        if (string.IsNullOrWhiteSpace(numero))
            throw new ArgumentException("Whatsapp inválido.");

        Numero = numero.Trim();
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Numero;
    }

    public override string ToString()
        => Numero;
}