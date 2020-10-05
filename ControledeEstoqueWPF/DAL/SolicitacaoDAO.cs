using ControledeEstoqueWPF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControledeEstoqueWPF.DAL
{
    class SolicitacaoDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        public static void Cadastrar(Solicitacao solicitacao)
        {
            _context.Solicitacoes.Add(solicitacao);
            _context.SaveChanges();
        }
    }
}
