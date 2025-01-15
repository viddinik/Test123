using BusinessKatmanı.Validators;
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
    public class StudentService
    {
        private readonly StudentRepository _studentRepository;

        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetByID(id);
        }

        public void AddStudent(Student student)
        {
            StudentValidator validator = new();
            ValidationResult result = validator.Validate(student);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _studentRepository.Add(student);
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.Update(student);
        }

        public void DeleteStudent(int id)
        {
            _studentRepository.Delete(id);
        }

        public bool IfStudentExists(int id)
        {
            return _studentRepository.IfEntityExists(s => ((Student)s).Id == id);
        }
    }
}
