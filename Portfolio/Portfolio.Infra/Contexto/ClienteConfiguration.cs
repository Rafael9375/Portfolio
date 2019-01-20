using Portfolio.Domain.Entities;
using System.Data.Entity.ModelConfiguration;


namespace Portfolio.Infra.Contexto
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);
        }
    }
}
