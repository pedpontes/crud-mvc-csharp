

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using rinha_backend_cs.Data;
using rinha_backend_cs.Models;

namespace rinha_backend_cs.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase{

        private readonly AppDbContext _context;

        public LoginController(AppDbContext context){
            _context = context;
        }

        [HttpPost]
        public IActionResult Post([FromForm] LoginData data) {
            if(_context.Users == null)  return NotFound(new { Erro = "Database its down."});

            if(data.Name == null || data.Pass == null) return BadRequest(new { Erro = "Campos incompletos." });

            var user = _context.Users.FirstOrDefault(u => u.Name == data.Name && u.Password == data.Pass);

            if (user == null) return Unauthorized(new { Erro = "Invalid credenttials." });

            return Ok(new { message = $"Sucessefull login: {user.Name}"});
        }
    }
}