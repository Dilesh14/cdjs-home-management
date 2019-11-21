using cdjs_home_management.DbContexts;
using cdjs_home_management.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace cdjs_home_management.Repository.Abstract
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected cdjsentity _repoContext { get; set; }

        public RepositoryBase(cdjsentity context) 
        {
            this._repoContext = context;
        }
        public void Create(T entity)
        {
            _repoContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _repoContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return _repoContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _repoContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            _repoContext.Set<T>().Update(entity);
        }
    }
}
