using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    [Table("Solicitacoes")]
    class Solicitacao : BaseModel
    {
        public Solicitacao()
        {
            Cliente = new Cliente();
            Fornecedor = new Fornecedor();
            Itens = new List<ItemSolicitacao>();
            EntradaProdutoEstoque = new EntradaProdutoEstoque();
        }
        public Cliente Cliente { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public List<ItemSolicitacao> Itens { get; set; }

        public EntradaProdutoEstoque EntradaProdutoEstoque { get; set; }
    }
}
