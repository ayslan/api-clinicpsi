using Psi.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Psi.Domain.Models.Client
{
    public class ClientModel
    {
        public int ClientId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public ClientStatusEnum? Status { get; set; }
        [Required]
        public AgeGroupEnum? AgeGroup { get; set; }
        [Required]
        public GenderEnum? Gender { get; set; }
        public DateTime? CreationDateUtc { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CPF { get; set; }
        public string Observation { get; set; }
        public string RG { get; set; }
        public DateTime? BirthDate { get; set; }
        public MaritalStatusEnum? MaritalStatus { get; set; }
        public ServiceModalityEnum? ServiceModality { get; set; }
        public EducationLevelEnum? EducationLevel { get; set; }
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

        //Billing
        public ChargeTypeEnum? ChargeType { get; set; }
        public float? ServicePrice { get; set; }
        public float? ServicePackagePrice { get; set; }
        public int? QtyPackageServices { get; set; }

        //Emergency contact
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }

        //fk
        public int TenantFk { get; set; }
    }
}
