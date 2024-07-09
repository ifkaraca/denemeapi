using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace first.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase
    {
        [HttpGet("hava")]
        public IActionResult GetTemperature()
        {
            return Ok("Hava " + 25 + " Derece");
        }

        [HttpPost("topla")]
        public IActionResult AddNumbers(int x, int y)
        {
            int topla = x + y;
            return Ok(topla);
        }   
    }
}
