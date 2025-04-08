using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers;

public class AsciiStudioController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}