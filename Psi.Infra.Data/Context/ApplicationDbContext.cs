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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<ClientUserData> ClientUsersData { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(new ApplicationUserMap().Configure);
            builder.Entity<ClientUserData>(new ClientUserDataMap().Configure);
        }
    }
}
