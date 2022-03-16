using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psi.Domain.Entities;

namespace Psi.Infra.Data.Mappings
{
    public class AnamnesisMap : IEntityTypeConfiguration<Anamnesis>
    {
        public void Configure(EntityTypeBuilder<Anamnesis> builder)
        {
            builder.HasKey(c => c.AnamnesisId);
            builder.Property(c => c.GroupName).IsRequired();
            builder.Property(c => c.CreationDateUtc).IsRequired();

            builder.HasOne(d => d.Tenant)
            .WithMany()
            .HasForeignKey(d => d.TenantFk);
        }
    }

    public class AnamnesisTopicMap : IEntityTypeConfiguration<AnamnesisTopic>
    {
        public void Configure(EntityTypeBuilder<AnamnesisTopic> builder)
        {
            builder.HasKey(c => c.AnamnesisTopicId);
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Order).IsRequired();

            builder.HasOne(d => d.Anamnesis)
            .WithMany(d => d.AnamnesisTopics)
            .HasForeignKey(d => d.AnamnesisFk);
        }
    }

    public class AnamnesisFieldMap : IEntityTypeConfiguration<AnamnesisField>
    {
        public void Configure(EntityTypeBuilder<AnamnesisField> builder)
        {
            builder.HasKey(c => c.AnamnesisFieldId);
            builder.Property(c => c.Title).IsRequired();
            builder.Property(c => c.Order).IsRequired();
            builder.Property(c => c.AnamnesisFieldType).IsRequired();

            builder.HasOne(d => d.AnamnesisTopic)
            .WithMany(d => d.AnamnesisFields)
            .HasForeignKey(d => d.AnamnesisTopicFk);
        }
    }
}
