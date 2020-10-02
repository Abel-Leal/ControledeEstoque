using ControledeEstoqueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControledeEstoqueWPF.DAL
{
    class FornecedorDAO
    {
        private static Context _context = new Context();
        public static List<Fornecedor> Listar() => _context.Fornecedores.ToList();
        public static Fornecedor BuscaPorId(int id) => _context.Fornecedores.Find(id);
    }
}
