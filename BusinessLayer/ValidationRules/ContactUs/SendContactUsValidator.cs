using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail can't be empty!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Subject can't be empty!");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name can't be empty!");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Message Body can't be empty!");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Subject must be at least 5 characters!");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Subject must be less than 100 characters!");
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("Mail must be at least 5 characters!");
            RuleFor(x => x.Mail).MaximumLength(100).WithMessage("Mail must be less than 100 characters!");
        }
    }
}