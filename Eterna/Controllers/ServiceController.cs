using Eterna.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.Services);
        }
        public IActionResult Detail(int id)
        {
            Service service = Data.Services.Find(x => x.Id == id);

            return View(service);
        }
    }
}
