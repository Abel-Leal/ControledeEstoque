using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    [Table("EntradaProdutosEstoque")]
    class EntradaProdutoEstoque : BaseModel
    {
        public EntradaProdutoEstoque()
        {
            Solicitacao = new Solicitacao();
            Produtos = new List<Produto>();
        }
        public Solicitacao Solicitacao { get; set; }
        public List<Produto> Produtos { get; set; }
        public int QtdeProdutoEntrada { get; set; }
        public int QtdeDisponivel { get; set; }
    }
}
