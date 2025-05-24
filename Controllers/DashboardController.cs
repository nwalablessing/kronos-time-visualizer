using Microsoft.AspNetCore.Mvc;

namespace KronosDashboard.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
