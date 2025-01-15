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
        public class TeacherService
        {
            private readonly TeacherRepository _teacherRepository;

            public TeacherService(TeacherRepository teacherRepository)
            {
                _teacherRepository = teacherRepository;
            }

            public IEnumerable<Teacher> GetAllTeachers()
            {
                return _teacherRepository.GetAll();
            }

            public Teacher GetTeacherById(int id)
            {
                return _teacherRepository.GetByID(id);
            }

            public void AddTeacher(Teacher teacher)
            {
                TeacherValidator validator = new();
                ValidationResult result = validator.Validate(teacher);

                if (!result.IsValid)
                {
                    throw new ValidationException(result.Errors);
                }

                _teacherRepository.Add(teacher);
            }

            public void UpdateTeacher(Teacher teacher)
            {
                _teacherRepository.Update(teacher);
            }

            public void DeleteTeacher(int id)
            {
                _teacherRepository.Delete(id);
            }

        public bool IfTeacherExists(int id)
        {
            return _teacherRepository.IfEntityExists(t => ((Teacher)t).Id == id);
        }
        }
    }
