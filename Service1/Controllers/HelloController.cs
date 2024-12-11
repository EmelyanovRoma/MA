using Microsoft.AspNetCore.Mvc;

namespace Service1.Controllers
{
    [ApiController]
    [Route("service1")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Hello from Service1");

        [HttpGet("status")] 
        public IActionResult Status() => Ok("Service1 is running");
    }
}
