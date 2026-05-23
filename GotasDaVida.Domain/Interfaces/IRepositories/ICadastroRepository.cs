using GotasDaVida.Domain.Entities;

namespace BLH.Domain.Interfaces;

public interface ICadastroRepository
{
    Task SalvarAsync(Cadastro cadastro, CancellationToken cancellationToken = default);
    Task<Cadastro?> ObterPorIdAsync(Guid id, CancellationToken cancellationToken = default);
}
