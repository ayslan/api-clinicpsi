using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Psi.Domain.Models.User
{
    public class RegisterUserModel : IValidatableObject
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ConfirmPassword != Password)
                yield return new ValidationResult("As senhas não são iguais");
        }
    }
}
