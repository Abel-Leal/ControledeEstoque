using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Solicitacao> Solicitacoes { get; set; }
        public DbSet<ItemSolicitacao> ItensSolicitacao { get; set; }
        public DbSet<EntradaProdutoEstoque> EntradaProdutoEstoque { get; set; }
        public DbSet<Saida> SaidaProdutos { get; set; }
        public DbSet<StatusEstoque> ConsultasStatusEstoques { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ControledeEstoqueWPF;Trusted_Connection=true");
        }
    }
}
