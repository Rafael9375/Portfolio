
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

        public bool LoginValido(Cliente obj)
        {
            Cliente aux;
            try
            {
                aux = Db.Clientes.Where(c => c.Login == obj.Login).First();
                if (aux.Senha == obj.Senha)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;                
            }
            return false;
        }

        public Cliente ResgataDataCadastro(Cliente obj)
        {
            obj.DataCadastro = DateTime.Now;
            return obj;
        }
    }
}
