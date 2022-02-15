using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Entities
{
    public class Tenant
    {
        public int TenantId { get; set; }
        public string Name { get; set; }

        //virtual
        public virtual List<Client> Clients { get; set; }
        public virtual List<TenantUser> TenantUsers { get; set; }
        public virtual List<Insurance> Insurance { get; set; }
    }
}
