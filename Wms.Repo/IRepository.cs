using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Wms.Repo
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T GetById(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Insert(T entity);
        void InsertRange(IEnumerable<T> entities);

        void Update(T entity);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}
