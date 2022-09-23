using Microsoft.AspNetCore.Mvc;
using Qlegis.Models;
using System.Diagnostics;

namespace Qlegis.Controllers
{
    public class PlanoController : Controller
    {
        private readonly ILogger<PlanoController> _logger;

        public PlanoController(ILogger<PlanoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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