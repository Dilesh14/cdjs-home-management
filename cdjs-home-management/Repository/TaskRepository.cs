using cdjs.entities;
using cdjs_home_management.DbContexts;
using cdjs_home_management.Repository.Abstract;
using cdjs_home_management.Repository.Interface;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<bool> Add(task newTask)
        {
            await base.Create(newTask);
            return true;
        }

        public async Task<bool> Delete(task task)
        {
            await base.Delete(task);
            return true;
        }

        public async Task<IQueryable<task>> GetAll()
        {
            return await base.FindAll();
        }

        public async Task<bool> Update(task task)
        {
            await base.Update(task);
            return true;
        }
    }
}
