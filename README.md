# Nome do Projeto

Gotas De Leite

## Versão

1.0

## Data

23/05/2026

## Equipe

* Lucas Henrique Rodrigues Caldas
* Lucas Vitor Souza da Silva
* Paulo Henrique Almeida V. Leite
* Felipe Santos Rocha
* Ana Julia Chiezi

# Objetivo do Documento

Descrever os requisitos funcionais e não funcionais do sistema, definindo as funcionalidades, regras de negócio e restrições do projeto.

## Objetivo do Sistema

O sistema tem como objetivo automatizar o processo de triagem das doações de leite materno, tornando o atendimento mais rápido, organizado e eficiente. A solução busca reduzir o uso de papel por meio da digitalização das informações, otimizar o gerenciamento dos dados das doadoras e agilizar todo o processo de recebimento e controle das doações de leite materno.

## Problemática
Nos bancos de leite, uma das maiores dificuldades enfrentadas pelos profissionais é a realização de todos os processos de forma manual. O cadastro de doadoras, controle de estoque, registro das coletas, armazenamento das informações e acompanhamento dos dados acabam exigindo muito tempo e atenção da equipe.
Além de tornar o trabalho mais cansativo, os processos manuais aumentam as chances de erros, perda de informações e atrasos no atendimento. Muitas vezes, os profissionais precisam dividir o tempo entre cuidar das mães e bebês e preencher planilhas, papéis e registros repetitivos.
Pensando nisso, nosso projeto surgiu com o objetivo de automatizar e facilitar a rotina do banco de leite, trazendo mais organização, agilidade e segurança para os dados. Dessa forma, a equipe pode focar no que realmente importa: salvar vidas e oferecer um atendimento mais humano e eficiente.

## Soluções
### 1 - Site web
Nosso projeto foi desenvolvido com o objetivo de modernizar e facilitar o funcionamento do banco de leite através da tecnologia. Criamos um site web totalmente responsivo, permitindo que os usuários possam acessar a plataforma tanto pelo celular quanto pelo computador de forma prática e intuitiva.
O sistema é integrado a um banco de dados, onde todas as informações cadastradas pelas usuárias ficam armazenadas com mais segurança e organização, facilitando o gerenciamento dos dados pela equipe responsável.
Além disso, implementamos um agente de inteligência artificial para tornar a experiência ainda mais eficiente. O agentes auxilia no processo de cadastro, ajudando as usuárias a preencherem as informações de maneira mais rápida e simples. O segundo agente foi desenvolvido para responder dúvidas, oferecendo suporte e orientações de forma automática e acessível.
Com isso, nosso projeto busca reduzir processos manuais, otimizar o atendimento e trazer mais praticidade tanto para as mães quanto para os profissionais que atuam no banco de leite.
A principal inovação do nosso projeto está na automatização e centralização de todo o processo do banco de leite. Diferente do método tradicional, onde grande parte das informações é registrada manualmente em papéis ou planilhas, nosso sistema permite que todos os cadastros sejam realizados e armazenados de forma rápida, segura e organizada.
Através da plataforma, os profissionais passam a ter total controle sobre os dados das doadoras, podendo analisar as informações cadastradas e verificar de maneira mais eficiente se a usuária está apta para realizar a doação. Isso torna o processo de triagem mais ágil, reduzindo erros e facilitando a tomada de decisão da equipe.
Além disso, a utilização de agentes de inteligência artificial auxilia tanto no atendimento quanto no cadastro das usuárias, diminuindo a necessidade de processos manuais e otimizando o tempo dos profissionais. Dessa forma, o sistema reduz burocracias, melhora a organização das informações e permite que a equipe foque mais no atendimento humano e na qualidade do serviço prestado.

### 2 - Automação Industrial Assistida

