using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    [Table("SaidaProdutosEstoque")]
    class Saida : BaseModel
    {
        public int QtdeSaidaProduto { get; set; }

    }
}
