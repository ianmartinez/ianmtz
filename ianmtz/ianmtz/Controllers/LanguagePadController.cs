using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ianmtz.Controllers
{
    public class LanguagePadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}