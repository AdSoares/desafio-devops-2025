using Microsoft.AspNetCore.Mvc;

namespace DevOps2025.Controllers
{
    [ApiController]
    [Route("time")]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(DateTime.Now.ToString());
    }
}