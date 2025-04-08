using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers;

public class OldController : Controller
{
  public IActionResult ChameleonClassic()
  {
    return View();
  }

  public IActionResult Screensavers()
  {
    return View();
  }
}