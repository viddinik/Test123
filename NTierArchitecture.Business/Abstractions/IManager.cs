using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatmanı.Abstractions
{
    public interface IManager<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> GetAll(int id);
    }
}
