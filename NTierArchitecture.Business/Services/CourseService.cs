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
    public class CourseService
    {
        private readonly CourseRepository _courseRepository;

        public CourseService(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAll();
        }

        public Course GetCourseById(int id)
        {
            return _courseRepository.GetByID(id);
        }

        public void AddCourse(Course course)
        {
            CourseValidator validator = new();
            ValidationResult result = validator.Validate(course);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _courseRepository.Add(course);
        }

        public void UpdateCourse(Course course)
        {
            _courseRepository.Update(course);
        }

        public void DeleteCourse(int id)
        {
            _courseRepository.Delete(id);
        }

        public bool IfCourseExists(int id)
        {
            return _courseRepository.IfEntityExists(c => ((Course)c).Id == id);
        }
    }
}
