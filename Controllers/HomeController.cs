using Jorge_Estrada.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using Jorge_Estrada.Data;

namespace Jorge_Estrada.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _context;

        public HomeController(ILogger<HomeController> logger,MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto()
            {
                Nombreproducto = "Llantas",
                Descripcion = "R14/75P",
                Precio =1800
               
            }
            );
            productos.Add(new Producto()
            {
                Nombreproducto = "Zapatos",
                Descripcion = "Tenis Marca Polo",
                Precio = 2000
            }
            );
            return View(productos);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Get()
        {
            return View("Views/Productos/Productos.cshtml");
        }
        public IActionResult Getcategorias() { 
            return View("Views/Categoria/Categorias.cshtml");
        }
        public IActionResult ListaCategorias()
        {
            return View("Views/Categoria/ListaCategorias.cshtml");
        }
        public IActionResult Crearcategoria(Categoria categoria)
        {
            categoria.FechaActual=System.DateTime.Now;
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
           return RedirectToAction("Getcategorias");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
