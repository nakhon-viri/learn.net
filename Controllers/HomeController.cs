using ASPNETAPI.Services.ThaiDate;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IThaiDate  _thaiDate;
        public HomeController(IThaiDate thaiDate)
        {
            _thaiDate = thaiDate;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var myThaiDate = _thaiDate.ShowThaiDate();
            return Ok(new { message = $"Hello API {myThaiDate}" });
        }
    }
}
