using Microsoft.AspNetCore.Mvc;

namespace HelloWebAPI.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string GetMessage()
        {
            return "Hello ASP.NET Core Web API";
        }
    }
}
