using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Psi.Domain.Models.Validators
{
    public class CreateTesteModelValidator : AbstractValidator<CreateTesteModel>
    {
        public CreateTesteModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("O nome deve ser preenchido").MinimumLength(5).WithMessage("Minimo de 5 chars");
            RuleFor(x => x.Idade).LessThan(2).WithMessage("Deve ser menor q 2");
        }
    }
}
