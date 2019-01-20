using Portfolio.Domain.Entities;
using Portfolio.Domain.Interfaces;
using System.Collections.Generic;


namespace Protfolio.Application
{
    public class ApplicationPedido : IRepositoryPedido
    {
        private readonly IRepositoryPedido repo;
        public ApplicationPedido(IRepositoryPedido _repo)
        {
            _repo = repo;
        }
        public void Add(Pedido obj)
        {
            obj = repo.ResgataDataPedido(obj);
            repo.Add(obj);
        }

        public IEnumerable<Pedido> GetAll()
        {
            return repo.GetAll();
        }

        public Pedido GetById(int id)
        {
            return repo.GetById(id);
        }

        public void Remove(Pedido obj)
        {
            repo.Remove(obj);
        }

        public Pedido ResgataDataPedido(Pedido obj)
        {
            obj = repo.ResgataDataPedido(obj);
            return obj;
        }

        IEnumerable<Pedido> IRepositoryBase<Pedido>.GetAll()
        {
            return repo.GetAll();
        }

        
    }
}
