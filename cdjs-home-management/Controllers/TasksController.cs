using cdjs.entities;
using cdjs_home_management.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace cdjs_home_management.Controllers
{
    [Route("service/db/tasks")]
    public class TasksController : Controller
    {
        private IRepositoryWrapper _repowrapper;
        public TasksController(IRepositoryWrapper repowrapper)
        {
            _repowrapper = repowrapper;
        }
        [HttpPost("add")]
        public async Task<bool> AddTask([FromBody] task data)
        {
            task newTask = new task
            {
                DiplayName = data.DiplayName
            };
            try
            {
                await _repowrapper.Tasks.Add(newTask);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpGet("getall")]
        public async Task<IQueryable<task>> GetAllTasks()
        {
            try
            {
                var result = await _repowrapper.Tasks.GetAll();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
