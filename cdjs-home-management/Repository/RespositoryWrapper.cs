﻿using cdjs_home_management.DbContexts;
using cdjs_home_management.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cdjs_home_management.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private cdjsentity _context;
        private IUserRepository _Users;
        public IUserRepository Users 
        {
            get
            {
                if(_Users == null) 
                {
                    _Users = new UserRepository(_context);
                }
                return _Users;
            }
        }
        public RepositoryWrapper(cdjsentity context) 
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
