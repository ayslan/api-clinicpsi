using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psi.Domain.Entities;

namespace Psi.Infra.Data.Mappings
{
    class TenantUserMap : IEntityTypeConfiguration<TenantUser>
    {
        public void Configure(EntityTypeBuilder<TenantUser> builder)
        {
            builder.HasKey(c => c.TenantUserId);

            builder.HasOne(d => d.Tenant)
                .WithMany(p => p.TenantUsers)
                .HasForeignKey(d => d.TenantFk);

            builder.HasOne(d => d.User)
               .WithMany(p => p.TenantUsers)
               .HasForeignKey(d => d.UserFk)
               .IsRequired();
        }
    }
}
