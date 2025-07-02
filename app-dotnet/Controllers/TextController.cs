using Microsoft.AspNetCore.Mvc;

namespace DevOps2025.Controllers
{
    [ApiController]
    [Route("text")]
    public class TextController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Eu sou a aplicação .NET!");
    }
}