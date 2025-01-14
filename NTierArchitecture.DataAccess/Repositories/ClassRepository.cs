using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatmanı.Repositories
{
    public class ClassRepository : GenericRepository<Class>
    {
        public ClassRepository(SchoolDbContext context) : base(context)
        {
        }
    }
}
