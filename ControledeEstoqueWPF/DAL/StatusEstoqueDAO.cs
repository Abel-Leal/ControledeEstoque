using ControledeEstoqueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControledeEstoqueWPF.DAL
{
    class StatusEstoqueDAO
    {
        private static Context _context = new Context();
        public static List<EntradaProdutoEstoque> Listar() => _context.EntradaProdutoEstoque.ToList();
        public static EntradaProdutoEstoque BuscaPorId(int id) => _context.EntradaProdutoEstoque.Find(id);

    }
}
