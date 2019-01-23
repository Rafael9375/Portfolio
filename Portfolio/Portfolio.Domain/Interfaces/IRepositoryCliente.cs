using Portfolio.Domain.Entities;
using System.Collections.Generic;


namespace Portfolio.Domain.Interfaces
{
    public interface IRepositoryCliente : IRepositoryBase<Cliente>
    {
        IEnumerable<Cliente> BuscarPorNome(string nome);
        Cliente ResgataDataCadastro(Cliente obj);
        
    }
}
