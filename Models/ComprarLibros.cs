using System;
namespace BibliotecaFastDevelopment.Models
{
    public class ComprarLibros
    {

        public String ISBN { get; set; }
        public Int16 nro_orden { get; set; }
        public Int16 neto_compra { get; set; }
        public Int16 iva_compra { get; set; }
        public Int16 cantidad_compra { get; set; }
        public Int16 nro_factura { get; set; }
        public Int16 rut_distribuidor { get; set; }
        public Int16 rut_trabajador { get; set; }
        public DateTime fecha_orden_hora { get; set; }
    }
}

  
