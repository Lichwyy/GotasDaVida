using System.Text.Json.Serialization;

namespace GotasDaVida.Application.DTOs;

public class CreateCadastroDto
{
    [JsonPropertyName("cadastro")]
    public CadastroRequest Cadastro { get; set; } = default!;
}

public class CadastroRequest
{
    [JsonPropertyName("triagem")]
    public TriagemRequest Triagem { get; set; } = default!;

    [JsonPropertyName("doadora")]
    public DoadoraRequest Doadora { get; set; } = default!;

    [JsonPropertyName("saude_materna")]
    public SaudeMaternaRequest SaudeMaterna { get; set; } = default!;

    [JsonPropertyName("historico_gestacional")]
    public HistoricoGestacionalRequest HistoricoGestacional { get; set; } = default!;
}

#region TRIAGEM

public class TriagemRequest
{
    [JsonPropertyName("lactacao_ativa")]
    public bool LactacaoAtiva { get; set; }

    [JsonPropertyName("uso_drogas_ilicitas")]
    public bool UsoDrogasIlicitas { get; set; }

    [JsonPropertyName("tabagismo")]
    public TabagismoRequest Tabagismo { get; set; } = default!;

    [JsonPropertyName("alcool")]
    public AlcoolRequest Alcool { get; set; } = default!;

    [JsonPropertyName("tatuagem_piercing")]
    public TatuagemPiercingRequest TatuagemPiercing { get; set; } = default!;

    [JsonPropertyName("transfusao")]
    public TransfusaoRequest Transfusao { get; set; } = default!;

    [JsonPropertyName("medicamento_continuo")]
    public MedicamentoContinuoRequest MedicamentoContinuo { get; set; } = default!;

    [JsonPropertyName("vacinas")]
    public VacinasRequest Vacinas { get; set; } = default!;
}

public class TabagismoRequest
{
    [JsonPropertyName("fuma")]
    public bool Fuma { get; set; }

    [JsonPropertyName("cigarros_por_dia")]
    public int? CigarrosPorDia { get; set; }
}

public class AlcoolRequest
{
    [JsonPropertyName("consome")]
    public bool Consome { get; set; }

    [JsonPropertyName("frequencia")]
    public string Frequencia { get; set; } = string.Empty;
}

public class TatuagemPiercingRequest
{
    [JsonPropertyName("realizou")]
    public bool Realizou { get; set; }

    [JsonPropertyName("mes_ano")]
    public string? MesAno { get; set; }
}

public class TransfusaoRequest
{
    [JsonPropertyName("realizou")]
    public bool Realizou { get; set; }

    [JsonPropertyName("mes_ano")]
    public string? MesAno { get; set; }
}

public class MedicamentoContinuoRequest
{
    [JsonPropertyName("usa")]
    public bool Usa { get; set; }

    [JsonPropertyName("qual")]
    public string? Qual { get; set; }
}

public class VacinasRequest
{
    [JsonPropertyName("febre_amarela")]
    public bool FebreAmarela { get; set; }

    [JsonPropertyName("dtpa")]
    public bool Dtpa { get; set; }
}

#endregion

#region DOADORA

public class DoadoraRequest
{
    [JsonPropertyName("nome_completo")]
    public string NomeCompleto { get; set; } = string.Empty;

    [JsonPropertyName("data_nascimento")]
    public DateTime DataNascimento { get; set; }

    [JsonPropertyName("contato")]
    public ContatoRequest Contato { get; set; } = default!;

    [JsonPropertyName("endereco")]
    public EnderecoRequest Endereco { get; set; } = default!;

    [JsonPropertyName("cartao_sus")]
    public CartaoSusRequest CartaoSus { get; set; } = default!;
}

public class ContatoRequest
{
    [JsonPropertyName("whatsapp")]
    public string Whatsapp { get; set; } = string.Empty;

    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;
}

public class EnderecoRequest
{
    [JsonPropertyName("bairro")]
    public string Bairro { get; set; } = string.Empty;

    [JsonPropertyName("cidade")]
    public string Cidade { get; set; } = string.Empty;

    [JsonPropertyName("estado")]
    public string Estado { get; set; } = string.Empty;
}

public class CartaoSusRequest
{
    [JsonPropertyName("possui")]
    public bool Possui { get; set; }

    [JsonPropertyName("numero")]
    public string? Numero { get; set; }
}

#endregion

#region SAUDE

public class SaudeMaternaRequest
{
    [JsonPropertyName("hipertensao")]
    public bool Hipertensao { get; set; }

    [JsonPropertyName("diabetes")]
    public bool Diabetes { get; set; }

    [JsonPropertyName("hepatite")]
    public bool Hepatite { get; set; }

    [JsonPropertyName("cirurgia_recente")]
    public bool CirurgiaRecente { get; set; }

    [JsonPropertyName("tratamento_medico_ativo")]
    public bool TratamentoMedicoAtivo { get; set; }

    [JsonPropertyName("detalhes_saude")]
    public string? DetalhesSaude { get; set; }
}

#endregion

#region HISTORICO

public class HistoricoGestacionalRequest
{
    [JsonPropertyName("numero_gestacoes")]
    public int NumeroGestacoes { get; set; }

    [JsonPropertyName("complicacoes")]
    public bool Complicacoes { get; set; }

    [JsonPropertyName("descricao_complicacoes")]
    public string? DescricaoComplicacoes { get; set; }
}

#endregion