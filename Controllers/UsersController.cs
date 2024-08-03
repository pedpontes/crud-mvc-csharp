using Microsoft.AspNetCore.Mvc;
using rinha_backend_cs.Data;
using System.Linq.Expressions;

namespace rinha_backend_cs.Controllers
{
    public class UsersController : Controller {

        private readonly AppDbContext _context;

        public UsersController(AppDbContext context) {
            _context = context;
        
        [HttpGet("[controller]")]
        public IActionResult Index()
        {
            try
            {
                var users = _context.Users;
                foreach (var user in users){
                    Console.WriteLine($"{user.Id} {user.Name} {user.Age}");
                }
                
            }
            catch(Exception ex) { 
                Console.WriteLine (ex.Message );
            }

            return View();
        }
        
        
    }
}