using Microsoft.AspNetCore.Mvc;

namespace WeatherDashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("testendpoint")]
        public IActionResult GetTest()
        {
            var response = new { message = "Backend and frontend are communicating!"};
            return Ok(response);
        }
    }
}
