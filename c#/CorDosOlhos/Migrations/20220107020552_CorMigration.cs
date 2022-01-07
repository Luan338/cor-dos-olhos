using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CorDosOlhos.Migrations
{
    public partial class CorMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastros",
                columns: table => new
                {
                    IdC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeC = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    SobrenomeC = table.Column<string>(type: "char(20)", nullable: false),
                    NasC = table.Column<DateTime>(type: "date", nullable: false),
                    CPFC = table.Column<string>(type: "char(11)", nullable: false),
                    Etnia = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    CidadeC = table.Column<string>(type: "char(25)", nullable: true),
                    UFC = table.Column<string>(type: "char(2)", nullable: true),
                    CEPC = table.Column<string>(type: "char(8)", nullable: true),
                    BairroC = table.Column<string>(type: "char(25)", nullable: true),
                    EnderecoC = table.Column<string>(type: "char(25)", nullable: true),
                    NumeroC = table.Column<string>(type: "char(7)", nullable: false),
                    TelefoneC = table.Column<string>(type: "char(13)", nullable: false),
                    EmailC = table.Column<string>(type: "char(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastros", x => x.IdC);
                });

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    IdContato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeContato = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    EmailContato = table.Column<string>(type: "char(20)", nullable: false),
                    MsgContato = table.Column<string>(type: "char(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.IdContato);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    IdRegistro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CidadeRegistro = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CEPRegistro = table.Column<string>(type: "char(8)", nullable: true),
                    BairroRegistro = table.Column<string>(type: "char(25)", nullable: true),
                    EnderecoRegistro = table.Column<string>(type: "char(25)", nullable: false),
                    NumeroRegistro = table.Column<string>(type: "char(7)", nullable: true),
                    PontoRefRegistro = table.Column<string>(type: "char(25)", nullable: true),
                    DescricaoRegistro = table.Column<string>(type: "char(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.IdRegistro);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastros");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Registros");
        }
    }
}
