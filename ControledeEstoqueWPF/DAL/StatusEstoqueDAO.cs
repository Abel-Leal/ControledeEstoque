using ControledeEstoqueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControledeEstoqueWPF.DAL
{
    class StatusEstoqueDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        public static List<StatusEstoque> Listar() => _context.ConsultasStatusEstoque.ToList();
        public static StatusEstoque BuscaPorId(Produto produto) => _context.ConsultasStatusEstoque.Find(produto);

    }
}
