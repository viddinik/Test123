using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmanı.Validators
{
    public class TeacherValidator : AbstractValidator<Teacher>
    {
        public TeacherValidator()
        {
            RuleFor(t => t.FullName)
                .NotEmpty()
                .WithMessage("FullName boş olamaz.")
                .MaximumLength(150)
                .WithMessage("FullName en fazla 150 karakter olabilir.");

            RuleFor(t => t.Branch)
                .NotEmpty()
                .WithMessage("Branch boş olamaz.")
                .MaximumLength(100)
                .WithMessage("Branch en fazla 100 karakter olabilir.");
        }
    }
}
