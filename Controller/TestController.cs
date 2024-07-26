using Microsoft.AspNetCore.Mvc;

namespace rinha_backend_cs.Controller{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase {
        
        [HttpGet]
        public IActionResult Get() {
            return Ok();
        }
        
        [HttpGet("{uri}")]
        public IActionResult Get(string uri) {
            return uri != "youtube" ? Ok() : Redirect("https://www.youtube.com");
        }

    }
}