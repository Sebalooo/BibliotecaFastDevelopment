using System;
namespace BibliotecaFastDevelopment.Models
{
    public class ArriendoLibros
    {
       public Int16 nro_arriendo {get;set;}
       public String fecha_arriendo_hora   {get;set;}   
       public Int32 rut_cliente {get;set;}
       public Int32 nro_boleta{get;set;}
       public Int32 nro_serie {get;set;}
       public String ISBN {get;set;}
       public Int32 rut_trabajador {get;set;}
       public Int32 multa{get;set;}
       public Int32 neto_arriendo {get;set;}
       public Int32 iva_arriendo {get;set;}
       public Int32 fecha_dev_estimada {get;set;}
   	   public Int32 fecha_dev_real {get;set;}
    }
}
