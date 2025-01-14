using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatmanı.Repositories
{
    public class AttendanceRepository : GenericRepository<Attendance>
    {
        public AttendanceRepository(SchoolDbContext context) : base(context)
        {

        }

        public IEnumerable<Attendance> GetAttendances()
        {
            throw new NotImplementedException();
        }
    }
}
