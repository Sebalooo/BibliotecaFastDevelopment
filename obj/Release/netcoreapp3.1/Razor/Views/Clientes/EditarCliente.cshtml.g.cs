#pragma checksum "/Users/milenmeza/Projects/BibliotecaFastDevelopment/BibliotecaFastDevelopment/Views/Clientes/EditarCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aa8d30eb32ec4455bbe505c3d2129ee76ab99e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_EditarCliente), @"mvc.1.0.razor-page", @"/Views/Clientes/EditarCliente.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aa8d30eb32ec4455bbe505c3d2129ee76ab99e9", @"/Views/Clientes/EditarCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b14e2369cd6e174b4c6cb3e52299742e49e860e", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_EditarCliente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""content-wrapper"">
    <section class=""content-header"">

        <h1>

            Administrar Clientes

        </h1>

        <br />


        <ol class=""breadcrumb"">


            <li class=""active"">Crear Cliente </li>

        </ol>

    </section>

    <br />

    <div class=""box-body"">

        <h6 class=""display-6""></h6>


        <br />


        <div class=""col"">
            <label>Ingrese el Rut</label>
            <input type=""text"" class=""form-control"" name=""isbn"" />

        </div>

        <div class=""col"">
            <label>Ingrese Nombres</label>
            <input type=""text"" class=""form-control"" name=""codigo_editorial"" placeholder=""ID"" value=""Auto""");
            BeginWriteAttribute("required", " required=\"", 698, "\"", 709, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\n        </div>\n\n        <div class=\"col\">\n\n            <label>Ingrese Apellido Paterno</label>\n            <input type=\"text\" class=\"form-control\" name=\"titulo\" placeholder=\"ID\" value=\"Auto\"");
            BeginWriteAttribute("required", " required=\"", 903, "\"", 914, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\n        </div>\n\n        <div class=\"col\">\n            <label>Ingresar Materno</label>\n            <input type=\"text\" class=\"form-control\" name=\"editorial\" placeholder=\"ID\" value=\"Auto\"");
            BeginWriteAttribute("required", " required=\"", 1102, "\"", 1113, 0);
            EndWriteAttribute();
            WriteLiteral(">\n        </div>\n        <div class=\"col\">\n            <label>Fecha de Nacimiento</label>\n            <input type=\"text\" class=\"form-control\" name=\"id\" placeholder=\"ID\" value=\"Auto\"");
            BeginWriteAttribute("required", " required=\"", 1295, "\"", 1306, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </div>

    </div>
    <br> <br />
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Clientes_EditarCliente> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Clientes_EditarCliente> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Clientes_EditarCliente>)PageContext?.ViewData;
        public Views_Clientes_EditarCliente Model => ViewData.Model;
    }
}
#pragma warning restore 1591
