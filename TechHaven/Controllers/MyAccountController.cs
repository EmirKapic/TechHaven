using Microsoft.AspNetCore.Mvc;

namespace TechHaven.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Order()
        {
            return View();
        }

        public IActionResult Wishlist()
        {
            return View();
        }
    }
}
