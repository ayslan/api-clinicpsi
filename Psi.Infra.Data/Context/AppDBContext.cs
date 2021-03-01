using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Psi.Domain.Entities;
using Psi.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Psi.Infra.Data.Context
{
    public class AppDBContext : IdentityDbContext<ApplicationUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {

        }

        DbSet<Teste> Teste { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(new ApplicationUserMap().Configure);
        }
    }
}
