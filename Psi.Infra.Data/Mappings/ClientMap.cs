using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psi.Domain.Entities;

namespace Psi.Infra.Data.Mappings
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.ClientId);
            builder.Property(x => x.Code).IsRequired();
            builder.Property(x => x.ServicePrice).HasPrecision(2);

            builder.HasOne(d => d.Tenant)
              .WithMany(p => p.Clients)
              .HasForeignKey(d => d.TenantFk);
        }
    }
}
