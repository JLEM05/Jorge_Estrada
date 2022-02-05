using Microsoft.AspNetCore.Mvc;

namespace Jorge_Estrada.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Curso()
        {
            return View();
        }
    }
}
