using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers;

public class ChameleonController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}