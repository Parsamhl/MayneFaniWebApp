using Microsoft.AspNetCore.Mvc;

namespace MayneFaniWebApp_MVC_.Controllers
{
    public class CostomerController : Controller
    {

        public IActionResult CostomerLogin()
        {
            return View();
        }
        
        public  IActionResult CostomerProfile()
        {
            return View();
        }
    }
}
