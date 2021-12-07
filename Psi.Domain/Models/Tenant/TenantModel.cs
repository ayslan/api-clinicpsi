using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Models.Tenant
{
    public class TenantModel
    {
        public int TenantId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
