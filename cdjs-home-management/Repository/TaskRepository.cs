using cdjs.entities;
using cdjs_home_management.DbContexts;
using cdjs_home_management.Repository.Abstract;
using cdjs_home_management.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cdjs_home_management.Repository
{
    public class TaskRepository: RepositoryBase<TaskHandler>,ITaskRepository
    {
        public TaskRepository(cdjsentity _context): base(_context)
        { 
        }
    }
}
