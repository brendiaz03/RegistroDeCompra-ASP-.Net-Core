using Microsoft.AspNetCore.Mvc;
using PrimerParcial.Logica;
using PrimerParcialPractico_brenda_diaz.Models;

namespace PrimerParcialPractico_brenda_diaz.Controllers
{
    public class CompraController : Controller
    {
        private readonly ICompraLogica _compraLogica;

        public CompraController(ICompraLogica compraLogica)
        {
            _compraLogica = compraLogica;
        }

        [HttpGet]
        public IActionResult RegistrarCompra()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarCompra(CompraViewModel compraModel)
        {
            if (!ModelState.IsValid)
            {
                return View(compraModel);
            }

            _compraLogica.RegistrarCompra(CompraViewModel.ToCompra(compraModel));

            return RedirectToAction("Resultado");
        }

        [HttpGet]
        public IActionResult Resultado()
        {
            var compras = _compraLogica.Resultados();

            return View(CompraViewModel.FromCompra(compras));
        }
    }
    }

