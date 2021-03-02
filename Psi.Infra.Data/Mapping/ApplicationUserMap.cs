using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Psi.Infra.Data.Mapping
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
