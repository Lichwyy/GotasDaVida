namespace GotasDaVida.Application.DTOs;

// Raiz
public record CadastroInputDto(
    TriagemInputDto Triagem,
    DoadoraInputDto Doadora,
    BebeInputDto Bebe,
    SaudeMaternaInputDto SaudeMaterna,
    HistoricoGestacionalInputDto HistoricoGestacional
);

// Triagem e seus objetos aninhados
public record TriagemInputDto(
    bool LactacaoAtiva,
    bool UsoDrogasIlicitas,
    TabagismoInputDto Tabagismo,
    AlcoolInputDto Alcool,
    TatuagemPiercingInputDto TatuagemPiercing,
    TransfusaoInputDto Transfusao,
    MedicamentoContinuoInputDto MedicamentoContinuo,
    VacinasInputDto Vacinas
);

public record TabagismoInputDto(bool Fuma, int? CigarrosPorDia);
public record AlcoolInputDto(bool Consome, string Frequencia);
public record TatuagemPiercingInputDto(bool Realizou, string? MesAno);
public record TransfusaoInputDto(bool Realizou, string? MesAno);
public record MedicamentoContinuoInputDto(bool Usa, string? Qual);
public record VacinasInputDto(bool FebreAmarela, bool Dtpa);

// Doadora e seus objetos aninhados
public record DoadoraInputDto(
    string NomeCompleto,
    string DataNascimento,
    ContatoInputDto Contato,
    EnderecoInputDto Endereco,
    CartaoSusInputDto CartaoSus
);

public record ContatoInputDto(string Whatsapp, string Email);
public record EnderecoInputDto(string Bairro, string Cidade, string Estado);
public record CartaoSusInputDto(bool Possui, string? Numero);

// Bebê
public record BebeInputDto(
    string Nome,
    string DataNascimento,
    int PesoNascerG
);

// Saúde Materna
public record SaudeMaternaInputDto(
    bool Hipertensao,
    bool Diabetes,
    bool Hepatite,
    bool CirurgiaRecente,
    bool TratamentoMedicoAtivo,
    string? DetalhesSaude
);

// Histórico Gestacional
public record HistoricoGestacionalInputDto(
    int NumeroGestacoes,
    bool Complicacoes,
    string? DescricaoComplicacoes
);
