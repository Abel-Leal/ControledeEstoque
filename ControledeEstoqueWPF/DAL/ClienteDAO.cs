using ControledeEstoqueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControledeEstoqueWPF.DAL
{
    class ClienteDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        public static List<Cliente> Listar() => _context.Clientes.ToList();
        public static Cliente BuscaPorId(int id) => _context.Clientes.Find(id);
    }
}
