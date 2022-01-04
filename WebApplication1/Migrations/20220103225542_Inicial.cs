using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cadastrarCidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo_Moeda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadastrarCidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cadastrarClientes",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<int>(type: "int", nullable: false),
                    Email_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadastrarClientes", x => x.Id_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "cadastrarViagens",
                columns: table => new
                {
                    Id_Pacote = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadastrarViagens", x => x.Id_Pacote);
                });

            migrationBuilder.CreateTable(
                name: "contatos",
                columns: table => new
                {
                    Id_Contato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mensagem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contatos", x => x.Id_Contato);
                });

            migrationBuilder.CreateTable(
                name: "compras",
                columns: table => new
                {
                    Id_Compra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Cidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compras", x => x.Id_Compra);
                    table.ForeignKey(
                        name: "FK_compras_cadastrarCidades_Id_Cidade",
                        column: x => x.Id_Cidade,
                        principalTable: "cadastrarCidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_compras_Id_Cidade",
                table: "compras",
                column: "Id_Cidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cadastrarClientes");

            migrationBuilder.DropTable(
                name: "cadastrarViagens");

            migrationBuilder.DropTable(
                name: "compras");

            migrationBuilder.DropTable(
                name: "contatos");

            migrationBuilder.DropTable(
                name: "cadastrarCidades");
        }
    }
}