Além da plataforma web e da automatização do cadastro das doadoras, nosso projeto também possui uma proposta de automação industrial voltada para auxiliar o processo de pasteurização do leite humano. O objetivo não é substituir a máquina utilizada atualmente, mas sim automatizar o monitoramento e o controle das informações do processo, reduzindo atividades manuais realizadas pelos profissionais.
Através do sistema, os funcionários conseguem acompanhar em tempo real informações importantes, como número do lote, horário de início da pasteurização, temperatura atual e tempo restante do processo. Todos esses dados ficam registrados automaticamente no sistema, eliminando a necessidade de anotações em papéis e reduzindo erros humanos.
Exemplo do monitoramento no sistema:
• Lote: #A928
• Início: 14:32
• Temperatura atual: 62.4°C
• Tempo restante: 12 minutos
Com isso, o processo continua seguindo o mesmo padrão utilizado atualmente pelos bancos de leite, porém de forma mais segura, organizada e auditável.
O sistema controla temperatura, validade, informações da pasteurização e possíveis incidentes registrados durante o processo. Isso facilita auditorias hospitalares, melhora a rastreabilidade e garante maior controle sanitário.
Toda a arquitetura foi pensada para ser acessível e viável financeiramente, utilizando sensores IoT, ESP32, tablets e integração com banco de dados em nuvem, permitindo monitoramento em tempo real e envio de alertas automáticos via WhatsApp.
Nosso MVP foca em resolver problemas reais enfrentados pelos bancos de leite, como excesso de processos manuais, dificuldade de rastreabilidade, controle da cadeia fria e organização das informações. Dessa forma, conseguimos unir tecnologia, automação e acessibilidade para modernizar o funcionamento dos bancos de leite sem exigir equipamentos industriais caros ou mudanças drásticas na operação atual. Muitos bancos ainda operam parcialmente manual :
Custo Realista do Projeto
Área
Valor Estimado
Software MVP
R$ 8 mil – R$ 12 mil
Sensores IoT
R$ 1 mil
Tablets
R$ 2 mil
Impressora de etiquetas
R$ 2 mil
Infraestrutura / Cloud
R$ 500
Contingência
R$ 3 mil

Investimento Total Estimado
👉 R$ 15 mil – R$ 22 mil




## Público-Alvo

* Agentes de saúde responsáveis pela coleta do leite materno

# Escopo do Projeto

## Funcionalidades Principais

* Cadastro de doadoras
* Triagem detalhada
* Registro de visitas domiciliares
* Geração de etiquetas
* Dashboard com todos os dados registrados
* Sistema de rastreabilidade

## Fora do Escopo

## Requisitos Funcionais

| ID   | Requisito                        | Descrição                                                                                                                                                  | Prioridade |
| ---- | -------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------- |
| RF01 | Cadastro de doadoras             | O sistema deve permitir o cadastro de doadoras contendo informações pessoais, endereço, telefone e dados clínicos básicos.                                 | Alta       |
| RF02 | Edição de cadastro               | O sistema deve permitir editar as informações das doadoras já cadastradas.                                                                                 | Alta       |
| RF03 | Consulta de doadoras             | O sistema deve permitir pesquisar e visualizar os dados das doadoras cadastradas.                                                                          | Alta       |
| RF04 | Triagem detalhada                | O sistema deve permitir registrar informações detalhadas da triagem, incluindo condições de saúde, uso de medicamentos e critérios de aptidão para doação. | Alta       |
| RF05 | Histórico de triagem             | O sistema deve armazenar o histórico de triagens realizadas para cada doadora.                                                                             | Média      |
| RF06 | Registro de visitas domiciliares | O sistema deve permitir registrar visitas domiciliares realizadas pelas equipes responsáveis.                                                              | Alta       |
| RF07 | Agendamento de visitas           | O sistema deve permitir cadastrar datas e horários para visitas domiciliares.                                                                              | Média      |
| RF09 | Geração de etiquetas             | O sistema deve gerar etiquetas contendo informações de identificação das doações coletadas.                                                                | Alta       |
| RF10 | Impressão de etiquetas           | O sistema deve permitir imprimir etiquetas para identificação dos recipientes de leite materno.                                                            | Média      |
| RF11 | Dashboard gerencial              | O sistema deve apresentar um painel com os dados registrados, indicadores e estatísticas das doações.                                                      | Alta       |
| RF12 | Visualização de relatórios       | O sistema deve permitir visualizar relatórios sobre doadoras, triagens e coletas realizadas.                                                               | Média      |
| RF13 | Sistema de rastreabilidade       | O sistema deve permitir rastrear cada doação desde a coleta até o armazenamento final.                                                                     | Alta       |
| RF14 | Controle de lotes                | O sistema deve registrar informações dos lotes de leite materno coletados.                                                                                 | Alta       |
| RF15 | Controle de usuários             | O sistema deve permitir autenticação e controle de acesso dos usuários do sistema.                                                                         | Alta       |
| RF16 | Registro de atividades           | O sistema deve armazenar logs das ações realizadas pelos usuários para auditoria e segurança.                                                              | Média      |

