using Psi.Domain.Entities;
using Psi.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Interfaces.Repositories
{
    public interface ITenantRepository : IBaseRepository<Tenant>
    {
    }
}
