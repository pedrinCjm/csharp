using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoComSenhaApi.Migrations
{
    public partial class CorrecaoPartidaJogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VencedorJogo",
                table: "Jogo");

            migrationBuilder.AddColumn<string>(
                name: "VencedorJogo",
                table: "Partida",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VencedorJogo",
                table: "Partida");

            migrationBuilder.AddColumn<string>(
                name: "VencedorJogo",
                table: "Jogo",
                nullable: true);
        }
    }
}
