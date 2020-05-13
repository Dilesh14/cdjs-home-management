using cdjs_home_management.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cdjs_home_management.Repository.Interface
{
    public interface IRepositoryWrapper
    {
        IUserRepository Users { get; }
        ITaskRepository Tasks { get; }
        void Save();
    }
}
