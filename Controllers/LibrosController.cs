using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BibliotecaFastDevelopment.Models;
using MySql.Data.MySqlClient;


namespace BibliotecaFastDevelopment.Controllers
{
    public class LibrosController : Controller
    {

        
        [HttpGet]
        public IActionResult CrearLibro()
        {
            using (MySqlConnection connx = new MySqlConnection(@"Server=localhost;port=3306;Database=Bibliotecatrabajo;user=user;SslMode=none;password="))
            {  
                connx.Open();
            



                var queryEditoriales = new MySqlCommand("select cod_editorial,nombreEditorial from editoriales", connx);
                MySqlDataReader readerEditorial = queryEditoriales.ExecuteReader();
                List<Editoriales> listEditorial = new List<Editoriales>();
                while (readerEditorial.Read())
                {
                    Editoriales e = new Editoriales();
                    e.Editorial_id = readerEditorial.GetInt16(0);
                    e.Editorial = readerEditorial["nombreEditorial"].ToString();
                    listEditorial.Add(e);
                }
                ViewBag.ListadoEditorial = listEditorial;


                connx.Close();
            }
            return View();
        }


        [HttpGet]
        public IActionResult MostrarLibro ()
        {
            List<Libros> ListLibross = new List<Libros>();
           // Libros l = new Libros();
            //l.ISBN = "7807202900809";
            //l.EditorialID = 21;
            //l.Titulo = "cuaderno";
           // l.Nro_paginas = 100;
           // l.A_edicion = 2019;
           // l.Cantidad_libros = 0;
           // l.EditorialName = "Carlos";
            //**
            //ListLibross.Add(l);

            using (MySqlConnection conn = new MySqlConnection(@"Server=localhost;port=3306;Database=Bibliotecatrabajo;user=user;SslMode=none;password="))
            {
                conn.Open();


                //var query = new MySqlCommand("select isbn,titulo,paginas,a_edicion,cantidad_libros,editoriales_id,e.editorial as 'Editorial' from libros l join editoriales e on e.id=l.editoriales_id", _conn);

                var query = new MySqlCommand("select ISBN,titulo,nro_paginas,ano_edicion,cod_editorial,cantidad_libros, nombreEditorial  from libros  NATURAL join editoriales", conn);
                //select ISBN,titulo,nro_paginas,ano_edicion,cod_editorial,cantidad_libros, nombreEditorial  from libros  NATURAL join editoriales
                //select ISBN,titulo,nro_paginas,ano_edicion,cod_editorial,cantidad_libros from libros  l

                //guardar


                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Libros l2 = new Libros();
                    l2.ISBN = reader.GetString(1);
                    l2.EditorialID = Convert.ToInt16(reader["cod_editorial"]);
                    l2.Titulo = reader.GetString(1);
                    l2.A_edicion = Convert.ToInt16(reader["ano_edicion"]);
                    l2.Nro_paginas = Convert.ToInt16(reader["nro_paginas"]);
                    l2.Cantidad_libros = Convert.ToInt16(reader["cantidad_libros"]); ;
                    l2.EditorialName = reader.GetString(1);
                    //reader["Editoriales"].ToString();

                    ListLibross.Add(l2);

                }
                conn.Close();

            }
            //ViewBag.ListadoLibross = ListLibross;
            return View(ListLibross);
        }
        //*aqui va lo que saque 

        [HttpPost]

        //*cargar el nuevo libro 
        public RedirectToActionResult CrearLibro(string ISBN, string Titulo, Int16 Nro_paginas, Int16 A_edicion, Int16 Cantidad_libros)
        {
            String TituloPost = HttpContext.Request.Form["Titulo"];

            using (MySqlConnection _conn = new MySqlConnection(@"Server=localhost;port=3306;Database=Bibliotecatrabajo;user=user;SslMode=none;password="))
            {
                _conn.Open();
                String InsertLibro = "insert libros (ISBN,titulo,nro_paginas,ano_edicion,cantidad_libros) values (  " +
                    "@ISBN," +
                    "@titulo," +
                    "@nro_paginas," +
                    "@ano_edicion" +
                    "@cantidad_libros" +
                    ")";
                var cmdUpdate = new MySqlCommand(InsertLibro, _conn);

                cmdUpdate.Parameters.AddWithValue("@ISBN", ISBN);
                cmdUpdate.Parameters.AddWithValue("@titulo", Titulo);
                cmdUpdate.Parameters.AddWithValue("@ano_publicado", Nro_paginas);
                cmdUpdate.Parameters.AddWithValue("@Editorial", A_edicion);
                cmdUpdate.Parameters.AddWithValue("@Titulo", Cantidad_libros);

                cmdUpdate.ExecuteNonQuery();
                _conn.Close();

            }

            return RedirectToAction(actionName: "CrearLibro", controllerName: "Libros");
        }


        public IActionResult UpdateLibro()
        {
            return Ok();

        }





    }




}
     




               















