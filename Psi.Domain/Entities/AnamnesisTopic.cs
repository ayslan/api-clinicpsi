using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Entities
{
    public class AnamnesisTopic
    {
        public int AnamnesisTopicId { get; set; }
        public int Name { get; set; }   
        public int Order { get; set; }

        public int AnamnesisFk { get; set; }

        public virtual Anamnesis Anamnesis { get; set; }
        public virtual List<AnamnesisField> AnamnesisFields { get; set; }
    }
}
