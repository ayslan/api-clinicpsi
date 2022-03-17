using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Models.Anamnesis
{
    public class AnamnesisModel
    {
        public int AnamnesisId { get; set; }
        public string GroupName { get; set; }
        public DateTime? CreationDateUtc { get; set; }
        public int TenantFk { get; set; }

        public virtual List<AnamnesisTopicModel> AnamnesisTopics { get; set; }
    }
}
