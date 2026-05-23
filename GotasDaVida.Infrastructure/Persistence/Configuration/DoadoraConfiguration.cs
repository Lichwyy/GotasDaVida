using GotasDaVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GotasDaVida.Infrastructure.Persistence.Configurations;

public class DoadoraConfiguration : IEntityTypeConfiguration<Doadora>
{
    public void Configure(EntityTypeBuilder<Doadora> builder)
    {
        builder.ToTable("doadoras");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.CadastroId)
            .HasColumnName("cadastro_id");

        builder.Property(x => x.NomeCompleto)
            .HasColumnName("nome_completo")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.DataNascimento)
            .HasColumnName("data_nascimento");

        builder.OwnsOne(x => x.Whatsapp, whatsapp =>
        {
            whatsapp.Property(x => x.Numero)
                .HasColumnName("whatsapp")
                .HasMaxLength(20)
                .IsRequired();
        });

        builder.OwnsOne(x => x.Email, email =>
        {
            email.Property(x => x.Endereco)
                .HasColumnName("email")
                .HasMaxLength(255)
                .IsRequired();
        });

        builder.Property(x => x.Bairro)
            .HasColumnName("bairro")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Cidade)
            .HasColumnName("cidade")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Estado)
            .HasColumnName("estado")
            .HasMaxLength(2)
            .IsRequired();

        builder.Property(x => x.SusPossui)
            .HasColumnName("sus_possui");

        builder.Property(x => x.SusNumero)
            .HasColumnName("sus_numero")
            .HasMaxLength(20);
    }
}