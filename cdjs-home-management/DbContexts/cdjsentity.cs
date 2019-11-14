using cdjs.entities;
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
    }
}
