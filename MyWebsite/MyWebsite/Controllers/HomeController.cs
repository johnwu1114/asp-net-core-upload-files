using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Album()
        {
            return View();
        }

        public IActionResult Large()
        {
            return View();
        }
    }
}