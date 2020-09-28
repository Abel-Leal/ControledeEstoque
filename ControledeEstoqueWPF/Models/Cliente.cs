using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    [Table("Clientes")]
    class Cliente : Usuario
    {
        public string Email { get; set; }
    }
}
