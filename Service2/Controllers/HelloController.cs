using Microsoft.AspNetCore.Mvc;

namespace Service2.Controllers
{
    [ApiController]
    [Route("service2")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Hello from Service2");
    }
}
