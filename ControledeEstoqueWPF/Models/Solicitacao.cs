using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ControledeEstoqueWPF.Models
{
    [Table("Solicitacoes")]
    class Solicitacao : BaseModel
    {
        public Solicitacao()
        {
            Cliente = new Cliente();
            Fornecedor = new Fornecedor();
            Entradas = new List<Entrada>();
            Saidas = new List<Saida>();
        }
        public Cliente Cliente { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public List<Entrada> Entradas { get; set; }

        public List<Saida> Saidas { get; set; }

    }
}
