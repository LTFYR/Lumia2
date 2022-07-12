using Lumia.Models;
using System.Collections.Generic;

namespace Lumia.ViewModels
{
    public class HomeVM
    {
        public List<Testimonial> Testimonials { get; set; }
        public List<Comment> Comments { get; set; }
        public List<User> Users { get; set; }
    }
}
