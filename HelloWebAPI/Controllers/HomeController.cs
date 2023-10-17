using HelloWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebAPI.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        //Alt kısımda ResponseModel yerine IActionResult olmasının sebebi başka kodlar gönderebilmesini sağlamak
        //eğer alttaki ResponseModel ile ilgili bir sorun yaşanırsa farklı bir kod return edilebilinir
        [HttpGet]
        public IActionResult GetMessage()
        {
            var result = new ResponseModel()
            {
                HttpStatus = 200,
                Message = "Hello ASP.NET Core Web API"
            };

            return Ok(result);
        }
    }
}
