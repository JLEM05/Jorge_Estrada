using Jorge_Estrada.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using Jorge_Estrada.Data;
using System.Linq;

namespace Jorge_Estrada.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly MyDbContext _context;
        public CategoriaController(MyDbContext context)
        {
           
            _context = context;
        }
        public IActionResult ListaCategorias()
        {
            List<Models.Categoria> catego = _context.Categorias.ToList();
            return View(catego);
            
        }
        public IActionResult Getcategorias()
        {
            return View("Views/Categoria/Categorias.cshtml");
        }
        public IActionResult Crearcategoria(Categoria categoria)
        {
            categoria.FechaActual = System.DateTime.Now;
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return RedirectToAction("ListaCategorias");
        }
        public IActionResult Editarcategoria(int id)
        {
            Categoria modelo = _context.Categorias.Where(c => c.CategoriaId == id).FirstOrDefault();
            return View("EditarCategoria",modelo);
        }
        public IActionResult EditarValorcategoria(Categoria categoria)
        {
            Categoria categoriaactual = _context.Categorias.Where(c => c.CategoriaId == categoria.CategoriaId).FirstOrDefault();
            categoriaactual.Nombrecategoria = categoria.Nombrecategoria;
            categoriaactual.Descripcion = categoria.Descripcion;

            _context.SaveChanges();
            return RedirectToAction("ListaCategorias");
        }

        public IActionResult Eliminarcategoria(Categoria categoria)
        {
            Categoria categoriaactual = _context.Categorias.Where(c => c.CategoriaId == categoria.CategoriaId).FirstOrDefault();
            categoriaactual.Nombrecategoria = categoria.Nombrecategoria;
            categoriaactual.Descripcion = categoria.Descripcion;

            _context.SaveChanges();
            return RedirectToAction("ListaCategorias");
        }
    }
}
