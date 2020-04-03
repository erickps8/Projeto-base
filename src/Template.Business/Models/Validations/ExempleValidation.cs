using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Business.Models.Validations
{
    public class ExempleValidation : AbstractValidator<Exemple>
    {
        public ExempleValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
