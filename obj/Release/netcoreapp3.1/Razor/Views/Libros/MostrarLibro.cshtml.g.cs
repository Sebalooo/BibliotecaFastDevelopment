#pragma checksum "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Libros/MostrarLibro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c569edfbc5d3ffe0759b052e7142ae88989f0f1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Libros_MostrarLibro), @"mvc.1.0.view", @"/Views/Libros/MostrarLibro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c569edfbc5d3ffe0759b052e7142ae88989f0f1c", @"/Views/Libros/MostrarLibro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b14e2369cd6e174b4c6cb3e52299742e49e860e", @"/Views/_ViewImports.cshtml")]
    public class Views_Libros_MostrarLibro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Libros>>
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
            <th>ISBN</th>
            <th>Editorial</th>
            <th>Titulo</th>
            <th>Numero de Paginas</th>
            <th>Año de Edicion </th>
            <th>Cantidad de Libros</th>
            <th>Editorial Nombre</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 22 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Libros/MostrarLibro.cshtml"
         if (ViewBag.ListadoLibros != null) {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Libros/MostrarLibro.cshtml"
         foreach (var libros in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <th>");
#nullable restore
#line 27 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Libros/MostrarLibro.cshtml"
           Write(libros.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 28 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Libros/MostrarLibro.cshtml"
           Write(libros.EditorialID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 29 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Libros/MostrarLibro.cshtml"
           Write(libros.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 30 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Libros/MostrarLibro.cshtml"
           Write(libros.Nro_paginas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 31 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Libros/MostrarLibro.cshtml"
           Write(libros.A_edicion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 32 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Libros/MostrarLibro.cshtml"
           Write(libros.Cantidad_libros);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 33 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Libros/MostrarLibro.cshtml"
           Write(libros.EditorialName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>>\n        </tr>\n");
#nullable restore
#line 35 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Libros/MostrarLibro.cshtml"


            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Libros/MostrarLibro.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Libros>> Html { get; private set; }
    }
}
#pragma warning restore 1591