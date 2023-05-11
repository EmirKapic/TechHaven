using Microsoft.AspNetCore.Mvc;

namespace TechHaven.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
