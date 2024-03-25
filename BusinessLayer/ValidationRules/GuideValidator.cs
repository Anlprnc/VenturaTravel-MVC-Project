using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name can't be empty!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description can't be empty!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Image can't be empty!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Name must be less than 30 characters!");
            RuleFor(x => x.Name).MinimumLength(8).WithMessage("Name must be at least 8 characters!");
        }
    }
}