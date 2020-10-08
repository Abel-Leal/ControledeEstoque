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
        public string Tipo { get; set; }
        public string Categoria { get; set; }

    }
}
