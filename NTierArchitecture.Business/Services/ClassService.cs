using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmanı.Services
{
    public class ClassService
    {
        private readonly SchoolDbContext _context;

        public ClassService(SchoolDbContext context)
        {
            _context = context;
        }

        public void AddClass(Class newClass)
        {
            if (string.IsNullOrWhiteSpace(newClass.Name))
                throw new ArgumentException("Sınıf adı boş olamaz.");

            if (_context.Classes.Any(c => c.Name == newClass.Name))
                throw new InvalidOperationException("Bu sınıf zaten mevcut.");

            _context.Classes.Add(newClass);
            _context.SaveChanges();
        }

        public List<Class> GetAllClasses()
        {
            return _context.Classes.ToList();
        }

        public void DeleteClass(int classId)
        {
            var existingClass = _context.Classes.Find(classId);
            if (existingClass == null)
                throw new KeyNotFoundException("Sınıf bulunamadı.");

            _context.Classes.Remove(existingClass);
            _context.SaveChanges();
        }
    }
}
