using DataAccessKatmanı.Abstractions;
using DataAccessKatmanı.Repositories;
using NTierArchitecture.Entities.Models;

namespace BusinessKatmanı.Services
{
    public class AttendanceService : IManager<Attendance>
    {
        private readonly AttendanceRepository _attendanceRepository;

        public AttendanceService(AttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        public void Add(Attendance entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _attendanceRepository.Add(entity);
        }

        public void Delete(Attendance entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _attendanceRepository.Delete(entity);
        }

        public IEnumerable<Attendance> GetAll()
        {
            return _attendanceRepository.GetAll();
        }

        public IEnumerable<Attendance> GetAll(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be greater than zero.", nameof(id));

            return _attendanceRepository.GetByCondition(a => ((Attendance)a).Id == id);
        }

        public Attendance GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be greater than zero.", nameof(id));

            return _attendanceRepository.GetById(id);
        }

        public void Update(Attendance entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _attendanceRepository.Update(entity);
        }
    }
}
