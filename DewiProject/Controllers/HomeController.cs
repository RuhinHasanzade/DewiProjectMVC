using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DewiProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
