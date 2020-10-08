using ControledeEstoqueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControledeEstoqueWPF.DAL
{
    class EntradaDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        public static List<Entrada> Listar() => _context.Entradas.ToList();
        public static void CadastrarEntrada(Entrada entrada)
        {
            _context.Entradas.Add(entrada);
            _context.SaveChanges();
        }
        public static Entrada BuscaPorId(int id) => _context.Entradas.Find(id);
    }
}
