using Portfolio.Domain.Entities;
using Portfolio.Domain.Interfaces;
using Portfolio.Infra.Repositories;
using System.Collections.Generic;
using System;

namespace Protfolio.Application
{
    public class ApplicationProduto : IRepositoryProduto
    {
        private readonly IRepositoryProduto repo;
        public ApplicationProduto(IRepositoryProduto _repo)
        {
            repo = _repo;
        }
        public void Add(Produto obj)
        {
            repo.Add(obj);
        }

        public IEnumerable<Produto> GetAll()
        {
            return repo.GetAll();
        }

        public Produto GetById(int id)
        {
            return repo.GetById(id);
        }

        public void Remove(Produto obj)
        {
            repo.Remove(obj);
        }

        public void Update(Produto obj)
        {
            repo.Update(obj);
        }
    }
}
