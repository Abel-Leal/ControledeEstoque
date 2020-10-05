using ControledeEstoqueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControledeEstoqueWPF.DAL
{
    class SolicitacaoDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        public static List<Solicitacao> Listar() => _context.Solicitacoes.ToList();
        public static void Cadastrar(Solicitacao solicitacao)
        {
            _context.Solicitacoes.Add(solicitacao);
            _context.SaveChanges();
        }
        public static Solicitacao BuscaPorId(int id) => _context.Solicitacoes.Find(id);
    }
}
