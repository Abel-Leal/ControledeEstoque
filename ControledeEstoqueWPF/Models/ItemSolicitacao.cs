using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    [Table("ItensSolicitacao")]
    class ItemSolicitacao : BaseModel
    {
        public ItemSolicitacao() => Produto = new Produto();
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
