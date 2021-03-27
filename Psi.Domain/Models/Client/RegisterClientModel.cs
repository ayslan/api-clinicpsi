using Psi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Models.Client
{
    public class RegisterClientModel
    {
        //User
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PhoneAux { get; set; }
        public string CPF { get; set; }
        public GenderEnum Gender { get; set; }
        public string Observation { get; set; }

        //Address
        public string Zip { get; set; }
        public string StreetAddress { get; set; }
        public int? Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        //ClientData
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
    }
}
