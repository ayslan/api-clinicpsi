using Psi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Psi.Domain.Models.User
{
    public class ApplicationUserModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PhoneAux { get; set; }
        public string CPF { get; set; }
        public string CRP { get; set; }
        public DateTime? BirthDate { get; set; }
        public UserTypeEnum? Type { get; set; }
        public UserStatusEnum? Status { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
