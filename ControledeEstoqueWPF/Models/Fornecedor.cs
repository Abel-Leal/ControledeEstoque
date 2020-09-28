using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    [Table("Fornecedores")]
    class Fornecedor : Usuario
    {
        public string Descricao { get; set; }
        public string Cnpj { get; set; }
    }
}
