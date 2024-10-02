using Microsoft.AspNetCore.Mvc;

namespace Amazon.Controllers
{
    public class SignOnController : Controller
    {
       [HttpGet]
       public IActionResult SignOn()
        {
            return View();
        }
    }
}
