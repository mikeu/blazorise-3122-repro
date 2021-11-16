using Microsoft.AspNetCore.Mvc;

namespace BlazoriseApp.Controllers
{
    [Route("")]
    public class IndexController : ControllerBase
    {
        [HttpGet("")]
        public string HelloWorld () => "Hello, world!";
    }
}
