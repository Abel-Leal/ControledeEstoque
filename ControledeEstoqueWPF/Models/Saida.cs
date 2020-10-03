using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    [Table("SaidaProdutosEstoque")]
    class Saida : BaseModel
    {
        public Saida()
        {
            Solicitacao = new Solicitacao();
        }
        public Solicitacao Solicitacao { get; set; }
        public string MotivoSaida { get; set; }
        public int QtdeSaidaProduto { get; set; }

    }
}
