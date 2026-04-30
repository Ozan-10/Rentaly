using Microsoft.AspNetCore.Mvc;

namespace Rentaly.WebUI.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult NotFoundPage()
        {
            return View();
        }
    }
}