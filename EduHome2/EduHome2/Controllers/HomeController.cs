using EduHome2.DAL;
using EduHome2.Models;
using EduHome2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> IndexAsync()
        {
            
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _db.Sliders.ToListAsync(),
                Services = await _db.Services.ToListAsync(),
                Courses = await _db.Courses.ToListAsync(),
                About = await _db.Abouts.FirstOrDefaultAsync(),
                Blogs = await _db.Blogs.ToListAsync(),
                Events = await _db.Events.Take(2).ToListAsync()
            };
            return View(homeVM);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
