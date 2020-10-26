using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers
{
    public class HomeController : Controller 
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("project")]
        public IActionResult Project()
        {
            return View();
        }
        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }

}