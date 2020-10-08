using ControledeEstoqueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControledeEstoqueWPF.DAL
{
    class SaidaDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        public static List<Saida> Listar() => _context.Saidas.ToList();
        public static void CadastrarSaida(Saida saida)
        {
            _context.Saidas.Add(saida);
            _context.SaveChanges();
        }
        public static Saida BuscaPorId(int id) => _context.Saidas.Find(id);
    }
}
