using Core.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Section25_Identity.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View(); //example: Index.cshtml
        }

        [HttpPost]
        public IActionResult Register(RegisterDTO registerDTO)
        {
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
