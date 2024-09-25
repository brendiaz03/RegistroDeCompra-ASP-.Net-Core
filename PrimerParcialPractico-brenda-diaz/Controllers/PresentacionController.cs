using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace PrimerParcialPractico_brenda_diaz.Controllers
{
    public class PresentacionController : Controller
    {
        public IActionResult Bienvenido()
        {
            return View();
        }
    }
}
