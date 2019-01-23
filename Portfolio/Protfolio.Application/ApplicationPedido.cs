using Portfolio.Domain.Entities;
using Portfolio.Domain.Interfaces;
using System.Collections.Generic;
using System;
using Portfolio.Ado.AdoRepositories;

namespace Protfolio.Application
{
    public class ApplicationPedido : IRepositoryPedido
    {
        private readonly IRepositoryPedido repo;
        private readonly AdoPedidos ado;
        public ApplicationPedido(IRepositoryPedido _repo)
        {
            repo = _repo;
        }

        public ApplicationPedido(AdoPedidos _ado)
        {
            ado = _ado;
        }
        public void Add(Pedido obj)
        {
            obj = ResgataDataPedido(obj);
            obj = ResgataDados(obj);
            repo.Add(obj);
        }

        public List<string> GerarRelatorio()
        {
            return ado.GerarRelatorio();
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

        public Pedido ResgataDados(Pedido obj)
        {
            obj = repo.ResgataDados(obj);
            return obj;
        }

        public Pedido ResgataDataPedido(Pedido obj)
        {
            obj = repo.ResgataDataPedido(obj);
            return obj;
        }

        public void Update(Pedido obj)
        {
            repo.Update(obj);
        }

        

        
    }
}
