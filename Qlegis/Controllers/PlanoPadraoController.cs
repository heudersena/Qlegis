using Microsoft.AspNetCore.Mvc;
using Qlegis.Models;
using System.Diagnostics;

namespace Qlegis.Controllers
{
    public class PlanoPadraoController : Controller
    {
        private readonly ILogger<PlanoPadraoController> _logger;

        public PlanoPadraoController(ILogger<PlanoPadraoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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