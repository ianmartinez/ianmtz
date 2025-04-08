using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ianmtz.Controllers;

public class ErrorController(ILogger<HomeController> logger) : Controller
{
  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Index()
  {
    var statusCode = HttpContext.Response.StatusCode;
    return View(statusCode);
  }
}
