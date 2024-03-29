﻿using cdjs.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cdjs_home_management.DbContexts
{
    public class cdjsentity : DbContext
    {
        public DbSet<Users> Users {get;set;}
        public cdjsentity(DbContextOptions<cdjsentity> options) : base(options) 
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>().ToTable("Users");
        }
        public async Task<Users> GetUserInfoFromUserName(string username) 
        {
            Users _findUser = Users.Where(x => x.UserName.Equals(username)).FirstOrDefault();
            if(_findUser == null) 
            {
                throw new Exception();
            }
            return _findUser;
        }
        public async Task<IEnumerable<Users>> GetAllUsersAsync() 
        {
            IList<Users> allUsers = Users.ToList();
            return allUsers;
        }
    }
}
