
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Portfolio.Domain.Entities;

namespace Portfolio.Infra.Contexto
{
    public class Context : DbContext
    {
        public Context() : base("ConexaoPortfolio")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new PedidoConfiguration());
        }
    }
}
