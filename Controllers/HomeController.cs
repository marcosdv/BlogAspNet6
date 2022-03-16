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
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
