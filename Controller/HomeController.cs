using Microsoft.AspNetCore.Mvc;
using rinha_backend_cs.Models;

namespace rinha_backend_cs.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase {
        
        [HttpGet]
        public IActionResult Get([FromQuery] string? id){
            Console.WriteLine($"{id}");
            return id is null 
                ? NotFound()
                : Ok(id);
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] LoginData data) {

            // using(var db = new UserContext()){
            //     Userdb.Users.AddAsync(data.UserName, data.Password);
            // }



            return data is null 
                ? BadRequest(new {message = "Campos devem ser preenchidos."}) 
                : Ok($"username: {data.Name}, pass: {data.Pass}");
        }

    }
}