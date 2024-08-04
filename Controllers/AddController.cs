
using Microsoft.AspNetCore.Mvc;
using crud_api_view.Data;
using crud_api_view.Models;

namespace crud_api_view.Controllers
{
    public class AddController : Controller
    {
        private readonly AppDbContext _context;
        public AddController(AppDbContext context) {
            _context = context;
        }

        [HttpGet("[controller]")]
        public IActionResult Index(){
            return View();
        }
        [HttpPost("[controller]")]
        public IActionResult Post([FromForm] User dataUser){


            if(dataUser.Name == null || dataUser.Password == null || dataUser.Age.ToString() == null) return BadRequest();

            try
            {
                _context.Users.AddAsync(dataUser);
                _context.SaveChanges();
                return Ok(new {status = true});
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Ok(new {status = false});
            }

            // Console.WriteLine($"{dataUser.Name}  {dataUser.Age}  {dataUser.Password}");
            // return Ok(new {message = "Dados enviados com sucesso"});
        }

    }



}