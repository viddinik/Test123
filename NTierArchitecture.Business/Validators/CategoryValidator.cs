using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Validation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName)
                .NotEmpty().WithMessage("Category name is required.")
                .MaximumLength(100).WithMessage("Category name can't be longer than 100 characters.");

            RuleFor(c => c.Description)
                .MaximumLength(500).WithMessage("Description can't be longer than 500 characters.");
        }
    }
}
