using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers;

public class CardinalQemuController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}