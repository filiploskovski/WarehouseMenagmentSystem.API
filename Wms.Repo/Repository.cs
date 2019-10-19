using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
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
        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await Task.FromResult(dataContext.Set<T>().Where(predicate));
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await Task.FromResult(dataContext.Set<T>().ToList());
        }

        public async Task<T> GetById(int id)
        {
            return await Task.FromResult(dataContext.Set<T>().Find(id));

        }

        public async Task Insert(T entity)
        {
            await dataContext.Set<T>().AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await dataContext.Set<T>().AddRangeAsync(entities);
        }

        public async Task Remove(T entity)
        {
            dataContext.Set<T>().Remove(entity);
        }

        public async Task RemoveRange(IEnumerable<T> entities)
        {
            dataContext.Set<T>().RemoveRange(entities);
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}