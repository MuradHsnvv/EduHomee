using EduHome2.Models;
using System.Collections.Generic;

namespace EduHome2.ViewModels
{
    public class HomeVM
    {
        public List<Service> Services { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Course> Courses { get; set; }
        public About About { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Event> Events { get; set; }
    }
}
