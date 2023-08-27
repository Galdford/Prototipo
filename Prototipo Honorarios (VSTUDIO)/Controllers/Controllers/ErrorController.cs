using Microsoft.AspNetCore.Mvc;

namespace PrototipoPagoHonorarios.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error401()
        {
            return View();
        }

        public IActionResult Error404()
        {
            return View();
        }

        public IActionResult Error500()
        {
            return View();
        }
    }
}
