using DataAccessKatmanı.Context;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatmanı.Repositories
{
    public class CourseRepository : GenericRepository<Course>
    {
        public CourseRepository(SchoolDbContext context) : base(context)
        {
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetByCondition(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public Course GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool IfEntityExists(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
