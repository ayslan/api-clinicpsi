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
    public class ClientUserDataMap : IEntityTypeConfiguration<ClientUserData>
    {
        public void Configure(EntityTypeBuilder<ClientUserData> builder)
        {
            builder.HasKey(c => c.ClientUserDataId);
            builder.Property(x => x.Code).IsRequired();
            builder.Property(x => x.ValueService).HasPrecision(2);

            builder.HasOne(x => x.User)
              .WithOne(x => x.ClientUserData)
              .HasForeignKey<ClientUserData>(x => x.UserFk);
        }
    }
}
