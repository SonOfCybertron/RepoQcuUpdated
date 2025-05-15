using System.Collections.Generic;

namespace YourNamespace.Models
{
    public class AboutUsViewModel
    {
        public required string Title { get; set; }
        public required string Mission { get; set; }
        public required string Description { get; set; }
        public required List<Developer> Developers { get; set; }
    }

    public class Developer
    {
        public required string ImageUrl { get; set; }
        public required string Name { get; set; }
        public required string CourseTitle { get; set; }
    }
}

