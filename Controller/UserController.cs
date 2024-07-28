using Microsoft.AspNetCore.Mvc;
using rinha_backend_cs.Data;
using rinha_backend_cs.Models;

namespace rinha_backend_cs.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase {

        private readonly AppDbContext _context;

        public UserController(AppDbContext context) {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Get([FromQuery] string? id){
            
            if(_context.Users == null)  return NotFound(new { Erro = "Database its down"});

            if(id == null) return BadRequest(new { Erro = "ID is required." });

            var user = _context.Users.FirstOrDefault(u => u.Id == int.Parse(id));

            if (user == null)   return NotFound(new { Erro = "User not found."});
            
            return Ok(user);
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] LoginData data) {
            if(_context.Users == null)  return NotFound(new { Erro = "Database its down."});

            if(data.Name == null || data.Pass == null) return BadRequest(new { Erro = "Campos incompletos." });

            var user = _context.Users.FirstOrDefault(u => u.Name == data.Name && u.Password == data.Pass);

            if (user == null) return Unauthorized(new { Erro = "Invalid credenttials." });

            return Ok(new { message = $"Sucessefull login: {user.Name}"});
        }
    }
}