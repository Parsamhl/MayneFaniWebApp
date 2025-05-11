using Microsoft.AspNetCore.Mvc;

namespace MayneFaniWebApp_MVC_.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
