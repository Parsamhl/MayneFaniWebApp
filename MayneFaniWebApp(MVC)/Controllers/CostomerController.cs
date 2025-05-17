using App.Domain.Core.Mayne.User.AppService.CostomerAppService;
using App.Domain.Core.Mayne.User.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MayneFaniWebApp_MVC_.Controllers
{
    public class CostomerController : Controller
    {
        private readonly ICostomerAppService _costomerAppService;

        public CostomerController(ICostomerAppService costomerAppService)
        {
			_costomerAppService = costomerAppService;
		}
        public IActionResult CostomerLogin()
        {
            return View();
        }

        public IActionResult CostomerProfile()
        {
            return View();
        }

        public IActionResult CostomerRegister(Costomer costomer)
        {
            if(ModelState.IsValid)
            {
                
                return RedirectToAction("CostomerRegister");
            }
            else
            {
                
                return View(costomer); 
            }
        }
    }
}
