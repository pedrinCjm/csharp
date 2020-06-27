using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webComApsNetCore.Migrations
{
    public partial class migrationIncludeUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Generico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    departmentId = table.Column<int>(nullable: true),
                    carroid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Generico_Carro_carroid",
                        column: x => x.carroid,
                        principalTable: "Carro",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Generico_Department_departmentId",
                        column: x => x.departmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<decimal>(nullable: false),
                    NoUsuario = table.Column<string>(nullable: true),
                    CPF = table.Column<decimal>(nullable: false),
                    Telefone = table.Column<decimal>(nullable: false),
                    CEP = table.Column<decimal>(nullable: false),
                    CNPJ = table.Column<decimal>(nullable: false),
                    UsuDatNasc = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Generico_carroid",
                table: "Generico",
                column: "carroid");

            migrationBuilder.CreateIndex(
                name: "IX_Generico_departmentId",
                table: "Generico",
                column: "departmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Generico");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