## Requisitos Não Funcionais

| ID    | Requisito      | Descrição                                                                                                |
| ----- | -------------- | -------------------------------------------------------------------------------------------------------- |
| RNF01 | Auditoria      | O sistema deve registrar logs das operações realizadas pelos usuários.                                   |
| RNF15 | Confiabilidade | O sistema deve minimizar falhas durante operações críticas, como cadastro e rastreabilidade das doações. |
| RNF09 | Escalabilidade | O sistema deve suportar aumento no número de usuários e registros sem perda significativa de desempenho. |
| RNF01 | Desempenho     | O sistema deve responder às operações do usuário em no máximo 3 segundos.                                |

## Regras de Negócio

| ID   | Regra                     | Descrição                                                                                              |
| ---- | ------------------------- | ------------------------------------------------------------------------------------------------------ |
| RN01 | Cadastro obrigatório      | Toda doadora deve possuir cadastro completo antes de realizar qualquer doação.                         |
| RN02 | Validação da triagem      | Apenas doadoras aprovadas na triagem poderão realizar doações.                                         |
| RN03 | Atualização cadastral     | Os dados da doadora devem ser mantidos atualizados para continuidade das doações.                      |
| RN04 | Registro de visitas       | Toda visita domiciliar realizada deve ser registrada no sistema.                                       |
| RN05 | Identificação das doações | Cada coleta de leite materno deve possuir uma etiqueta única de identificação.                         |
| RN06 | Rastreamento obrigatório  | Todas as doações devem ser rastreáveis desde a coleta até o armazenamento final.                       |
| RN07 | Controle de lotes         | O sistema deve associar cada doação a um lote específico para controle e rastreabilidade.              |
| RN08 | Controle de acesso        | Apenas usuários autenticados poderão acessar o sistema.                                                |
| RN09 | Permissões de usuário     | Usuários comuns não poderão acessar funcionalidades administrativas.                                   |
| RN10 | Histórico de alterações   | Todas as alterações realizadas no sistema devem ser registradas em log.                                |
| RN11 | Integridade dos dados     | Informações de doadoras e doações não podem ser excluídas sem autorização administrativa.              |
| RN12 | Campos obrigatórios       | Nome, telefone, endereço e informações clínicas básicas devem ser obrigatórios no cadastro da doadora. |
| RN13 | Geração de etiquetas      | As etiquetas devem conter informações suficientes para identificação da doação e da coleta.            |
| RN14 | Registro cronológico      | As informações de triagem, coleta e visitas devem possuir data e horário registrados automaticamente.  |
| RN15 | Confidencialidade         | Dados pessoais e clínicos das doadoras devem ser acessados apenas por usuários autorizados.            |

## Casos de Uso

