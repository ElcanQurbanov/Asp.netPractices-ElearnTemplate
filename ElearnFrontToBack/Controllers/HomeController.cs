using ElearnFrontToBack.Data;
using ElearnFrontToBack.Models;
using ElearnFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElearnFrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.Where(m=>!m.SoftDelete).ToListAsync();

            IEnumerable<Course> courses = await _context.Courses.Where(m=>!m.SoftDelete).Include(m=> m.courseImages).Include(m=> m.Author).ToListAsync();

            IEnumerable<Event> events = await _context.Events.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<News> news = await _context.News.Where(m => !m.SoftDelete).ToListAsync();


            HomeVM model = new()
            {
                Sliders = sliders,
                Courses = courses,
                Events = events,
                News = news
            };

            return View(model);
        }
    }
}