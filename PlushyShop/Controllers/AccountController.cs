using Microsoft.AspNetCore.Mvc;

namespace PlushyShop.Mvc.Controllers
{
    public class AccountController:PlushyBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
