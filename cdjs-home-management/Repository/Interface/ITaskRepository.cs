﻿
using cdjs.entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cdjs_home_management.Repository.Interface
{
    public interface ITaskRepository
    {
        Task<IQueryable<cdjs.entities.task>> GetAll();
        Task<bool> Add(task newTask);
        Task<bool> Delete(task task);
        Task<bool> Update(task task);
    }
}
