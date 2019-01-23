using Portfolio.Ado.AdoRepositories;
using Portfolio.Ado.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Ado
{
    class Program
    {
        static void Main(string[] args)
        {
            AdoPedidos pedidos = new AdoPedidos();
            List<string> lista = new List<string>();
            lista = pedidos.GerarRelatorio();
            foreach (var item in lista)
            {
                System.Console.WriteLine(item.ToString());
            }
        }
    }
}
