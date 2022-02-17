using Psi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public DateTime? CreationDateUtc { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CPF { get; set; }
        public string Observation { get; set; }
        public string RG { get; set; }
        public DateTime? BirthDate { get; set; }
        public MaritalStatusEnum? MaritalStatus { get; set; }
        public ClientStatusEnum? Status { get; set; }
        public ServiceModalityEnum? ServiceModality { get; set; }
        public EducationLevelEnum? EducationLevel { get; set; }
        public AgeGroupEnum? AgeGroup { get; set; }
        public GenderEnum? Gender { get; set; }
        public string Occupation { get; set; }
        public string Religion { get; set; }
        public string Profession { get; set; }
        public string Tags { get; set; }

        //Address
        public string Zip { get; set; }
        public string StreetAddress { get; set; }
        public int? Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public int? CountryFk { get; set; }
        public int? CityFk { get; set; }
        public string ForeignCityName { get; set; }
        public string ForeignStateName { get; set; }

        //Payment
        public int? InsuranceFk { get; set; }
        public float? ServicePrice { get; set; }
        public CalculationTypeEnum? InsuranceTransferType { get; set; } 
        public float? InsuranceTransferValue { get; set; }

        //Emergency contact
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }

        //fk
        public int TenantFk { get; set; }

        //virtual
        public virtual Tenant Tenant { get; set; } 
        public virtual Insurance Insurance { get; set; }
        public virtual Country Country { get; set; }
        public virtual City City { get; set; }
    }
}
