using Microsoft.AspNetCore.Mvc;

namespace EduHome2.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
