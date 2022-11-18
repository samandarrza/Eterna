using Eterna.DAL;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Eterna.Controllers
{
    public class TeamController : Controller
    {
        private readonly EternaDbContext _context;
        public TeamController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Teams.ToList());
        }
    }
}
