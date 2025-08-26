using Microsoft.AspNetCore.Mvc;
using SafeVault.Models;
using SafeVault.Helpers;
using SafeVault.Data;
using System.Linq;

namespace SafeVault.Controllers
{
    public class AccountController : Controller
    {
        private readonly SafeVaultContext _context;

        public AccountController(SafeVaultContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user != null && PasswordHelper.VerifyPassword(password, user.PasswordHash))
            {
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Invalid login.");
            return View();
        }
    }
}