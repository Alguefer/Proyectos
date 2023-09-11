
using Gaming_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gaming_Store.Controllers
{
    public class VentaController : Controller
    {
        private readonly ILogger<VentaController> _logger;

        public VentaController(ILogger<VentaController> logger)
        {
            _logger = logger;
        }
        public IActionResult NuevaVenta()
        {
            return View();
        }
    }
}
