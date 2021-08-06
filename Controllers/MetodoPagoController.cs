using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BibliotecaFastDevelopment.Models;
using MySql.Data.MySqlClient;

namespace BibliotecaFastDevelopment.Controllers
{
    public class MetodoPagoController : Controller
    {

        [HttpGet]
        public IActionResult CrearMetodoPago()
	   {
            List<MetodoPago> ListMetodoPago = new List<MetodoPago>();
            MetodoPago mt = new MetodoPago();
            mt.cod_metodo = 0 ;
            mt.tipo_pago = "";
            
	    using (MySqlConnection _conn = new MySqlConnection(@"Server=localhost; port=3306;Database=bibliotecatrabajo;user=root;SslMode=none;password="))

            {
                _conn.Open();
            }      return View();
	    }[HttpPost]
        public RedirectToActionResult CrearMetodoPago (Int32 cod_metodo, String tipo_pago)

            {
            String tipo_pagoPost = HttpContext.Request.Form["tipo_pago"];
            using (MySqlConnection _conn = new MySqlConnection(@"Server=localhost; port=3306;Database=bibliotecatrabajo;user=root;SslMode=none;password="))
            {
                _conn.Open();
                String InsertMetodoPago = "insert metodopago (cod_metodo,tipo_pago)values ("+ "@cod_metodoGet," + "@tipo_pagoGet" +")";
                var cmdUpdate = new MySqlCommand(InsertMetodoPago, _conn);
                cmdUpdate.Parameters.AddWithValue("@cod_metodoGet", cod_metodo);
                cmdUpdate.Parameters.AddWithValue("@tipo_pagoGet", tipo_pago);
                cmdUpdate.ExecuteNonQuery();

                _conn.Close();
	    }
            return RedirectToAction(actionName: "CrearMetodoPago", controllerName: "MetodoPago");

        }
        
        public IActionResult MostrarMetodoPago()
        {
            return View();
        }
        public IActionResult EditarMetodoPago()
        {
            return View();
        }
        public IActionResult BorrarMetodoPago()
        {
            return View();
        }
    }
}
