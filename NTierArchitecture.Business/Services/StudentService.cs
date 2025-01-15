using DataAccessKatmanı.Abstractions;
using DataAccessKatmanı.Repositories;
using NTierArchitecture.Entities.Models;

namespace BusinessKatmanı.Services
{
    public class StudentService : IManager<Student>
    {
        private readonly StudentRepository _studentRepository;

        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Add(Student entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _studentRepository.Add(entity);
        }

        public void Delete(Student entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _studentRepository.Delete(entity);
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public IEnumerable<Student> GetAll(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be greater than zero.", nameof(id));

            return _studentRepository.GetByCondition(s => ((Student)s).Id == id);
        }

        public Student GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be greater than zero.", nameof(id));

            return _studentRepository.GetById(id);
        }

        public void Update(Student entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _studentRepository.Update(entity);
        }
    }
}

