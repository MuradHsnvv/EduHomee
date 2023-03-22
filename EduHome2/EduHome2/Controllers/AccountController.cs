using EduHome2.DAL;
using Microsoft.AspNetCore.Mvc;

namespace EduHome2.Controllers
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
