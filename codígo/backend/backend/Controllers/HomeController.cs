using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        

        public IActionResult Index()
        {
            string mesaValue = HttpContext.Request.Query["mesa"];

            if (string.IsNullOrEmpty(mesaValue))
            {
                mesaValue = "0";
            }

            if (!int.TryParse(mesaValue, out int mesa) || mesa <= 0 || mesa > 10)
            {
                mesa = 0;
            }
            else
            {
                HttpContext.Session.SetString("mesa", mesa.ToString());
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
