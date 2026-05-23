using GotasDaVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GotasDaVida.Infrastructure.Persistence.Configurations;

public class HistoricoGestacionalConfiguration : IEntityTypeConfiguration<HistoricoGestacional>
{
    public void Configure(EntityTypeBuilder<HistoricoGestacional> builder)
    {
        builder.ToTable("historico_gestacional");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.CadastroId)
            .HasColumnName("cadastro_id");

        builder.Property(x => x.NumeroGestacoes)
            .HasColumnName("numero_gestacoes");

        builder.Property(x => x.Complicacoes)
            .HasColumnName("complicacoes");

        builder.Property(x => x.DescricaoComplicacoes)
            .HasColumnName("descricao_complicacoes");
    }
}