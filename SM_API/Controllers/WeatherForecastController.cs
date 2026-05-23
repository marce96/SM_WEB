using Microsoft.AspNetCore.Mvc;

namespace SM_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
