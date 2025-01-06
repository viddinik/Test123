using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Validation
{
    public class SupplierValidator : AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(s => s.CompanyName)
                .NotEmpty().WithMessage("Company name is required.")
                .MaximumLength(100).WithMessage("Company name can't be longer than 100 characters.");

            RuleFor(s => s.Phone)
                .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Invalid phone number.");
        }
    }
}
