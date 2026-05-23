# Gotas de Vida (Gotas de Leite)

Sistema para automatizar a **triagem de doações de leite materno** em Bancos de Leite Humano, centralizando cadastros, triagens, coletas, rastreabilidade e apoio ao processo de pasteurização com monitoramento assistido.

---

## Versão
**1.0**

## Data
**23/05/2026**

## Equipe
- Lucas Henrique Rodrigues Caldas  
- Lucas Vitor Souza da Silva  
- Paulo Henrique Almeida V. Leite  
- Felipe Santos Rocha  
- Ana Julia Chiezi  

---

## Visão Geral do Projeto

Nos Bancos de Leite, uma parte relevante do fluxo ainda acontece de forma **manual** (papel, planilhas e registros desconectados), o que gera:
- retrabalho e lentidão no atendimento;
- maior chance de erros e perda de informações;
- dificuldade de auditoria e rastreabilidade;
- baixa integração entre triagem, coleta, armazenamento e processamento.

O **Gotas de Vida** propõe uma solução digital composta por:
1. **Plataforma Web** (responsiva) para cadastro, triagem, visitas, dashboards e rastreabilidade.
2. **Apoio com Inteligência Artificial** para auxiliar no preenchimento e organização de informações (ex.: cadastro/triagem).
3. **Automação Industrial Assistida** para acompanhamento do processo de pasteurização (monitoramento de lote/temperatura/tempo, com rastreio e registro de incidentes).

> Repositório majoritariamente em **C#** (100%).

---

## Objetivo do Sistema

Automatizar e organizar o processo de triagem e gestão de doações de leite materno, aumentando:
- **agilidade** no atendimento;
- **segurança** e integridade dos dados;
- **rastreabilidade** ponta a ponta (da coleta ao armazenamento/lote);
- **auditabilidade** (logs e histórico).

---

## Público-alvo

- Agentes/profissionais de saúde responsáveis pela coleta e triagem do leite materno  
- Atendentes do banco de leite  
- Administradores e profissionais autorizados (gestão, auditoria e relatórios)

---

## Escopo do Projeto

### Funcionalidades principais
- Cadastro e gestão de doadoras (mães)
- Triagem detalhada e histórico de triagens
- Registro e agendamento de visitas domiciliares
- Geração e impressão de etiquetas (identificação única)
- Dashboard gerencial (indicadores e estatísticas)
- Relatórios operacionais e gerenciais
- Sistema de rastreabilidade (coleta → lote → armazenamento)
- Controle de usuários e permissões
- Logs de atividades para auditoria
- Módulo de acompanhamento de pasteurização (automação assistida)

### Fora do escopo (nesta versão)
- Integração oficial com sistemas governamentais (ex.: e-SUS/Conecte SUS) sem definição de APIs
- Aplicativo mobile nativo (Android/iOS) dedicado
- Dispositivos/sensores físicos instalados (quando não disponíveis no ambiente do MVP)
- Prescrição/conduta clínica automatizada (o sistema registra e apoia, mas não substitui decisão profissional)

---

## Requisitos

### Requisitos Funcionais (RF)
- **RF01** — Cadastro de doadoras (dados pessoais, endereço, telefone e dados clínicos básicos)  
- **RF02** — Edição de cadastro  
- **RF03** — Consulta/pesquisa de doadoras  
- **RF04** — Triagem detalhada (condições de saúde, uso de medicamentos, critérios de aptidão)  
- **RF05** — Histórico de triagens por doadora  
- **RF06** — Registro de visitas domiciliares  
- **RF07** — Agendamento de visitas domiciliares  
- **RF09** — Geração de etiquetas para doações  
- **RF10** — Impressão de etiquetas  
- **RF11** — Dashboard gerencial  
- **RF12** — Visualização/emissão de relatórios  
- **RF13** — Rastreabilidade completa da doação  
- **RF14** — Controle de lotes  
- **RF15** — Autenticação e controle de acesso  
- **RF16** — Registro de atividades (logs)

### Requisitos Não Funcionais (RNF)
- **RNF01 (Auditoria)** — Registrar logs de operações realizadas por usuários  
- **RNF15 (Confiabilidade)** — Minimizar falhas em operações críticas (cadastro/rastreabilidade)  
- **RNF09 (Escalabilidade)** — Suportar aumento de usuários e registros sem perda significativa de desempenho  
- **RNF01 (Desempenho)** — Responder ações em até 3 segundos  

> Observação: existe duplicidade do identificador **RNF01** no documento original (Auditoria e Desempenho). Recomenda-se renomear para evitar ambiguidade (ex.: RNF01 Auditoria, RNF02 Desempenho).

---

