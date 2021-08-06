using System;
namespace BibliotecaFastDevelopment.Models
{
    public class Libros
    {
        public String ISBN { get; set; }
        public Int16 EditorialID { get; set; }
        public String Titulo { get; set; }
        public Int16 Nro_paginas { get; set; }
        public Int16 A_edicion {get; set; } 
        public Int16 Cantidad_libros { get; set;}
        public String EditorialName { get; set; }
       
    }
}
