using BlogAspNet6.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace BlogAspNet6.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        [ApiKey]
        public IActionResult Get(IConfiguration config)
        {
            var env = config.GetValue<string>("Env");
            return Ok(new { environment = env });
        }
    }
}
