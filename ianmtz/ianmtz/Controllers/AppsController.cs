using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers
{
    public class AppsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LanguagePad()
        {
            return View();
        }
    }
}