using Microsoft.AspNetCore.Mvc;

namespace ElearnFrontToBack.Areas.Admin.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
