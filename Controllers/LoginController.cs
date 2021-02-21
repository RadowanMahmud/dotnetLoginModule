using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentTeendanceBackend.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentTeendanceBackend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly IJwtAuthManager jwtAuthManager;

        public LoginController(IJwtAuthManager jwtAuth)
        {
            this.jwtAuthManager = jwtAuth;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserLogin userLogin)
        {

            var token = jwtAuthManager.Authenticate(userLogin.email, userLogin.password);
            if (token == null) return Unauthorized();
            else return Ok(token);
        }

        [HttpGet("name")]
        public IEnumerable<string> Get() {
            return new string[] {"value1", "value2"};
        }
    }
}
