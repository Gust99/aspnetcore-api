using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TwoAres.Core.Repositories
{
    public interface IRepository<T> where T : class
    {       
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        void Remove(T entity);
        IEnumerable<T>Find(Expression<Func<T, bool>> predicate);
    }
}