| Caso de Uso                 | Descrição                                                                    | Atores                                 |
| --------------------------- | ---------------------------------------------------------------------------- | -------------------------------------- |
| Cadastro de Doadora         | Permite cadastrar novas doadoras no sistema.                                 | Atendente, Profissional de saúde       |
| Realizar Triagem            | Permite registrar informações clínicas e aprovar ou reprovar a doadora.      | Profissional de saúde                  |
| Registrar Visita Domiciliar | Permite registrar visitas realizadas às doadoras.                            | Profissional de saúde                  |
| Gerar Etiquetas             | Permite gerar e imprimir etiquetas para identificação das doações.           | Atendente, Profissional de saúde       |
| Visualizar Dashboard        | Permite visualizar gráficos, indicadores e estatísticas do sistema.          | Administrador                          |
| Rastrear Doação             | Permite acompanhar o histórico da doação desde a coleta até o armazenamento. | Administrador, Profissional autorizado |
| Login no Sistema            | Permite autenticar usuários para acesso ao sistema.                          | Usuário do sistema                     |
| Emitir Relatórios           | Permite visualizar relatórios sobre doadoras, coletas e triagens.            | Administrador                          |

# Modelagem do Sistema

## Entidade: Mãe

| Campo          | Tipo    |
| -------------- | ------- |
| id             | Integer |
| nome           | String  |
| cpf            | String  |
| cartaoSus      | String  |
| dataNascimento | Date    |
| telefone       | String  |

### Relacionamentos

* Uma mãe pode possuir vários bebês.
* Uma mãe possui um histórico clínico.
* Uma mãe possui um registro de hábitos.
* Uma mãe possui uma condição socioeconômica.

## Entidade: Bebê

| Campo          | Tipo    |
| -------------- | ------- |
| id             | Integer |
| nome           | String  |
| dataNascimento | Date    |
| peso           | Decimal |
| apgar          | Integer |
| malformacao    | Boolean |
| maeId          | Integer |

### Relacionamentos

* Um bebê pertence a uma mãe.
* Um bebê pode possuir vários exames.

## Entidade: MedicalHistory (Histórico Clínico)

| Campo               | Tipo    |
| ------------------- | ------- |
| id                  | Integer |
| transfusaoSanguinea | Boolean |
| dataTransfusao      | Date    |
| tatuagem            | Boolean |
| dataTatuagem        | Date    |
| hipertensao         | Boolean |
| diabetes            | Boolean |
| hepatite            | Boolean |
| infeccoes           | String  |
| maeId               | Integer |

### Relacionamentos

* Um histórico clínico pertence a uma mãe.

---

## Entidade: Habit (Hábitos)

| Campo             | Tipo    |
| ----------------- | ------- |
| id                | Integer |
| fumante           | Boolean |
| cigarrosPorDia    | Integer |
| consumoAlcool     | Boolean |
| medicamentosEmUso | String  |
| maeId             | Integer |

### Relacionamentos

* Um registro de hábitos pertence a uma mãe.

---

## Entidade: SocioeconomicData (Condição Socioeconômica)

| Campo        | Tipo    |
| ------------ | ------- |
| id           | Integer |
| possuiAgua   | Boolean |
| possuiEsgoto | Boolean |
| rendaMensal  | Decimal |
| tipoMoradia  | String  |
| maeId        | Integer |

### Relacionamentos

* Um registro socioeconômico pertence a uma mãe.

## Entidade: ColdChainEquipment (Equipamento)

| Campo            | Tipo    |
| ---------------- | ------- |
| id               | Integer |
| tipo             | String  |
| temperaturaAtual | Decimal |
| ultimaInspecao   | Date    |
| observacoes      | String  |

## Entidade: Exam (Exame)

| Campo      | Tipo    |
| ---------- | ------- |
| id         | Integer |
| tipo       | String  |
| dataColeta | Date    |
| resultado  | String  |
| status     | String  |
| bebeId     | Integer |

### Relacionamentos

* Um exame pertence a um bebê.
* Um exame pode possuir várias amostras.

## Entidade: Sample (Amostra)

| Campo         | Tipo    |
| ------------- | ------- |
| id            | Integer |
| codigo        | String  |
| dataColeta    | Date    |
| numeroAmostra | Integer |
| examId        | Integer |

### Relacionamentos

* Uma amostra pertence a um exame.

# Relacionamentos Gerais

* Mae 1:N Bebe
* Mae 1:1 MedicalHistory
* Mae 1:1 Habit
* Mae 1:1 SocioeconomicData
* Bebe 1:N Exam
* Exam 1:N Sample
