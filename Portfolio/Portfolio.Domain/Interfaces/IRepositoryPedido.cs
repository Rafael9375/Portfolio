using Portfolio.Domain.Entities;
using System.Collections.Generic;

namespace Portfolio.Domain.Interfaces
{
    public interface IRepositoryPedido : IRepositoryBase<Pedido>
    {
        Pedido ResgataDataPedido(Pedido obj);
        Pedido ResgataDados(Pedido obj);
        
    }
}
