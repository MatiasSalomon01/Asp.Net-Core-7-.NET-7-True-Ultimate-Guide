using Microsoft.AspNetCore.Mvc;

namespace Section25_Identity.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
