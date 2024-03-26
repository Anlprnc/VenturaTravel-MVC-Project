using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDtos>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name can't be empty!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname can't be empty!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail can't be empty!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username can't be empty!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password can't be empty!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Confirm Password can't be empty!");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Username must be at least 5 characters!");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Username must be less than 20 characters!");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Password and Confirm Password must be the same!");
        }
    }
}