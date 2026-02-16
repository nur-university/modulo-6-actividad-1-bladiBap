using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace api_gateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {

        [HttpGet("hello")]
        public IActionResult Login()
        {

            return Ok(new
            {
                token = "hello world!!!"
            });
        }
    }
}

