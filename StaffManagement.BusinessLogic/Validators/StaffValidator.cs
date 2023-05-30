using FluentValidation;
using StaffManagement.Core.Models;

namespace StaffManagement.BusinessLogic.Validators
{
    public class StaffValidator : AbstractValidator<Staff>
    {
        public StaffValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("First name cannot be empty.");
            RuleFor(s => s.FirstName).MaximumLength(50).WithMessage("First name cannot be more than 50 characters.");
            RuleFor(s => s.LastName).NotEmpty().WithMessage("Last name cannot be empty.");
            RuleFor(s => s.LastName).MaximumLength(50).WithMessage("Last name cannot be more than 50 characters.");
            RuleFor(s => s.Email).NotEmpty().EmailAddress().WithMessage("Invalid email address.");
            RuleFor(s => s.Email).MaximumLength(50).WithMessage("Email cannot be more than 50 characters.");
            RuleFor(s => s.Phone).NotEmpty().WithMessage("Phone cannot be empty.");
            RuleFor(s => s.Phone).MaximumLength(11).WithMessage("Phone cannot be more than 50 characters.");
            RuleFor(s => s.DateOfBirth).NotEmpty().WithMessage("Date of birth cannot be empty.");
            RuleFor(s => s.AddressLine1).NotEmpty().WithMessage("Address line cannot be empty.");
            RuleFor(x => x.AddressLine1).MaximumLength(250)
                .WithMessage("Address line cannot be more than 250 characters.");
            RuleFor(s => s.City).NotEmpty().WithMessage("City cannot be empty.");
            RuleFor(s => s.Country).NotEmpty().WithMessage("Country cannot be empty.");
            RuleFor(s => s.Province).NotEmpty().WithMessage("Province cannot be empty.");
        }
    }
}