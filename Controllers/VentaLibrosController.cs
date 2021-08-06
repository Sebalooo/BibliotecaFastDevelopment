using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace BibliotecaFastDevelopment.Controllers
{
    public class VentaLibrosController : Controller
    {
        
        public IActionResult CrearVentas()
        {
            return View();
        }
        public IActionResult MostrarVentas()
        {
            return View();
        }
        public IActionResult EditarVentas()
        {
            return View();
        }
        public IActionResult BorrarVentas()
        {
            return View();
        }
    }
}