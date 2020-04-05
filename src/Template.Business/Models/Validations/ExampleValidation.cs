using FluentValidation;

namespace Template.Business.Models.Validations
{
    public class ExampleValidation : AbstractValidator<Example>
    {
        public ExampleValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
