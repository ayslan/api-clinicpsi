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
    public class InsuranceRepository : BaseRepository<Insurance>, IInsuranceRepository
    {
        public InsuranceRepository(ApplicationDbContext contexto) : base(contexto) { }

        public List<Insurance> ListByTenantId(int tenantId)
        {
            return _db.Insurance.Where(x => x.TenantFk == tenantId).ToList();
        }
    }
}
