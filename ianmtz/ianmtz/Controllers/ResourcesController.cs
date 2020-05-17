using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers
{
    public class ResourcesController : Controller
    {
        public IActionResult AeroLib()
        {
            return View();
        }
    }
}