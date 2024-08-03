
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using rinha_backend_cs.Data;

namespace rinha_backend_cs.Controllers{

    public class LoginController : Controller{
        private readonly AppDbContext _context;

            public LoginController(AppDbContext context){
                _context = context;
            }


        [HttpGet("[controller]")]
        public ActionResult Index(){

            //Request.Headers.TryGetValue("authentication", out var login);
            
            return View();
        }

        [HttpPost("[controller]")]
        public IActionResult Post([FromForm] LoginData data) {

            Console.WriteLine($"{data.Name} | {data.Pass}");
            if(_context.Users == null)  return NotFound(new { Erro = "Database its down."});
            if(data.Name == null || data.Pass == null) return BadRequest(new { Erro = "Campos incompletos." });
            
            var user = _context.Users.FirstOrDefault(u => u.Name == data.Name && u.Password == data.Pass); 

            if (user == null) return Unauthorized(new { Erro = "Invalid credenttials." });

            return Redirect("users");
        }
    }
}
