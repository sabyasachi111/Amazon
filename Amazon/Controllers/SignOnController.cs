using Microsoft.AspNetCore.Mvc;

namespace Amazon.Controllers
{
    public class SignOnController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
