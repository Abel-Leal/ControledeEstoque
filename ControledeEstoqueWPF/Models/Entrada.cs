using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    [Table("EntradaProdutos")]
    class Entrada : BaseModel
    {
        public Entrada() => Produto = new Produto();
        public Produto Produto { get; set; }
        public int QtdeEntrada { get; set; }
    }
}
