using GotasDaVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GotasDaVida.Infrastructure.Persistence.Configurations;

public class CadastroConfiguration : IEntityTypeConfiguration<Cadastro>
{
    public void Configure(EntityTypeBuilder<Cadastro> builder)
    {
        builder.ToTable("cadastros");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Status)
            .HasColumnName("status")
            .HasConversion<string>()
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(x => x.DataCadastro)
            .HasColumnName("data_cadastro")
            .IsRequired();

        builder.HasOne(x => x.Doadora)
            .WithOne()
            .HasForeignKey<Doadora>(x => x.CadastroId);

        
        builder.HasOne(x => x.Triagem)
            .WithOne()
            .HasForeignKey<Triagem>(x => x.CadastroId);

        builder.HasOne(x => x.SaudeMaterna)
            .WithOne()
            .HasForeignKey<SaudeMaterna>(x => x.CadastroId);

        builder.HasOne(x => x.HistoricoGestacional)
            .WithOne()
            .HasForeignKey<HistoricoGestacional>(x => x.CadastroId);
    }
}