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
    }
}
