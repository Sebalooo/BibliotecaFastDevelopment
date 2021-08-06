using System;
namespace BibliotecaFastDevelopment.Models{
    public class Clientes
    {
        public Int32 rut_cliente { get; set; }
        public String dv_cliente { get; set; }
        public String nombres { get; set; }   
        public String ap_paterno { get; set; }
        public String ap_materno{ get; set; }
        public String fecha_nac { get; set; } 
        public Int32 cod_correo { get; set; }
        public Int16 cod_direccion {get;set;}
        public Int16 cod_telefono {get;set;}
       
    }
}

