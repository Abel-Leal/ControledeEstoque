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
        public static List<StatusEstoque> Listar() => _context.ConsultasStatusEstoque.ToList();
        public static StatusEstoque BuscaPorId(int id) => _context.ConsultasStatusEstoque.Find(id);

    }
}
