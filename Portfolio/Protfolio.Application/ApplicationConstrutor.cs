
using Portfolio.Ado.AdoRepositories;
using Portfolio.Infra.Repositories;

namespace Protfolio.Application
{
    public class ApplicationConstrutor
    {
        public static ApplicationCliente AplicacaoCliente()
        {
            return new ApplicationCliente(new RepositoryCliente());
        }

        public static ApplicationPedido AplicacaoPedido()
        {
            return new ApplicationPedido(new RepositoryPedido());
        }

        public static ApplicationPedido AdoAplicacao()
        {
            return new ApplicationPedido(new AdoPedidos());
        }

        public static ApplicationProduto AplicacaoProduto()
        {
            return new ApplicationProduto(new RepositoryProduto());
        }
    }
}
