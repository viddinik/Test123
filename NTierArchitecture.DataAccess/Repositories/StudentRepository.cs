using DataAccessKatmanı.Context;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatmanı.Repositories
{
    public class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(SchoolDbContext context) : base(context)
        {

        }

        public IEnumerable<Student> GetByCondition(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
