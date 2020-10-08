using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControledeEstoqueWPF.Migrations
{
    public partial class CriarBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Matricula = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Setor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Matricula = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Solicitacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<int>(nullable: true),
                    FornecedorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Solicitacoes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Solicitacoes_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntradaProdutos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: true),
                    QtdeEntrada = table.Column<int>(nullable: false),
                    SolicitacaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradaProdutos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntradaProdutos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntradaProdutos_Solicitacoes_SolicitacaoId",
                        column: x => x.SolicitacaoId,
                        principalTable: "Solicitacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaidaProdutos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: true),
                    QtdeSaida = table.Column<int>(nullable: false),
                    SolicitacaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaidaProdutos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaidaProdutos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaidaProdutos_Solicitacoes_SolicitacaoId",
                        column: x => x.SolicitacaoId,
                        principalTable: "Solicitacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntradaProdutos_ProdutoId",
                table: "EntradaProdutos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaProdutos_SolicitacaoId",
                table: "EntradaProdutos",
                column: "SolicitacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_SaidaProdutos_ProdutoId",
                table: "SaidaProdutos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_SaidaProdutos_SolicitacaoId",
                table: "SaidaProdutos",
                column: "SolicitacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitacoes_ClienteId",
                table: "Solicitacoes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitacoes_FornecedorId",
                table: "Solicitacoes",
                column: "FornecedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntradaProdutos");

            migrationBuilder.DropTable(
                name: "SaidaProdutos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Solicitacoes");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Fornecedores");
        }
    }
}
