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
    public class TenantUserRepository : BaseRepository<TenantUser>, ITenantUserRepository
    {
        public TenantUserRepository(ApplicationDbContext contexto) : base(contexto) { }

        public TenantUser GetTenantUserByIds(int tenantId, string userId)
        {
            return _db.TenantUsers.Where(x => x.TenantFk == tenantId && x.UserFk == userId).FirstOrDefault();
        }
    }
}
