using Microsoft.AspNetCore.Mvc;
using rinha_backend_cs.Model;

namespace rinha_backend_cs.Controller{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase {
        
        [HttpGet]
        public IActionResult Get([FromQuery] string? id){
            Console.WriteLine($"{id}");
            return id is null 
                ? NotFound()
                : Ok(id);
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] LoginData data) {
            return data is null 
                ? BadRequest(new {message = "Campos devem ser preenchidos."}) 
                : Ok($"username: {data.Name}, pass: {data.Pass}");
        }

    }
}