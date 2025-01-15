using DataAccessKatmanı.Abstractions;
using DataAccessKatmanı.Repositories;
using NTierArchitecture.Entities.Models;

namespace BusinessKatmanı.Services
{
    public class ClassService : IManager<Class>
    {
        private readonly ClassRepository _classRepository;

        public ClassService(ClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public void Add(Class entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _classRepository.Add(entity);
        }

        public void Delete(Class entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _classRepository.Delete(entity);
        }

        public IEnumerable<Class> GetAll()
        {
            return _classRepository.GetAll();
        }

        public IEnumerable<Class> GetAll(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be greater than zero.", nameof(id));

            return _classRepository.GetByCondition(c => ((Class)c).Id == id);
        }

        public Class GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be greater than zero.", nameof(id));

            return _classRepository.GetById(id);
        }

        public void Update(Class entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _classRepository.Update(entity);
        }
    }

}
