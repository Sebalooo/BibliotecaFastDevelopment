#pragma checksum "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Trabajador/CrearTrabajador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e7f9be0f0727990d0bd350e5a4a305cb686be3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trabajador_CrearTrabajador), @"mvc.1.0.view", @"/Views/Trabajador/CrearTrabajador.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/_ViewImports.cshtml"
using BibliotecaFastDevelopment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/_ViewImports.cshtml"
using BibliotecaFastDevelopment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e7f9be0f0727990d0bd350e5a4a305cb686be3c", @"/Views/Trabajador/CrearTrabajador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b14e2369cd6e174b4c6cb3e52299742e49e860e", @"/Views/_ViewImports.cshtml")]
    public class Views_Trabajador_CrearTrabajador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""content-wrapper"">
    <h1>

        Administrar Trabajadores

    </h1>



    <h3>Ingresar Trabajador</h3>

    <div class=""box-body"">

        <h6 class=""display-6""></h6>


        <br />


        <div class=""col"">
            <label>INGRESE EL RUT</label>
            <input type=""text"" class=""form-control"" id=""rut_trabajador"" name=""rut_trabajador"">

        </div>

        <div class=""col"">
            <label>DV TRABAJADOR</label>
            <input type=""text"" class=""form-control"" id=""dv_trabajador"" name=""dv_trabajador"">

        </div>

        <div class=""col"">

            <label>NOMBRES</label>
            <input type=""text"" class=""form-control"" id=""nombres"" name=""nombres"">

        </div>

        <div class=""col"">
            <label>APELLIDO PATERNO</label>
            <input type=""text"" class=""form-control"" id=""ap_paterno"" name=""ap_paterno"">
        </div>
        <div class=""col"">
            <label>APELLIDO MATERNO</label>
            <input type=""text"" class=""form-control"" id=""ap_ma");
            WriteLiteral(@"terno"" name=""ap_materno"">
        </div>
        <div class=""col"">
            <label>INGRESE TELEFONO</label>
            <input type=""text"" class=""form-control"" id=""trabajador_telefono"" name=""trabajador_telefono"">
        </div>
        <div class=""col"">
            <label>INGRESE CORREO</label>
            <input type=""text"" class=""form-control"" id=""trabajador_correo"" name=""trabajador_correo"">
        </div>
        <div class=""col"">
            <label>INGRESE DIRECCION</label>
            <input type=""text"" class=""form-control"" id=""trabajador_direccion"" name=""trabajador_direccion"">
        </div>    
	<br>
        <br />
        <div class=""btn-group"">
            <div class=""col"">
                <button type=""button"" class=""btn btn-block bg-gradient-danger btn-sm"">Borrar</button>
            </div> &nbsp;&nbsp;&nbsp;&nbsp; <div class=""col""> <button type=""button"" class=""btn btn-block bg-gradient-success btn-sm"">Crear</button></div>


        </div>
    </div>
 ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
