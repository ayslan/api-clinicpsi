using Psi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Models.Anamnesis
{
    public class AnamnesisFieldModel
    {
        public int AnamnesisFieldId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public AnamnesisFieldTypeEnum AnamnesisFieldType { get; set; }
        public string[] Options { get; set; }

        public int AnamnesisTopicFk { get; set; }
    }
}
