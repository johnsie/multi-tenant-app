using Microsoft.AspNetCore.Mvc;

namespace MultiTenantApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
