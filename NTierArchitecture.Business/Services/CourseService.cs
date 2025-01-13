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
        private readonly SchoolDbContext _context;

        public CourseService(SchoolDbContext context)
        {
            _context = context;
        }

        public void AddCourse(Course newCourse)
        {
            if (string.IsNullOrWhiteSpace(newCourse.Name))
                throw new ArgumentException("Ders adı boş olamaz.");

            if (_context.Courses.Any(c => c.Name == newCourse.Name))
                throw new InvalidOperationException("Bu ders zaten mevcut.");

            _context.Courses.Add(newCourse);
            _context.SaveChanges();
        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public void DeleteCourse(int courseId)
        {
            var existingCourse = _context.Courses.Find(courseId);
            if (existingCourse == null)
                throw new KeyNotFoundException("Ders bulunamadı.");

            _context.Courses.Remove(existingCourse);
            _context.SaveChanges();
        }

    }
}
