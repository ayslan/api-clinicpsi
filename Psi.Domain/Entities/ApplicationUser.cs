using Microsoft.AspNetCore.Identity;
using Psi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Psi.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PhoneAux { get; set; }
        public string CPF { get; set; }
        public string CRP { get; set; }
        public GenderEnum Gender { get; set; }
        public UserTypeEnum? Type { get; set; }
        public string Observation { get; set; }
        public DateTime? CreationDate { get; set; }

        //Address
        public string Zip { get; set; }
        public string StreetAddress { get; set; }
        public int? Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
