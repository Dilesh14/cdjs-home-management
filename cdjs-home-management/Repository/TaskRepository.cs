using cdjs.entities;
using cdjs_home_management.DbContexts;
using cdjs_home_management.Repository.Abstract;
using cdjs_home_management.Repository.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cdjs_home_management.Repository
{
    public class TaskRepository :RepositoryBase<task>, ITaskRepository
    {
        private readonly cdjsentity _context;
        public TaskRepository(cdjsentity context): base(context) 
        {
            _context = context;
        }
        public Task<bool> Add(task newTask)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(task task)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<task>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(task task)
        {
            throw new System.NotImplementedException();
        }
    }
}
