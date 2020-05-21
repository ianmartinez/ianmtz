using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ianmtz.Models;
using Microsoft.AspNetCore.Diagnostics;

namespace ianmtz.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ErrorController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            var statusCode = HttpContext.Response.StatusCode;
            return View(statusCode);
        }
    }
}
