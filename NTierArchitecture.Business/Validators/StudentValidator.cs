using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmanı.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.FullName)
                .NotEmpty()
                .WithMessage("FullName boş olamaz.")
                .MaximumLength(150)
                .WithMessage("FullName en fazla 150 karakter olabilir.");

            RuleFor(s => s.ClassId)
                .GreaterThan(0)
                .WithMessage("ClassId 0'dan büyük olmalıdır.");
        }
    }
}
