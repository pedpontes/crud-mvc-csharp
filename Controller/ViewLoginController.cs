

using Microsoft.AspNetCore.Mvc;

namespace rinha_backend_cs.Controller
{
    public class ViewLoginController : Controller{

        [HttpGet]
        public ActionResult Index(){
            return View();
        }
    }
}