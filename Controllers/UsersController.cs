using Microsoft.AspNetCore.Mvc;
using crud_api_view.Data;
using crud_api_view.Models;
using Microsoft.AspNetCore.Razor.Language;
using System.Diagnostics.CodeAnalysis;

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

        [HttpPut("[controller]")]
        public IActionResult Put([FromBody] User data){
            Console.WriteLine(data.Id);
            if(data == null) return StatusCode(400);

            try
            {
                var user = _context.Users.FirstOrDefault(x => x.Id == data.Id);
                if(user == null) return StatusCode(404);
                if(!string.IsNullOrEmpty(data.Name)) user.Name = data.Name;
                if(data.Age != 0) user.Age = data.Age;
                if(!string.IsNullOrEmpty(data.Password)) user.Password = data.Password;

                _context.SaveChanges();

                return StatusCode(200);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: ", ex);
                return StatusCode(500);
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