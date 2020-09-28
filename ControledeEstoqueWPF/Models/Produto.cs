using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    [Table("Produtos")]
    class Produto : BaseModel
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public int EstoqueMax { get; set; }
        public int EstoqueMin { get; set; }
    }
}
