using Microsoft.AspNetCore.Identity;
using Psi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Psi.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime? CreationDateUtc { get; set; }

        //virtual
        public virtual List<TenantUser> TenantUsers { get; set; }
    }
}
