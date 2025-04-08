using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers;

public class TamarackController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}