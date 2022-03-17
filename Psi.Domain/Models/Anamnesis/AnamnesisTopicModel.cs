using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Models.Anamnesis
{
    public class AnamnesisTopicModel
    {
        public int AnamnesisTopicId { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public int AnamnesisFk { get; set; }

        public virtual List<AnamnesisFieldModel> AnamnesisFields { get; set; }
    }
}
