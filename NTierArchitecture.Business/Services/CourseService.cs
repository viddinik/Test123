using DataAccessKatmanı.Abstractions;
using DataAccessKatmanı.Repositories;
using NTierArchitecture.Entities.Models;

namespace BusinessKatmanı.Services
{
    public class CourseService : IManager<Course>
    {
        private readonly CourseRepository _courseRepository;

        public CourseService(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void Add(Course entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _courseRepository.Add(entity);
        }

        public void Delete(Course entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _courseRepository.Delete(entity);
        }

        public IEnumerable<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }

        public IEnumerable<Course> GetAll(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be greater than zero.", nameof(id));

            return _courseRepository.GetByCondition(c => ((Course)c).Id == id);
        }

        public Course GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be greater than zero.", nameof(id));

            return _courseRepository.GetById(id);
        }

        public void Update(Course entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _courseRepository.Update(entity);
        }
    }

}

