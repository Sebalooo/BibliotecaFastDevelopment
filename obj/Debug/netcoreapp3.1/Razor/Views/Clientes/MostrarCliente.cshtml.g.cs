#pragma checksum "C:\Users\Equipos Médicos\Downloads\BibliotecaFastDevelopment (2)\BibliotecaFastDevelopment\BibliotecaFastDevelopment\Views\Clientes\MostrarCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c44dad2d188d38fff697d7815e642ba1a4b0a868"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_MostrarCliente), @"mvc.1.0.view", @"/Views/Clientes/MostrarCliente.cshtml")]
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
#line 1 "C:\Users\Equipos Médicos\Downloads\BibliotecaFastDevelopment (2)\BibliotecaFastDevelopment\BibliotecaFastDevelopment\Views\_ViewImports.cshtml"
using BibliotecaFastDevelopment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Equipos Médicos\Downloads\BibliotecaFastDevelopment (2)\BibliotecaFastDevelopment\BibliotecaFastDevelopment\Views\_ViewImports.cshtml"
using BibliotecaFastDevelopment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c44dad2d188d38fff697d7815e642ba1a4b0a868", @"/Views/Clientes/MostrarCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b14e2369cd6e174b4c6cb3e52299742e49e860e", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_MostrarCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Clientes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral(@"

<h3>Listado de Libros </h3>
<table class=""table table-bordered"">

    <thead>
        <tr>
            <th>Nombres</th>
            <th>Apelliedo Paterno</th>
            <th>Apellido Materno</th>
            <th>Fecha de Nacimiento</th>
            <th>Rut</th>
        </tr>
    </thead>
    <tbody>



");
#nullable restore
#line 22 "C:\Users\Equipos Médicos\Downloads\BibliotecaFastDevelopment (2)\BibliotecaFastDevelopment\BibliotecaFastDevelopment\Views\Clientes\MostrarCliente.cshtml"
         foreach (var Clientes in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <th>");
#nullable restore
#line 25 "C:\Users\Equipos Médicos\Downloads\BibliotecaFastDevelopment (2)\BibliotecaFastDevelopment\BibliotecaFastDevelopment\Views\Clientes\MostrarCliente.cshtml"
   Write(Clientes.nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n    <th>");
#nullable restore
#line 26 "C:\Users\Equipos Médicos\Downloads\BibliotecaFastDevelopment (2)\BibliotecaFastDevelopment\BibliotecaFastDevelopment\Views\Clientes\MostrarCliente.cshtml"
   Write(Clientes.ap_paterno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n    <th>");
#nullable restore
#line 27 "C:\Users\Equipos Médicos\Downloads\BibliotecaFastDevelopment (2)\BibliotecaFastDevelopment\BibliotecaFastDevelopment\Views\Clientes\MostrarCliente.cshtml"
   Write(Clientes.ap_materno);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\n    <th>");
#nullable restore
#line 28 "C:\Users\Equipos Médicos\Downloads\BibliotecaFastDevelopment (2)\BibliotecaFastDevelopment\BibliotecaFastDevelopment\Views\Clientes\MostrarCliente.cshtml"
   Write(Clientes.fecha_nac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n    <th>");
#nullable restore
#line 29 "C:\Users\Equipos Médicos\Downloads\BibliotecaFastDevelopment (2)\BibliotecaFastDevelopment\BibliotecaFastDevelopment\Views\Clientes\MostrarCliente.cshtml"
   Write(Clientes.rut_cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n</tr>            ");
#nullable restore
#line 30 "C:\Users\Equipos Médicos\Downloads\BibliotecaFastDevelopment (2)\BibliotecaFastDevelopment\BibliotecaFastDevelopment\Views\Clientes\MostrarCliente.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("        }\n\n    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Clientes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
