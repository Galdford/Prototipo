using Microsoft.AspNetCore.Mvc;

namespace PrototipoPagoHonorarios.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Password()
        {
            return View();
        }
    }
}
