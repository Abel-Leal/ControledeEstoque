using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    [Table("SaidaProdutosEstoque")]
    class Saida : BaseModel
    {
        public Saida() => Produto = new Produto();
        public Produto Produto { get; set; }
        public int QtdeSaidaProduto { get; set; }

    }
}
