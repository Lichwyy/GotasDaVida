using GotasDaVida.Domain.Common;
using GotasDaVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GotasDaVida.Infrastructure.Persistence.Context;

public sealed class GotasDaVidaDbContext : DbContext
{
    public GotasDaVidaDbContext(DbContextOptions<GotasDaVidaDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cadastro> Cadastros { get; set; }

    public DbSet<Doadora> Doadoras { get; set; }


    public DbSet<Triagem> Triagens { get; set; }

    public DbSet<SaudeMaterna> SaudeMaterna { get; set; }

    public DbSet<HistoricoGestacional> HistoricosGestacionais { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(GotasDaVidaDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}