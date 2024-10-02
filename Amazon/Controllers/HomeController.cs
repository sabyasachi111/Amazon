using Microsoft.AspNetCore.Mvc;

namespace Amazon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
