using GotasDaVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GotasDaVida.Infrastructure.Persistence.Configurations;

public class SaudeMaternaConfiguration : IEntityTypeConfiguration<SaudeMaterna>
{
    public void Configure(EntityTypeBuilder<SaudeMaterna> builder)
    {
        builder.ToTable("saude_materna");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.CadastroId)
            .HasColumnName("cadastro_id");

        builder.Property(x => x.Hipertensao)
            .HasColumnName("hipertensao");

        builder.Property(x => x.Diabetes)
            .HasColumnName("diabetes");

        builder.Property(x => x.Hepatite)
            .HasColumnName("hepatite");

        builder.Property(x => x.CirurgiaRecente)
            .HasColumnName("cirurgia_recente");

        builder.Property(x => x.TratamentoMedicoAtivo)
            .HasColumnName("tratamento_medico_ativo");

        builder.Property(x => x.Detalhes)
            .HasColumnName("detalhes");
    }
}