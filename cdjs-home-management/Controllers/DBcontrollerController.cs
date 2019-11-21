using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cdjs.entities;
using cdjs_home_management.DbContexts;
using cdjs_home_management.Models;
using cdjs_home_management.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace cdjs_home_management.Controllers
{
    [Route("service/db")]
    public class DBcontrollerController : Controller
    {
        private IRepositoryWrapper _repoWrapper;
        public DBcontrollerController(IRepositoryWrapper context) 
        {
            _repoWrapper = context;
        }
        [HttpPost("add")]
        public bool AddUser([FromBody] Credential userData) 
        {
            Users _newUser = new Users
            {
                FirstName = userData.FirstName,
                LastName = userData.LastName,
                EmailAddress = userData.EmailAddress,
                Password = userData.Password,
                UserName = userData.UserName
            };
            try 
            {
                Users _userInfo = _repoWrapper.Users.FirstOrDefault(x => x.FirstName.Equals(userData.FirstName));
                if(_repoWrapper.Users.Any(x=> userData.UserName.Equals(x.UserName))) 
                {
                    return false;
                }
                _repoWrapper.Users.Add(_newUser);
                _repoWrapper.Save();
            } 
            catch(Exception ex) 
            {
                return false;
            }
            return true;
        }
        [HttpPost("checkCredential")]
        public async Task<bool>  CheckCredential([FromBody]Credential userData) 
        {
            try 
            {
                Users userInfo = await _context.GetUserInfoFromUserName(userData.UserName);
                if (userInfo.Password.Equals(userData.Password)) 
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch(Exception ex) 
            {
                return false;
            }
        }
        public async Task<IEnumerable<Credential>> GetAllUsers() 
        {
            try
            {
                IEnumerable<Users> allUsers = await _context.GetAllUsersAsync();
                IList<Credential> resultTosend = new List<Credential>();
                allUsers.ToList().ForEach(x =>
                {
                    resultTosend.Add(
                        new Credential
                        {
                            UserName = x.UserName,
                            EmailAddress = x.EmailAddress,
                            FirstName = x.FirstName,
                            LastName = x.LastName
                        }
                        );
                });
                return resultTosend;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message + "\t" +ex.StackTrace);
                return null;
            }
        }
    }
}