using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GotasDaVida.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cadastros",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadastros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "doadoras",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cadastro_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome_completo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    data_nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    whatsapp = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    bairro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    estado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    sus_possui = table.Column<bool>(type: "bit", nullable: false),
                    sus_numero = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doadoras", x => x.id);
                    table.ForeignKey(
                        name: "FK_doadoras_cadastros_cadastro_id",
                        column: x => x.cadastro_id,
                        principalTable: "cadastros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historico_gestacional",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cadastro_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    numero_gestacoes = table.Column<int>(type: "int", nullable: false),
                    complicacoes = table.Column<bool>(type: "bit", nullable: false),
                    descricao_complicacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historico_gestacional", x => x.id);
                    table.ForeignKey(
                        name: "FK_historico_gestacional_cadastros_cadastro_id",
                        column: x => x.cadastro_id,
                        principalTable: "cadastros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "saude_materna",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cadastro_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    hipertensao = table.Column<bool>(type: "bit", nullable: false),
                    diabetes = table.Column<bool>(type: "bit", nullable: false),
                    hepatite = table.Column<bool>(type: "bit", nullable: false),
                    cirurgia_recente = table.Column<bool>(type: "bit", nullable: false),
                    tratamento_medico_ativo = table.Column<bool>(type: "bit", nullable: false),
                    detalhes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saude_materna", x => x.id);
                    table.ForeignKey(
                        name: "FK_saude_materna_cadastros_cadastro_id",
                        column: x => x.cadastro_id,
                        principalTable: "cadastros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "triagens",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cadastro_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    lactacao_ativa = table.Column<bool>(type: "bit", nullable: false),
                    uso_drogas_ilicitas = table.Column<bool>(type: "bit", nullable: false),
                    fuma = table.Column<bool>(type: "bit", nullable: false),
                    cigarros_por_dia = table.Column<int>(type: "int", nullable: true),
                    alcool_consome = table.Column<bool>(type: "bit", nullable: false),
                    alcool_frequencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tatuagem_realizou = table.Column<bool>(type: "bit", nullable: false),
                    tatuagem_mes_ano = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transfusao_realizou = table.Column<bool>(type: "bit", nullable: false),
                    transfusao_mes_ano = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicamento_usa = table.Column<bool>(type: "bit", nullable: false),
                    medicamento_qual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vacina_febre_amarela = table.Column<bool>(type: "bit", nullable: false),
                    vacina_dtpa = table.Column<bool>(type: "bit", nullable: false),
                    resultado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_triagens", x => x.id);
                    table.ForeignKey(
                        name: "FK_triagens_cadastros_cadastro_id",
                        column: x => x.cadastro_id,
                        principalTable: "cadastros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_doadoras_cadastro_id",
                table: "doadoras",
                column: "cadastro_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_historico_gestacional_cadastro_id",
                table: "historico_gestacional",
                column: "cadastro_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_saude_materna_cadastro_id",
                table: "saude_materna",
                column: "cadastro_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_triagens_cadastro_id",
                table: "triagens",
                column: "cadastro_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doadoras");

            migrationBuilder.DropTable(
                name: "historico_gestacional");

            migrationBuilder.DropTable(
                name: "saude_materna");

            migrationBuilder.DropTable(
                name: "triagens");

            migrationBuilder.DropTable(
                name: "cadastros");
        }
    }
}
