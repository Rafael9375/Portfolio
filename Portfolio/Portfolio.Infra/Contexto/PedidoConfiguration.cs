using Portfolio.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Portfolio.Infra.Contexto
{
    public class PedidoConfiguration : EntityTypeConfiguration<Pedido>
    {
        public PedidoConfiguration()
        {
            HasKey(p => p.PedidoId);
        }
    }
}
