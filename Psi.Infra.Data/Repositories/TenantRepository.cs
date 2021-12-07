using Psi.Domain.Entities;
using Psi.Domain.Interfaces.Repositories;
using Psi.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Infra.Data.Repositories
{
    public class TenantRepository : BaseRepository<Tenant>, ITenantRepository
    {
        public TenantRepository(ApplicationDbContext contexto) : base(contexto) { }
    }
}