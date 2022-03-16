using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Psi.Domain.Entities;
using Psi.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Psi.Infra.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private static string ConnectionString { get; set; }

        public ApplicationDbContext() : base(GetOptions())
        {

        }

        private static DbContextOptions GetOptions() => SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), ConnectionString).Options;

        public static void SetConnectionString(string connectionString)
        {
            if (ConnectionString == null)
            {
                ConnectionString = connectionString;
            }
            else
            {
                throw new Exception();
            }
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Tenant> Tenants { get; set; }
        public virtual DbSet<TenantUser> TenantUsers { get; set; }
        public virtual DbSet<Insurance> Insurance { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Anamnesis> Anamnesis { get; set; }
        public virtual DbSet<AnamnesisTopic> AnamnesisTopics { get; set; }  
        public virtual DbSet<AnamnesisField> AnamnesisFields { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(new ApplicationUserMap().Configure);
            builder.Entity<Client>(new ClientMap().Configure);
            builder.Entity<Tenant>(new TenantMap().Configure);
            builder.Entity<TenantUser>(new TenantUserMap().Configure);
            builder.Entity<Insurance>(new InsuranceMap().Configure);
            builder.Entity<City>(new CityMap().Configure);
            builder.Entity<Country>(new CountryMap().Configure);
            builder.Entity<Anamnesis>(new AnamnesisMap().Configure);
            builder.Entity<AnamnesisTopic>(new AnamnesisTopicMap().Configure);
            builder.Entity<AnamnesisField>(new AnamnesisFieldMap().Configure);

        }
    }
}
