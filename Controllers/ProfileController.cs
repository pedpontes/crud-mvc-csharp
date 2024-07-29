using Microsoft.AspNetCore.Mvc;
using rinha_backend_cs.Data;
using rinha_backend_cs.Models;

namespace rinha_backend_cs.Controllers
{
    public class ProfileController : Controller {

        private readonly AppDbContext _context;

        public ProfileController(AppDbContext context) {
            _context = context;
        }
        
        [HttpGet("[controller]")]
        public IActionResult Get(){
            Request.Headers.TryGetValue("authentication", out var login);

            // Console.WriteLine(header);

            return Redirect("login");

            
            // if(_context.Users == null)  return NotFound(new { Erro = "Database its down"});

            // if(id == null) return BadRequest(new { Erro = "ID is required." });

            // var user = _context.Users.FirstOrDefault(u => u.Id == int.Parse(id));

            // if (user == null)   return NotFound(new { Erro = "User not found."});
            
            // return Ok(user);
        }
        
        
    }
}