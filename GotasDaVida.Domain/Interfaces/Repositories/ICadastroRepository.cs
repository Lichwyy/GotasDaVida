using GotasDaVida.Domain.Entities;
using GotasDaVida.Domain.Enums;

namespace GotasDaVida.Domain.Cadastros.Repositories;

public interface ICadastroRepository
{
    Task<Cadastro?> GetByIdAsync(Guid id);

    Task<IReadOnlyCollection<Cadastro>> GetAllAsync();

    Task<IReadOnlyCollection<Cadastro>> GetByStatusAsync(
        CadastroStatus status);

    Task<IReadOnlyCollection<Cadastro>> GetByCidadeAsync(
        string cidade);

    Task<Cadastro?> GetByWhatsappAsync(
        string whatsapp);

    Task<IReadOnlyCollection<Cadastro>> SearchByNomeAsync(
        string nome);

    Task AddAsync(Cadastro cadastro);

    Task UpdateAsync(Cadastro cadastro);

    Task RemoveAsync(Cadastro cadastro);
}