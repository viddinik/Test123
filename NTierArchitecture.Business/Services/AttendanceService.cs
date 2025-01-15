using BusinessKatmanı.Validators;
using DataAccessKatmanı.Context;
using DataAccessKatmanı.Repositories;
using FluentValidation;
using FluentValidation.Results;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmanı.Services
{
    public class AttendanceService
    {
        private readonly AttendanceRepository _attendanceRepository;

        public AttendanceService(AttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        public IEnumerable<Attendance> GetAllAttendances()
        {
            return _attendanceRepository.GetAll();
        }

        public Attendance GetAttendanceById(int id)
        {
            return _attendanceRepository.GetByID(id);
        }

        public void AddAttendance(Attendance attendance)
        {
            AttendanceValidator validator = new();
            ValidationResult result = validator.Validate(attendance);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _attendanceRepository.Add(attendance);
        }

        public void UpdateAttendance(Attendance attendance)
        {
            _attendanceRepository.Update(attendance);
        }

        public void DeleteAttendance(int id)
        {
            _attendanceRepository.Delete(id);
        }

        public bool IfAttendanceExists(int id)
        {
            return _attendanceRepository.IfEntityExists(a => ((Attendance)a).Id == id);
        }
    }
}
