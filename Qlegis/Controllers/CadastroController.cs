using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Qlegis.Models;
using System.Diagnostics;

namespace Qlegis.Controllers
{
    public class CadastroController : Controller
    {
        private readonly Contexto _context;

        private readonly ILogger<CadastroController> _logger;

        public CadastroController(ILogger<CadastroController> logger, Contexto context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,Password,ConfirmPassword,NumberPhoneCell,ImageAvatarPerfil,State")] UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}