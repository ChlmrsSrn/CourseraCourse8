using Microsoft.AspNetCore.Mvc;
using SafeVault.Models;
using SafeVault.Helpers;
using SafeVault.Data;

namespace SafeVault.Controllers
{
    public class HomeController : Controller
    {
        private readonly SafeVaultContext _context;

        public HomeController(SafeVaultContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(User user)
        {
            user.Username = InputSanitizer.Sanitize(user.Username);
            user.Email = InputSanitizer.Sanitize(user.Email);

            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            return View("Index", user);
        }
    }
}