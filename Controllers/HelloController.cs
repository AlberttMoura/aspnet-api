using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers
{
  [Route("api")]
  [ApiController]
  public class HelloController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      return Ok("Hello, World!");
    }
  }
}