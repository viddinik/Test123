using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmanı.Validators
{
    public class AttendanceValidator : AbstractValidator<Attendance>
    {
        public AttendanceValidator()
        {
            RuleFor(a => a.StudentId)
                .GreaterThan(0)
                .WithMessage("StudentId 0'dan büyük olmalıdır.");

            RuleFor(a => a.CourseId)
                .GreaterThan(0)
                .WithMessage("CourseId 0'dan büyük olmalıdır.");

            RuleFor(a => a.Date)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("Date bugünden ileri bir tarih olamaz.");

            RuleFor(a => a.Status)
                .NotNull()
                .WithMessage("Status boş olamaz.");
        }
    }
}
