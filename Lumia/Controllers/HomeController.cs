using Lumia.DAL;
using Lumia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lumia.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Testimonial> testimonial = _context.Testimonials.ToList();
            return View(testimonial);
        }
    }
}
