using GotasDaVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GotasDaVida.Infrastructure.Persistence.Configurations;

public class TriagemConfiguration : IEntityTypeConfiguration<Triagem>
{
    public void Configure(EntityTypeBuilder<Triagem> builder)
    {
        builder.ToTable("triagens");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.CadastroId)
            .HasColumnName("cadastro_id");

        builder.Property(x => x.LactacaoAtiva)
            .HasColumnName("lactacao_ativa");

        builder.Property(x => x.UsoDrogasIlicitas)
            .HasColumnName("uso_drogas_ilicitas");

        builder.Property(x => x.Fuma)
            .HasColumnName("fuma");

        builder.Property(x => x.CigarrosPorDia)
            .HasColumnName("cigarros_por_dia");

        builder.Property(x => x.AlcoolConsome)
            .HasColumnName("alcool_consome");

        builder.Property(x => x.AlcoolFrequencia)
            .HasColumnName("alcool_frequencia")
            .HasConversion<string>();

        builder.Property(x => x.TatuagemRealizou)
            .HasColumnName("tatuagem_realizou");

        builder.Property(x => x.TatuagemMesAno)
            .HasColumnName("tatuagem_mes_ano");

        builder.Property(x => x.TransfusaoRealizou)
            .HasColumnName("transfusao_realizou");

        builder.Property(x => x.TransfusaoMesAno)
            .HasColumnName("transfusao_mes_ano");

        builder.Property(x => x.MedicamentoUsa)
            .HasColumnName("medicamento_usa");

        builder.Property(x => x.MedicamentoQual)
            .HasColumnName("medicamento_qual");

        builder.Property(x => x.VacinaFebreAmarela)
            .HasColumnName("vacina_febre_amarela");

        builder.Property(x => x.VacinaDtpa)
            .HasColumnName("vacina_dtpa");

        builder.Property(x => x.Resultado)
            .HasColumnName("resultado")
            .HasConversion<string>();
    }
}