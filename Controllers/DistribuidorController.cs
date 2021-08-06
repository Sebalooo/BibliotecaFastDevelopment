using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BibliotecaFastDevelopment.Models;
using MySql.Data.MySqlClient;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BibliotecaFastDevelopment.Controllers
{
    public class DistribuidorController : Controller
    {

        public IActionResult CrearDistribuidor()
        {
            return View();
        }
        public IActionResult EditarDistribuidor()
        {
            return View();
        }
        public IActionResult BorrarDistribuidor()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MostrarDistribuidor()

        {
            List<Distribuidor> LisDristi = new List<Distribuidor>();
            //  Clientes c = new Clientes();
            // c.rut_cliente = 193452344;
            //c.dv_cliente = "9";
            // c.nombres = "Sebastian";
            // c.ap_paterno = "Uribe";
            // c.ap_materno = "Pozo";
            // c.fecha_nac = "1987,04,02";
            //c.cod_correo = 10;
            //c.cod_direccion = 12;
            //c.cod_telefono = 20;
            using (MySqlConnection _conn = new MySqlConnection(@"Server=localhost;port=3306;Database=bibliotecatrabajo;user=root;SslMode=none;password="))
            {
                _conn.Open();

                var query = new MySqlCommand("SELECT nombres,ap_paterno,ap_materno,fecha_Nac,rut_cliente FROM clientes", _conn);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Distribuidor D2 = new Distribuidor();
                    D2.rut_distribuidor = Convert.ToInt16(reader["rut_cliente"]); ;
                    D2.dv_distribuidor = reader.GetString(1);
                    D2.razon_social = reader.GetString(1);
                    D2.telefono = reader.GetString(1);
                    D2.direccion = reader.GetString(1);
                    //reader["Editoriales"].ToString();

                    LisDristi.Add(D2);

                }
                _conn.Close();

            }
            //ViewBag.ListadoLibross = ListLibross;
            return View(LisDristi);
        }
    }
}