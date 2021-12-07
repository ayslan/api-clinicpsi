using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Entities
{
    public class TenantUser
    {
        public int TenantUserId { get; set; }
       
        //fk
        public string UserFk { get; set; }
        public int TenantFk { get; set; }

        //virtual
        public virtual ApplicationUser User { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
