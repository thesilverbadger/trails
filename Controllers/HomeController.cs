using Microsoft.AspNet.Mvc;

namespace trails.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Following along with the Pluralsight ASP.NET Core 1.0 Play by Play course.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "The contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
