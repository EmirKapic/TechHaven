using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TechHaven.Controllers
{
    [Authorize]
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
