using Psi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Entities
{
    public class ClientUserData
    {
        public int ClientUserDataId { get; set; }
        public string Code { get; set; }
        public string RG { get; set; }
        public DateTime? BirthDate { get; set; }
        public MaritalStatusEnum MaritalStatus { get; set; }
        public ClientStatusEnum Status { get; set; }
        public ServiceModalityEnum ServiceModality { get; set; }
        public EducationLevelEnum EducationLevel { get; set; }
        public string Profession { get; set; }
        public string Religion { get; set; }
        public string WithWhoResides { get; set; }
        public double ValueService { get; set; }

        //TODO Dados de familiares
        //TODO convenio - health insurance

        //Fk
        public string UserFk { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
