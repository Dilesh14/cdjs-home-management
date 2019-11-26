﻿using cdjs.entities;
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
    }
}
