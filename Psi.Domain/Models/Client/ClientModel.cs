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
        public DateTime? CreationDateUtc { get; set; }
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public string CPF { get; set; }
        public string Observation { get; set; }
        public string RG { get; set; }
        [Required]
        public DateTime? BirthDate { get; set; }
        public MaritalStatusEnum? MaritalStatus { get; set; }
        [Required]
        public ClientStatusEnum? Status { get; set; }
        public ServiceModalityEnum? ServiceModality { get; set; }
        public EducationLevelEnum? EducationLevel { get; set; }
        public AgeGroupEnum? AgeGroup { get; set; }
        [Required]
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
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

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
    }
}
