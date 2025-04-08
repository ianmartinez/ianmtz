using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}
