using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TwoAres.Core.Repositories;

namespace TwoAres.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _context;

        public Repository(DbContext context)
        {
            this._context = context;
        }
        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            //throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            //throw new NotImplementedException();
        }
    }
}
