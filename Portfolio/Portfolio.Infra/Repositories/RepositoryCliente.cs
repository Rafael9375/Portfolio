
using System;
using System.Collections.Generic;
using Portfolio.Domain.Entities;
using Portfolio.Domain.Interfaces;
using System.Linq;

namespace Portfolio.Infra.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public IEnumerable<Cliente> BuscarPorNome(string nome)
        {
            return Db.Clientes.Where(c => c.Nome == nome);
        }

        public Cliente ResgataDataCadastro(Cliente obj)
        {
            obj.DataCadastro = DateTime.Now;
            return obj;
        }
    }
}
