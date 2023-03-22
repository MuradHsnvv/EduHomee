using System;

namespace EduHome2.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Image { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
