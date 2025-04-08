using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers;

public class AboutController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}