
using Portfolio.Infra.Repositories;

namespace Protfolio.Application
{
    public class ApplicationConstrutor
    {
        static ApplicationCliente AplicacaoCliente()
        {
            return new ApplicationCliente(new RepositoryCliente());
        }

        static ApplicationPedido AplicacaoPedido()
        {
            return new ApplicationPedido(new RepositoryPedido());
        }

        static ApplicationProduto AplicacaoProduto()
        {
            return new ApplicationProduto(new RepositoryProduto());
        }
    }
}
