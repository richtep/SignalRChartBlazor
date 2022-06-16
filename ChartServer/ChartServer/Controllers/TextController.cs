using Microsoft.AspNetCore.Mvc;

namespace ChartServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
       
        [HttpGet("{textValue}")]
        public ContentResult TextResult(string textValue)
        {
            return Content(textValue);
        }
    }
}