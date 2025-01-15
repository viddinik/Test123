using DataAccessKatmanı.Context;
using NTierArchitecture.Entities.Models;
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

        public IEnumerable<Class> GetByCondition(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
