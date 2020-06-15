using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webComApsNetCore.Migrations
{
    public partial class MigrationCategoriaLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaLivroId",
                table: "Livros",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Department",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livros_CategoriaLivroId",
                table: "Livros",
                column: "CategoriaLivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Categoria_CategoriaLivroId",
                table: "Livros",
                column: "CategoriaLivroId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Categoria_CategoriaLivroId",
                table: "Livros");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_Livros_CategoriaLivroId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "CategoriaLivroId",
                table: "Livros");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Department",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
