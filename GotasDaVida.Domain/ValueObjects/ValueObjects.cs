namespace GotasDaVida.Domain.ValueObjects;

public record Endereco(
    string Bairro,
    string Cidade,
    string Estado
);

public record CartaoSus(
    bool Possui,
    string? Numero
);

public record Vacinas(
    bool FebreAmarela,
    bool Dtpa
);

public record Alcool(
    bool Consome,
    Enums.FrequenciaAlcool Frequencia
);

public record Tabagismo(
    bool Fuma,
    int? CigarrosPorDia
);

public record TatuagemPiercing(
    bool Realizou,
    string? MesAno
);

public record Transfusao(
    bool Realizou,
    string? MesAno
);

public record MedicamentoContinuo(
    bool Usa,
    string? Qual
);
