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
        }
        public Solicitacao Solicitacao { get; set; }
        public int QtdeProdutoEntrada { get; set; }
        public bool EspaçoDisponívelEstoque { get; set; }

    }
}
