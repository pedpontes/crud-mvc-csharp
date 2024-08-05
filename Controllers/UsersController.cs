using Microsoft.AspNetCore.Mvc;
using crud_api_view.Data;
using System.Linq.Expressions;

namespace crud_api_view.Controllers
{
    public class UsersController : Controller {

        private readonly AppDbContext _context;

        public UsersController(AppDbContext context) {
            _context = context;
        }
        [HttpGet("[controller]")]
        public IActionResult Index()
        {
            try
            {
                var users = _context.Users;
                return View(users);
            }
            catch(Exception ex) { 
                Console.WriteLine (ex.Message);
                return Redirect("login");
            }
        }

        [HttpDelete("[controller]")]
        public IActionResult Delete([FromQuery] string id ){
            if(id == "") return BadRequest();
            try
            {
                var user = _context.Users.Find(int.Parse(id));
                if(user == null) return NotFound();
                Console.WriteLine(user.Name);
                _context.Users.Remove(user);
                _context.SaveChanges();
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro:" + ex);
                return StatusCode(500);
            }
        }
    }
}