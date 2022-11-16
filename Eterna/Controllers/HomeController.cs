using Eterna.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.Services);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
