using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description can't be empty!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Please select an image!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Description must be at least 50 characters!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Description must be less than 1500 characters!");
        }
    }
}