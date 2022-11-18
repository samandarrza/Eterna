using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Services = Data.Services,
                Features = Data.Features,
                Sliders = Data.Slider,
            };
            return View(vm);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
