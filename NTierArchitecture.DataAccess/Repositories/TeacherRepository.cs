using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatmanı.Repositories
{
    public class TeacherRepository : GenericRepository<Teacher>
    {
        public TeacherRepository(SchoolDbContext context) : base(context)
        {
        }
    }
}
