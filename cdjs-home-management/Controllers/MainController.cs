using cdjs_home_management.Models;
using Microsoft.AspNetCore.Mvc;

namespace cdjs_home_management.Controllers
{
    [Route("main")]
    public class MainController : Controller
    {

        [HttpGet("outh")]
        public bool VerifyUser()
        {
            return true;
        }
        [HttpPost("outh")]
        public bool CheckForCredential([FromBody]Credential userData)
        {
            if (userData.UserName.Equals("dilesh")) 
            {
                return true;
            }
            return false;
        }
        [HttpGet("change")]
        public ActionResult ChangeView()
        {
            return View("Change");
        }
        [HttpPost("register") ]
        public bool RegisterUser([FromBody] Credential userData) 
        {
            return true;
        }
    }
}