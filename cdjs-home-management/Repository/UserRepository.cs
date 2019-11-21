using cdjs.entities;
using cdjs_home_management.DbContexts;
using cdjs_home_management.Repository.Interface;
using cdjs_home_management.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace cdjs_home_management.Repository
{
    public class UserRepository : RepositoryBase<Users>, IUserRepository
    {
        private readonly cdjsentity _context;

        public UserRepository(cdjsentity context) : base(context) 
        {
        }

        public void Create(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Users> FindAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Users> FindByCondition(Expression<Func<Users, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
