using Microsoft.AspNetCore.Mvc;

namespace Jorge_Estrada.Controllers
{
    public class UNIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
