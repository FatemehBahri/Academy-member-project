using Microsoft.AspNetCore.Mvc;

namespace GroupProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
