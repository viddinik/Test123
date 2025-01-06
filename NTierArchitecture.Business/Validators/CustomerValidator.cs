using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Validation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CustomerName)
                .NotEmpty().WithMessage("Customer name is required.")
                .MaximumLength(100).WithMessage("Customer name can't be longer than 100 characters.");

            RuleFor(c => c.Phone)
                .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Invalid phone number.");
        }
    }
}
