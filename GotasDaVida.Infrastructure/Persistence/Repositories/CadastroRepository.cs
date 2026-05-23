using GotasDaVida.Domain.Cadastros.Repositories;
using GotasDaVida.Domain.Entities;
using GotasDaVida.Domain.Enums;
using GotasDaVida.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace GotasDaVida.Infrastructure.Persistence.Repositories;

public class CadastroRepository : ICadastroRepository
{
    private readonly GotasDaVidaDbContext _context;

    public CadastroRepository(GotasDaVidaDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Cadastro cadastro)
    {
        await _context.Cadastros.AddAsync(cadastro);

        await _context.SaveChangesAsync();
    }

    public async Task<IReadOnlyCollection<Cadastro>> GetAllAsync()
    {
        return await _context.Cadastros
            .Include(x => x.Doadora)
            .Include(x => x.Triagem)
            .Include(x => x.SaudeMaterna)
            .Include(x => x.HistoricoGestacional)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Cadastro?> GetByIdAsync(Guid id)
    {
        return await _context.Cadastros
            .Include(x => x.Doadora)
            .Include(x => x.Triagem)
            .Include(x => x.SaudeMaterna)
            .Include(x => x.HistoricoGestacional)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IReadOnlyCollection<Cadastro>> GetByStatusAsync(
        CadastroStatus status)
    {
        return await _context.Cadastros
            .Include(x => x.Doadora)
            .Include(x => x.Triagem)
            .Include(x => x.SaudeMaterna)
            .Include(x => x.HistoricoGestacional)
            .AsNoTracking()
            .Where(x => x.Status == status)
            .ToListAsync();
    }

    public async Task<IReadOnlyCollection<Cadastro>> GetByCidadeAsync(
        string cidade)
    {
        return await _context.Cadastros
            .Include(x => x.Doadora)
            .Include(x => x.Triagem)
            .Include(x => x.SaudeMaterna)
            .Include(x => x.HistoricoGestacional)
            .AsNoTracking()
            .Where(x => x.Doadora.Cidade == cidade)
            .ToListAsync();
    }

    public async Task<Cadastro?> GetByWhatsappAsync(string whatsapp)
    {
        return await _context.Cadastros
            .Include(x => x.Doadora)
            .Include(x => x.Triagem)
            .Include(x => x.SaudeMaterna)
            .Include(x => x.HistoricoGestacional)
            .AsNoTracking()
            .FirstOrDefaultAsync(
                x => x.Doadora.Whatsapp.Numero == whatsapp);
    }

    public async Task<IReadOnlyCollection<Cadastro>> SearchByNomeAsync(
        string nome)
    {
        return await _context.Cadastros
            .Include(x => x.Doadora)
            .Include(x => x.Triagem)
            .Include(x => x.SaudeMaterna)
            .Include(x => x.HistoricoGestacional)
            .AsNoTracking()
            .Where(x => x.Doadora.NomeCompleto.Contains(nome))
            .ToListAsync();
    }

    public async Task UpdateAsync(Cadastro cadastro)
    {
        _context.Cadastros.Update(cadastro);

        await _context.SaveChangesAsync();
    }

    public async Task RemoveAsync(Cadastro cadastro)
    {
        _context.Cadastros.Remove(cadastro);

        await _context.SaveChangesAsync();
    }
}