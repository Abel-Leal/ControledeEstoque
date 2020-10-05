﻿// <auto-generated />
using System;
using ControledeEstoqueWPF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControledeEstoqueWPF.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControledeEstoqueWPF.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Setor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ControledeEstoqueWPF.Models.EntradaProdutoEstoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EspaçoDisponívelEstoque")
                        .HasColumnType("bit");

                    b.Property<int>("QtdeProdutoEntrada")
                        .HasColumnType("int");

                    b.Property<int?>("SolicitacaoId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusEstoqueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SolicitacaoId");

                    b.HasIndex("StatusEstoqueId");

                    b.ToTable("EntradaProdutosEstoque");
                });

            modelBuilder.Entity("ControledeEstoqueWPF.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("ControledeEstoqueWPF.Models.ItemSolicitacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int?>("SolicitacaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("SolicitacaoId");

                    b.ToTable("ItensSolicitacao");
                });

            modelBuilder.Entity("ControledeEstoqueWPF.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ControledeEstoqueWPF.Models.Saida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("MotivoSaida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtdeSaidaProduto")
                        .HasColumnType("int");

                    b.Property<int?>("SolicitacaoId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusEstoqueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SolicitacaoId");

                    b.HasIndex("StatusEstoqueId");

                    b.ToTable("SaidaProdutosEstoque");
                });

            modelBuilder.Entity("ControledeEstoqueWPF.Models.Solicitacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<bool>("TipoSolicitacao")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Solicitacoes");
                });

            modelBuilder.Entity("ControledeEstoqueWPF.Models.StatusEstoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ConsultasStatusEstoque");
                });

            modelBuilder.Entity("ControledeEstoqueWPF.Models.EntradaProdutoEstoque", b =>
                {
                    b.HasOne("ControledeEstoqueWPF.Models.Solicitacao", "Solicitacao")
                        .WithMany()
                        .HasForeignKey("SolicitacaoId");

                    b.HasOne("ControledeEstoqueWPF.Models.StatusEstoque", null)
                        .WithMany("EntradaProdutosEstoque")
                        .HasForeignKey("StatusEstoqueId");
                });

            modelBuilder.Entity("ControledeEstoqueWPF.Models.ItemSolicitacao", b =>
                {
                    b.HasOne("ControledeEstoqueWPF.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.HasOne("ControledeEstoqueWPF.Models.Solicitacao", null)
                        .WithMany("Itens")
                        .HasForeignKey("SolicitacaoId");
                });

            modelBuilder.Entity("ControledeEstoqueWPF.Models.Saida", b =>
                {
                    b.HasOne("ControledeEstoqueWPF.Models.Solicitacao", "Solicitacao")
                        .WithMany()
                        .HasForeignKey("SolicitacaoId");

                    b.HasOne("ControledeEstoqueWPF.Models.StatusEstoque", null)
                        .WithMany("Saidas")
                        .HasForeignKey("StatusEstoqueId");
                });

            modelBuilder.Entity("ControledeEstoqueWPF.Models.Solicitacao", b =>
                {
                    b.HasOne("ControledeEstoqueWPF.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("ControledeEstoqueWPF.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");
                });

            modelBuilder.Entity("ControledeEstoqueWPF.Models.StatusEstoque", b =>
                {
                    b.HasOne("ControledeEstoqueWPF.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });
#pragma warning restore 612, 618
        }
    }
}
