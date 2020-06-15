using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoComSenhaApi.Migrations
{
    public partial class AddJogoTipojogoJogadorCorrecao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HistoricoPartidaId",
                table: "Partida",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HistoricoPartida",
                columns: table => new
                {
                    HistoricoPartidaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    JogadorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoPartida", x => x.HistoricoPartidaId);
                    table.ForeignKey(
                        name: "FK_HistoricoPartida_Jogador_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogador",
                        principalColumn: "JogadorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Partida_HistoricoPartidaId",
                table: "Partida",
                column: "HistoricoPartidaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoPartida_JogadorId",
                table: "HistoricoPartida",
                column: "JogadorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Partida_HistoricoPartida_HistoricoPartidaId",
                table: "Partida",
                column: "HistoricoPartidaId",
                principalTable: "HistoricoPartida",
                principalColumn: "HistoricoPartidaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partida_HistoricoPartida_HistoricoPartidaId",
                table: "Partida");

            migrationBuilder.DropTable(
                name: "HistoricoPartida");

            migrationBuilder.DropIndex(
                name: "IX_Partida_HistoricoPartidaId",
                table: "Partida");

            migrationBuilder.DropColumn(
                name: "HistoricoPartidaId",
                table: "Partida");
        }
    }
}
