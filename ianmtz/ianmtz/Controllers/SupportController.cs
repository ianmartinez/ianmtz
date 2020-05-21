using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers
{
    public class SupportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}