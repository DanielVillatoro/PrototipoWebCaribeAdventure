using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CaribeAdventure.Models;

namespace CaribeAdventure.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult Hotel()
        {
            return View();
        }
        public IActionResult Transporte()
        {
            return View();
        }
        public IActionResult ReservaHotel()
        {
            return View();
        }
        public IActionResult ReservaTransporte()
        {
            return View();
        }  
        public IActionResult Actividad()
        {
            return View();
        }  
        public IActionResult Sugerencia()
        {
            return View();
        }
        public IActionResult ReservaActividad()
        {
            return View();
        }
        public IActionResult ReservaSugerencia()
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
