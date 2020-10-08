using Microsoft.EntityFrameworkCore.Migrations;

namespace ControledeEstoqueWPF.Migrations
{
    public partial class CriarBancoAtualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Produtos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Produtos");
        }
    }
}
