using Microsoft.AspNetCore.Mvc;

namespace ASPNETAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IActionResult Hello()
        {
            return Ok(new { message = "Hello .net" });
        }

        [Route("show/{id}")]
        [HttpGet]
        public IActionResult Show(int id)
        {
            return Ok(new { message = $"Hello {id}" });
        }

        [Route("search")]
        [HttpGet]
        public IActionResult search(string name, int age)
        {
            return Ok(new { message = $"Hello {name} age: {age}" });
        }
    }
}
