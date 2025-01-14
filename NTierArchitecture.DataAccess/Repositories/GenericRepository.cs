using DataAccessKatmanı.Abstractions;
using DataAccessKatmanı.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatmanı.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly SchoolDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(SchoolDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<T> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                return entity;
            }
            else
            {
                throw new Exception("Entity not found");
            }
        }

        public void Update(T entity)
        {
            _context.SaveChanges();
        }
    }
}
