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
        private readonly SchoolDbContext _context;

        public StudentService(SchoolDbContext context)
        {
            _context = context;
        }

        public void AddStudent(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.FullName))
                throw new ArgumentException("Öğrenci adı boş olamaz.");

            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public void UpdateStudent(Student student)
        {
            var existingStudent = _context.Students.Find(student.Id);
            if (existingStudent == null)
                throw new KeyNotFoundException("Öğrenci bulunamadı.");

            existingStudent.FullName = student.FullName;
            existingStudent.ClassId = student.ClassId;
            _context.SaveChanges();
        }

        public void DeleteStudent(int studentId)
        {
            var student = _context.Students.Find(studentId);
            if (student == null)
                throw new KeyNotFoundException("Öğrenci bulunamadı.");

            _context.Students.Remove(student);
            _context.SaveChanges();
        }

    }
}
