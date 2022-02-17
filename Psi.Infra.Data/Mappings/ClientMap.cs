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
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.BirthDate).IsRequired();
            builder.Property(c => c.Gender).IsRequired();
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.Phone).IsRequired();

            builder.HasOne(d => d.Tenant)
              .WithMany(p => p.Clients)
              .HasForeignKey(d => d.TenantFk);

            builder.HasOne(x => x.Insurance)
                .WithMany()
                .HasForeignKey(x => x.InsuranceFk);

            builder.HasOne(x => x.Country)
             .WithMany()
             .HasForeignKey(x => x.CountryFk);

            builder.HasOne(x => x.City)
               .WithMany()
               .HasForeignKey(x => x.CityFk);
        }
    }
}
