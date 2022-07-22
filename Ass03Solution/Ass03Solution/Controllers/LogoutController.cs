using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eStore.Controllers
{
    public class LogoutController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
