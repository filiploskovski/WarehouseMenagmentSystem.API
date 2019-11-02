using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Wms.Repo
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>>  Get();
        Task<T> GetById(int id);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);

        Task<List<U>> ListAllAsync<U>(Func<IQueryable<T>, IQueryable<U>> queryCallback);

        Task<TU> FindFirst<TU>(Func<IQueryable<T>, IQueryable<TU>> queryCallback);

        Task Insert(T entity);
        Task InsertRange(IEnumerable<T> entities);

        Task Update(T entity);

        Task Remove(T entity);
        Task RemoveRange(IEnumerable<T> entities);

        Task Save();

    }
}
