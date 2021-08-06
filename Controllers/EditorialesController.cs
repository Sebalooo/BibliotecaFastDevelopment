using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BibliotecaFastDevelopment.Models;
using MySql.Data.MySqlClient;


namespace BibliotecaFastDevelopment.Controllers
{
    public class EditorialesController : Controller
    {   [HttpGet]
        public IActionResult CrearEditorial()
        {
            using (MySqlConnection _conn = new MySqlConnection(@"Server=localhost;port=3306;Database=Bbibliotecatrabajo;user=root;SslMode=none;password="))
            {
               _conn.Open();
                _conn.Open();
                var queryEditoriales = new MySqlCommand("select id,editorial from editoriales", _conn);
                MySqlDataReader readerEditorial = queryEditoriales.ExecuteReader();
                List<Editoriales> listEditorial = new List<Editoriales>();
                while (readerEditorial.Read())
                {
                    Editoriales e = new Editoriales();
                    e.Editorial_id= readerEditorial.GetInt16(0);
                    e.Editorial= readerEditorial["editorial"].ToString();
                    
		        listEditorial.Add(e);
                }
                ViewBag.ListadoEditorial = listEditorial;


                _conn.Close();

            }           
            return View();
            
        }

    }
}
