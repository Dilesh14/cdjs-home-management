using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cdjs.entities;
using cdjs_home_management.DbContexts;
using cdjs_home_management.Models;
using Microsoft.AspNetCore.Mvc;

namespace cdjs_home_management.Controllers
{
    [Route("service/db")]
    public class DBcontrollerController : Controller
    {
        private cdjsentity _context;
        public DBcontrollerController(cdjsentity context) 
        {
            _context = context;
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
                Users _userInfo = _context.Users.FirstOrDefault(x => x.FirstName.Equals(userData.FirstName));
                if(_context.Users.Any(x=> userData.UserName.Equals(x.UserName))) 
                {
                    return false;
                }
                _context.Users.Add(_newUser);
                _context.SaveChanges();
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
    }
}