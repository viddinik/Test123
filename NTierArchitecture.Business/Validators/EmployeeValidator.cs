using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Validation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(50).WithMessage("Name can't be longer than 50 characters.");

            RuleFor(e => e.Surname)
                .NotEmpty().WithMessage("Surname is required.")
                .MaximumLength(50).WithMessage("Surname can't be longer than 50 characters.");

            RuleFor(e => e.Phone)
                .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Invalid phone number.");
        }
    }
}
