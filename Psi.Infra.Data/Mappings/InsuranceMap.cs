using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Infra.Data.Mappings
{
    class InsuranceMap : IEntityTypeConfiguration<Insurance>
    {
        public void Configure(EntityTypeBuilder<Insurance> builder)
        {
            builder.HasKey(c => c.InsuranceId);
            builder.Property(c => c.Name).IsRequired();

            builder.HasOne(d => d.Tenant)
               .WithMany(p => p.Insurance)
               .HasForeignKey(d => d.TenantFk);
        }
    }
}
