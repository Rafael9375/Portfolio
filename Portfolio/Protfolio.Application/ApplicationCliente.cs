using Portfolio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.Domain.Entities;

namespace Protfolio.Application
{
    public class ApplicationCliente : IRepositoryCliente
    {
        private readonly IRepositoryCliente repo;
        public ApplicationCliente(IRepositoryCliente _repo)
        {
            _repo = repo;
        }
        public void Add(Cliente obj)
        {
            obj = ResgataDataCadastro(obj);
            repo.Add(obj);
        }

        public IEnumerable<Cliente> BuscarPorNome(string nome)
        {
            return repo.BuscarPorNome(nome);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return repo.GetAll();
        }

        public Cliente GetById(int id)
        {
            return repo.GetById(id);
        }

        public void Remove(Cliente obj)
        {
            repo.Remove(obj);
        }

        public Cliente ResgataDataCadastro(Cliente obj)
        {
            return repo.ResgataDataCadastro(obj);
        }
    }
}
