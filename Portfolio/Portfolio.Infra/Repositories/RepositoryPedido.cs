using Portfolio.Domain.Entities;
using Portfolio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Infra.Repositories
{
    public class RepositoryPedido : RepositoryBase<Pedido>, IRepositoryPedido
    {
        public Pedido ResgataDataPedido(Pedido obj)
        {
            obj.DataPedido = DateTime.Now;
            return obj;
        }
    }
}
