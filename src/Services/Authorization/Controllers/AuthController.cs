using Authorization.Models;

using Microsoft.AspNetCore.Mvc;

namespace Authorization.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            return Ok("Registered");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            return Ok("Logged in");
        }
    }
}

