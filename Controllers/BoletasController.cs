using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BibliotecaFastDevelopment.Controllers
{
    public class BoletasController : Controller

    {
        public IActionResult CrearBoletas()
        {
            return View();
        }
        public IActionResult MostrarBoleta()
        {
            return View();
        }
    }
}
