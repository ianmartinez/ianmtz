using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers;

public class LaikaWMController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}