using System;
using System.Collections.Generic;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    class StatusEstoque : BaseModel
    {
        StatusEstoque()
        {
            EntradaProdutoEstoque = new EntradaProdutoEstoque();
            Saida = new Saida();
        }
        public EntradaProdutoEstoque EntradaProdutoEstoque { get; set; }
        public Saida Saida { get; set; }
        
    }
}
