using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoComSenhaApi.Migrations
{
    public partial class AddJogoTipojogoJogador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoJog1",
                table: "Partida");

            migrationBuilder.DropColumn(
                name: "CoJog2",
                table: "Partida");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Partida",
                newName: "ObsPartida");

            migrationBuilder.RenameColumn(
                name: "CoTpJogo",
                table: "Partida",
                newName: "JogoId");

            migrationBuilder.CreateTable(
                name: "Jogador",
                columns: table => new
                {
                    JogadorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NoJogador = table.Column<string>(nullable: true),
                    NickJogador = table.Column<string>(nullable: true),
                    PartidaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogador", x => x.JogadorId);
                    table.ForeignKey(
                        name: "FK_Jogador_Partida_PartidaId",
                        column: x => x.PartidaId,
                        principalTable: "Partida",
                        principalColumn: "PartidaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoJogo",
                columns: table => new
                {
                    TipoJogoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NoTipoJogo = table.Column<string>(nullable: true),
                    DsTipoJogo = table.Column<string>(nullable: true),
                    QtdMaxJogadores = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoJogo", x => x.TipoJogoId);
                });

            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    JogoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NoJogo = table.Column<string>(nullable: true),
                    DsJogo = table.Column<string>(nullable: true),
                    VencedorJogo = table.Column<string>(nullable: true),
                    TipoJogoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.JogoId);
                    table.ForeignKey(
                        name: "FK_Jogo_TipoJogo_TipoJogoId",
                        column: x => x.TipoJogoId,
                        principalTable: "TipoJogo",
                        principalColumn: "TipoJogoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Partida_JogoId",
                table: "Partida",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogador_PartidaId",
                table: "Jogador",
                column: "PartidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_TipoJogoId",
                table: "Jogo",
                column: "TipoJogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Partida_Jogo_JogoId",
                table: "Partida",
                column: "JogoId",
                principalTable: "Jogo",
                principalColumn: "JogoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partida_Jogo_JogoId",
                table: "Partida");

            migrationBuilder.DropTable(
                name: "Jogador");

            migrationBuilder.DropTable(
                name: "Jogo");

            migrationBuilder.DropTable(
                name: "TipoJogo");

            migrationBuilder.DropIndex(
                name: "IX_Partida_JogoId",
                table: "Partida");

            migrationBuilder.RenameColumn(
                name: "ObsPartida",
                table: "Partida",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "JogoId",
                table: "Partida",
                newName: "CoTpJogo");

            migrationBuilder.AddColumn<int>(
                name: "CoJog1",
                table: "Partida",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CoJog2",
                table: "Partida",
                nullable: false,
                defaultValue: 0);
        }
    }
}
