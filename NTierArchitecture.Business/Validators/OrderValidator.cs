using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Validation
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o => o.OrderDate)
                .NotEmpty().WithMessage("Order date is required.");

            RuleFor(o => o.ShipCountry)
                .NotEmpty().WithMessage("Ship country is required.")
                .MaximumLength(50).WithMessage("Ship country can't be longer than 50 characters.");

            RuleFor(o => o.ShipCity)
                .NotEmpty().WithMessage("Ship city is required.")
                .MaximumLength(50).WithMessage("Ship city can't be longer than 50 characters.");

            RuleFor(o => o.ShipAddress)
                .NotEmpty().WithMessage("Ship address is required.")
                .MaximumLength(200).WithMessage("Ship address can't be longer than 200 characters.");
        }
    }
}
