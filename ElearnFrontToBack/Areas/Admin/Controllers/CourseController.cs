using ElearnFrontToBack.Data;
using ElearnFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElearnFrontToBack.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //IEnumerable<Course> courses = await _context.Courses.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Course> courses = await _context.Courses.Where(m => !m.SoftDelete).Include(m => m.courseImages).Include(m => m.Author).ToListAsync();

            return View(courses);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();
            Course? course = await _context.Courses.FirstOrDefaultAsync(m => m.Id == id);
            IEnumerable<Course> courses = await _context.Courses.Where(m => !m.SoftDelete).Include(m => m.courseImages).Include(m => m.Author).ToListAsync();


            if (course is null) return NotFound();
            return View(course);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
       
    }
}
