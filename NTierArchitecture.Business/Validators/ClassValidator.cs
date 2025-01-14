using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmanı.Validators
{
    public class ClassValidator : AbstractValidator<Class>
    {
        public ClassValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("Name boş olamaz.")
                .MaximumLength(100)
                .WithMessage("Name en fazla 100 karakter olabilir.");
        }
    }
}
