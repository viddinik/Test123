using DataAccessKatmanı.Abstractions;
using DataAccessKatmanı.Repositories;
using NTierArchitecture.Entities.Models;

namespace BusinessKatmanı.Services
{
    public class TeacherService : IManager<Teacher>
    {
            private readonly TeacherRepository _teacherRepository;

            public TeacherService(TeacherRepository teacherRepository)
            {
                _teacherRepository = teacherRepository;
            }

        public void Add(Teacher entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _teacherRepository.Add(entity);
        }

        public void Delete(Teacher entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _teacherRepository.Delete(entity);
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _teacherRepository.GetAll();
        }

        public IEnumerable<Teacher> GetAll(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be greater than zero.", nameof(id));

            return _teacherRepository.GetByCondition(t => ((Teacher)t).Id == id);
        }

        public Teacher GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be greater than zero.", nameof(id));

            return _teacherRepository.GetById(id);
        }

        public void Update(Teacher entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _teacherRepository.Update(entity);
        }
    }
}