## Regras de Negócio (RN)
- **RN01** — Cadastro completo obrigatório antes de doar  
- **RN02** — Apenas doadoras aprovadas na triagem podem doar  
- **RN03** — Dados devem ser mantidos atualizados  
- **RN04** — Toda visita domiciliar deve ser registrada  
- **RN05** — Cada coleta deve ter etiqueta única  
- **RN06** — Todas as doações devem ser rastreáveis  
- **RN07** — Doações devem ser associadas a lotes  
- **RN08** — Somente usuários autenticados acessam o sistema  
- **RN09** — Usuários comuns não acessam funções administrativas  
- **RN10** — Alterações devem gerar log  
- **RN11** — Dados críticos não podem ser excluídos sem autorização administrativa  
- **RN12** — Campos obrigatórios no cadastro (nome, telefone, endereço, informações clínicas básicas)  
- **RN13** — Etiquetas devem conter informações suficientes para identificação  
- **RN14** — Registros com data/hora automáticas (trilha cronológica)  
- **RN15** — Confidencialidade: dados pessoais/clínicos somente para autorizados  

---

## Casos de Uso (resumo)

| Caso de Uso | Descrição | Atores |
|---|---|---|
| Cadastro de Doadora | Cadastrar novas doadoras | Atendente, Profissional de saúde |
| Realizar Triagem | Registrar triagem e aprovar/reprovar | Profissional de saúde |
| Registrar Visita Domiciliar | Registrar visitas realizadas | Profissional de saúde |
| Gerar/Imprimir Etiquetas | Criar etiquetas de identificação | Atendente, Profissional de saúde |
| Visualizar Dashboard | Indicadores, gráficos e estatísticas | Administrador |
| Rastrear Doação | Histórico da doação da coleta ao armazenamento | Administrador, Profissional autorizado |
| Login | Autenticação e acesso | Usuário do sistema |
| Emitir Relatórios | Relatórios de doadoras/coletas/triagens | Administrador |

---

## Módulo: Automação Industrial Assistida (Pasteurização)

A proposta de automação assistida permite acompanhar em tempo real:
- Número do lote
- Horário de início
- Temperatura atual
- Tempo restante
- Registro de incidentes e auditoria do processo

Exemplo de monitoramento:
- **Lote:** #A928  
- **Início:** 14:32  
- **Temperatura atual:** 62.4°C  
- **Tempo restante:** 12 minutos  

Arquitetura pensada para viabilidade e custo acessível, com uso de:
- Sensores IoT
- ESP32
- Tablets
- Integração com banco de dados em nuvem

---

## Modelagem do Sistema (Entidades)

### Mãe (Doadora)
Campos: `id`, `nome`, `cpf`, `cartaoSus`, `dataNascimento`, `telefone`  
Relacionamentos:
- Mãe **1:N** Bebê
- Mãe **1:1** MedicalHistory
- Mãe **1:1** Habit
- Mãe **1:1** SocioeconomicData

### Bebê
Campos: `id`, `nome`, `dataNascimento`, `peso`, `apgar`, `malformacao`, `maeId`  
Relacionamentos:
- Bebê **1:N** Exam

### MedicalHistory (Histórico Clínico)
Campos: `id`, `transfusaoSanguinea`, `dataTransfusao`, `tatuagem`, `dataTatuagem`, `hipertensao`, `diabetes`, `hepatite`, `infeccoes`, `maeId`  
Relacionamento:
- MedicalHistory **N:1** Mãe

### Habit (Hábitos)
Campos: `id`, `fumante`, `cigarrosPorDia`, `consumoAlcool`, `medicamentosEmUso`, `maeId`  
Relacionamento:
- Habit **N:1** Mãe

### SocioeconomicData (Condição Socioeconômica)
Campos: `id`, `possuiAgua`, `possuiEsgoto`, `rendaMensal`, `tipoMoradia`, `maeId`  
Relacionamento:
- SocioeconomicData **N:1** Mãe

### ColdChainEquipment (Equipamento / Cadeia fria)
Campos: `id`, `tipo`, `temperaturaAtual`, `ultimaInspecao`, `observacoes`

### Exam (Exame)
Campos: `id`, `tipo`, `dataColeta`, `resultado`, `status`, `bebeId`  
Relacionamentos:
- Exam **N:1** Bebê
- Exam **1:N** Sample

### Sample (Amostra)
Campos: `id`, `codigo`, `dataColeta`, `numeroAmostra`, `examId`  
Relacionamento:
- Sample **N:1** Exam

---

## Estimativa de Custo (MVP)

| Área | Valor estimado |
|---|---|
| Software MVP | R$ 8 mil – R$ 12 mil |
| Sensores IoT | R$ 1 mil |
| Tablets | R$ 2 mil |
| Impressora de etiquetas | R$ 2 mil |
| Infraestrutura / Cloud | R$ 500 |
| Contingência | R$ 3 mil |

**Investimento total estimado:** R$ 15 mil – R$ 22 mil

---

## Próximos Passos (sugestão)
- Padronizar IDs de RNF (evitar duplicidade)
- Detalhar entidades de **Doação**, **Lote**, **Etiqueta** e **Rastreio** (não aparecem explicitamente na modelagem atual)
- Definir perfis de usuário e permissões (Admin / Profissional / Atendente)
- Definir requisitos de segurança (criptografia, LGPD, backups, retenção de logs)
- Definir integrações (impressora, sensores, nuvem, relatórios)

---
