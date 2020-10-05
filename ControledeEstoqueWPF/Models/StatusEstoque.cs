using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    [Table("ConsultasStatusEstoque")]
    class StatusEstoque : BaseModel
    {
        StatusEstoque()
        {
            Produto = new Produto();
            EntradaProdutosEstoque = new List<EntradaProdutoEstoque>();
            Saidas = new List<Saida>();
        }
        public Produto Produto { get; set; }
        public List<EntradaProdutoEstoque> EntradaProdutosEstoque { get; set; }
        public List<Saida> Saidas { get; set; }

    }
}
