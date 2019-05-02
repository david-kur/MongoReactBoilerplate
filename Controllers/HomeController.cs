using System;
using Microsoft.AspNetCore.Mvc;

namespace sampledb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}