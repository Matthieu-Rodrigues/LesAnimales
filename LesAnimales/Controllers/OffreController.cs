using Microsoft.AspNetCore.Mvc;

namespace LesAnimales.Controllers
{
    public class OffreController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}