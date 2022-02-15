using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Entities
{
    public class Insurance
    {
        public int InsuranceId { get; set; }
        public string Name { get; set; }

        //fk
        public int TenantFk { get; set; }

        //virtual
        public virtual Tenant Tenant { get; set; }
    }
}
