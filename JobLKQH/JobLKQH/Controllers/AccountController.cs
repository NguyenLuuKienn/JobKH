using Microsoft.AspNetCore.Mvc;

namespace JobLKQH.Controllers
{
    public class AccountController : Controller
    {
            public IActionResult Login()
            {
                return View();
            }
            public IActionResult Register()
            {
                return View();
            }
    }
}
