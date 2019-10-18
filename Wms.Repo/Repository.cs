using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Wms.Data.Entities;

namespace Wms.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DataContext dataContext;

        public Repository(DataContext context)
        {
            dataContext = context;
        }

        public IEnumerable<T> Get()
        {
            return dataContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return dataContext.Set<T>().Find(id);

        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return dataContext.Set<T>().Where(predicate);
        }

        public void Insert(T entity)
        {
            dataContext.Set<T>().Add(entity);
        }

        public void InsertRange(IEnumerable<T> entities)
        {
            dataContext.Set<T>().AddRange(entities);

        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            dataContext.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dataContext.Set<T>().RemoveRange(entities);

        }
    }
}