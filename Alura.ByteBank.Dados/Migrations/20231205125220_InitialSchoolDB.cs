using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alura.ByteBank.Dados.Migrations
{
    public partial class InitialSchoolDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterDatabase()
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "agencia",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Numero = table.Column<int>(type: "int", nullable: false),
            //        Nome = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Endereco = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Identificador = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_agencia", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "cliente",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Identificador = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
            //        CPF = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Nome = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Profissao = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_cliente", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "conta_correnteTest",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Numero = table.Column<int>(type: "int", nullable: false),
            //        Identificador = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
            //        ClienteId = table.Column<int>(type: "int", nullable: true),
            //        AgenciaId = table.Column<int>(type: "int", nullable: true),
            //        Saldo = table.Column<double>(type: "double", nullable: false),
            //        PixConta = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
            //        TestColumn = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_conta_correnteTest", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_conta_correnteTest_agencia_AgenciaId",
            //            column: x => x.AgenciaId,
            //            principalTable: "agencia",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_conta_correnteTest_cliente_ClienteId",
            //            column: x => x.ClienteId,
            //            principalTable: "cliente",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateIndex(
            //    name: "IX_conta_correnteTest_AgenciaId",
            //    table: "conta_correnteTest",
            //    column: "AgenciaId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_conta_correnteTest_ClienteId",
            //    table: "conta_correnteTest",
            //    column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "conta_correnteTest");

            migrationBuilder.DropTable(
                name: "agencia");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
