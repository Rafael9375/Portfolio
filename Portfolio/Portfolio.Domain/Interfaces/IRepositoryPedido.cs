using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces
{
    public interface IRepositoryPedido : IRepositoryBase<Pedido>
    {
        Pedido ResgataDataPedido(Pedido obj);
    }
}
