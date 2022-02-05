using Jorge_Estrada.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Jorge_Estrada.Controllers
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
            List<Clientes> cliente = new List<Clientes>();
            cliente.Add(new Clientes()
            {
                Cliente = "Jorge Luis Estrada",
                Direccion = "Managua",
                Telefono ="1800",
                Edad=41
            }
            );
            cliente.Add(new Clientes()
            {
                Cliente = "Jorge Luis Murillo",
                Direccion = "Managua",
                Telefono = "1800",
                Edad = 41
            }
            );
            return View(cliente);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Test()
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
