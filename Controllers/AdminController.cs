using Microsoft.AspNetCore.Mvc;

namespace SafeVault.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            if (TempData["Role"]?.ToString() != "admin")
            {
                return Unauthorized();
            }
            return View();
        }
    }
}