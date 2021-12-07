using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psi.Domain.Entities;

namespace Psi.Infra.Data.Mappings
{
    public class ApplicationUserMap : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
