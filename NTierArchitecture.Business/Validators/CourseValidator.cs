using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmanı.Validators
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("Name boş olamaz.")
                .MaximumLength(200)
                .WithMessage("Name en fazla 200 karakter olabilir.");

            RuleFor(c => c.TeacherId)
                .GreaterThan(0)
                .WithMessage("TeacherId 0'dan büyük olmalıdır.");
        }
    }
}
