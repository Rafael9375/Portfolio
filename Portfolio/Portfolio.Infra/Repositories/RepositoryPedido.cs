using Portfolio.Domain.Entities;
using Portfolio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Infra.Repositories
{
    public class RepositoryPedido : RepositoryBase<Pedido>, IRepositoryPedido
    {
        
        public Pedido ResgataDados(Pedido obj)
        {
            obj.Cliente = Db.Clientes.Where(c => c.ClienteId == obj.ClienteId).First();
            obj.Produto = Db.Produtos.Where(c => c.ProdutoId == obj.ProdutoId).First();
            return obj;
        }

        public Pedido ResgataDataPedido(Pedido obj)
        {
            obj.DataPedido = DateTime.Now;
            return obj;
        }
    }
}
