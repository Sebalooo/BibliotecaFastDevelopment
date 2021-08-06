using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using BibliotecaFastDevelopment.Models;


namespace BibliotecaFastDevelopment.Controllers
{
    public class AutoresController : Controller
    {
        public IActionResult CrearAutores()
        {
            List<Autores> ListAutores = new List<Autores>();
            Autores a = new Autores();
            a.cod_autor = 12;
            a.nombre_autor = "James";
            a.ap_paterno = "Richards";
            a.ap_materno = "London";

            using (MySqlConnection _conn = new MySqlConnection(@"Server=localhost;port=3306;Database=bibliotecatrabajo;user=root;SslMode=none;password="))
            {
                _conn.Open();

                return View();
            }
        }

        [HttpPost]
        public RedirectToActionResult CrearAutores(Int16 cod_autor, String nombre_autor, String ap_paterno, String ap_materno)
        {
            String nombre_autorPost = HttpContext.Request.Form["nombre_autor"];
            using (MySqlConnection _conn = new MySqlConnection(@"Server=localhost;port=3306;Database=bibliotecatrabajo;user=root;SslMode=none;password="))
            {
                _conn.Open();
                String InsertAutor = "insert autores (cod_autor,nombre_autor,ap_paterno,ap_materno) values (" + "@cod_autorGet," + "@nombre_autorGet," + "@ap_paternoGet," + "@ap_maternoGet" + ")";
                var cmdUpdate = new MySqlCommand(InsertAutor, _conn);
                cmdUpdate.Parameters.AddWithValue("@cod_autor", cod_autor);
                cmdUpdate.Parameters.AddWithValue("@nombre_autorGet", nombre_autor);
                cmdUpdate.Parameters.AddWithValue("@ap_paternoGet", ap_paterno);
                cmdUpdate.Parameters.AddWithValue("@ap_maternoGet", ap_materno);

                cmdUpdate.ExecuteNonQuery();


                _conn.Close();
            }

            return RedirectToAction(actionName: "CrearAutores", controllerName: "Autores");

        }
    }

}

