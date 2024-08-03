
using Microsoft.AspNetCore.Mvc;
using rinha_backend_cs.Data
using System.Linq.Expressions;

namespace rinha_backend_cs.Controllers
{

    public class AddController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AddController(AppDbContext context) {
            context = _context;
        }

        [HttpGet("[controller]")]



}