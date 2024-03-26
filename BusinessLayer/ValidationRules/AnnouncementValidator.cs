using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDtos>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title can't be empty!");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Content can't be empty!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Title must be at least 5 characters!");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Content must be at least 20 characters!");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Title must be less than 50 characters!");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Content must be less than 500 characters!");
        }
    }
}