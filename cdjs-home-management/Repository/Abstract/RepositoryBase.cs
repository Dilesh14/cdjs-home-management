using cdjs_home_management.DbContexts;
using cdjs_home_management.Repository.Interface;
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
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
