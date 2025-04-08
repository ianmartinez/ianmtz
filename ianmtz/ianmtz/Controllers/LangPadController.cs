using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers;

public class LangPadController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}