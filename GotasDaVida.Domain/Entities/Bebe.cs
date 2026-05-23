namespace GotasDaVida.Domain.Entities;

public class Bebe
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public DateOnly DataNascimento { get; private set; }
    public int PesoNascerGramas { get; private set; }

    public Bebe(string nome, DateOnly dataNascimento, int pesoNascerGramas)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        DataNascimento = dataNascimento;
        PesoNascerGramas = pesoNascerGramas;
    }
}
