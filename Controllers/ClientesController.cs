using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaFastDevelopment.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BibliotecaFastDevelopment.Controllers
{
    public class ClientesController : Controller
    {     
         [HttpGet]
        public IActionResult MostrarCliente()
        {
            List<Clientes> ListClientes = new List<Clientes>();
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
                    Clientes C2 = new Clientes();
                    C2.nombres = reader.GetString(1);
                    C2.ap_materno = reader.GetString(1);
                    C2.ap_materno = reader.GetString(1);
                    C2.fecha_nac = reader.GetString(1);
                    C2.rut_cliente = Convert.ToInt32(reader["rut_cliente"]);                 
                    //reader["Editoriales"].ToString();

                    ListClientes.Add(C2);

                }
                _conn.Close();

            }
            //ViewBag.ListadoLibross = ListLibross;
            return View(ListClientes);
        }
        [HttpPost]
        public RedirectToActionResult CrearCliente(String nombres,String dv_cliente, String ap_paterno, String ap_materno, String fecha_nac, Int32 rut_cliente, Int32 cod_correo, Int16 cod_direccion, Int16 cod_telefono)
        {
            String nombresPost = HttpContext.Request.Form["nombres"];
            using (MySqlConnection _conn = new MySqlConnection(@"Server=localhost;port=3306;Database=bibliotecatrabajo;user=root;SslMode=none;password="))
            {
                _conn.Open();
               String InsertCliente = "insert clientes (rut_cliente, dv_cliente,nombres,ap_paterno,ap_materno,fecha_nac,cod_correo,cod_direccion, cod_telefono) values (" +"@rut_clienteGet,"+"@dv_clienteGet,"+"@nombresGet,"+"@ap_paternoGet,"+"@ap_maternoGet,"+"@fecha_nacGet,"+"@cod_correoGet,"+"@cod_direccionGet,"+"@cod_telefonoGet" + ")";
                var cmdUpdate = new MySqlCommand(InsertCliente, _conn);
                cmdUpdate.Parameters.AddWithValue("@rut_clienteGet", rut_cliente);
                cmdUpdate.Parameters.AddWithValue("@dv_clienteGet", dv_cliente);
                cmdUpdate.Parameters.AddWithValue("@nombresGet", nombres);
                cmdUpdate.Parameters.AddWithValue("@ap_paternoGet", ap_paterno );
                cmdUpdate.Parameters.AddWithValue("@ap_maternoGet", ap_materno);
                cmdUpdate.Parameters.AddWithValue("@fecha_nacGet", fecha_nac);
                cmdUpdate.Parameters.AddWithValue("@cod_correoGet", cod_correo);
                cmdUpdate.Parameters.AddWithValue("@cod_direccionGet", cod_direccion);
                cmdUpdate.Parameters.AddWithValue("@cod_telefonoGet", cod_telefono);
                cmdUpdate.ExecuteNonQuery();


                _conn.Close();

            }


            return RedirectToAction(actionName: "CrearCliente", controllerName: "Clientes");
        }


        public IActionResult EditarCliente()
        {
            return View();
        }
        public IActionResult BorrarCliente()
        {
            return View();
        }
    }
}
