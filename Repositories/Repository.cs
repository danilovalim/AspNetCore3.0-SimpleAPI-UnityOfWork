using RepoApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepoApp.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly RepoContextDB _context;

        public Repository(RepoContextDB context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
