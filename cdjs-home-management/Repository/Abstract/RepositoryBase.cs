﻿using cdjs_home_management.DbContexts;
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
        public async Task Create(T entity)
        {
            _repoContext.Set<T>().Add(entity);
        }

        public async Task Delete(T entity)
        {
            _repoContext.Set<T>().Remove(entity);
        }

        public async Task<IQueryable<T>> FindAll()
        {
            return _repoContext.Set<T>().AsNoTracking();
        }

        public async Task<IQueryable<T>> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _repoContext.Set<T>().Where(expression).AsNoTracking();
        }

        public async Task Update(T entity)
        {
            _repoContext.Set<T>().Update(entity);
        }
    }
}
