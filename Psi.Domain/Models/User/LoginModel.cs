using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Models.User
{
    public class LoginModel
    {
        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Password { get; set; }
    }
}
