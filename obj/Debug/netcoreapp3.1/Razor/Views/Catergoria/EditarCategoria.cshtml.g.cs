#pragma checksum "C:\Users\Equipos Médicos\Downloads\BibliotecaFastDevelopment (2)\BibliotecaFastDevelopment\BibliotecaFastDevelopment\Views\Catergoria\EditarCategoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb4267b0b2154f247c4d521d677b0e46cc363515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catergoria_EditarCategoria), @"mvc.1.0.view", @"/Views/Catergoria/EditarCategoria.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb4267b0b2154f247c4d521d677b0e46cc363515", @"/Views/Catergoria/EditarCategoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b14e2369cd6e174b4c6cb3e52299742e49e860e", @"/Views/_ViewImports.cshtml")]
    public class Views_Catergoria_EditarCategoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""content-wrapper"">

    <h1>

        Administrar Categoria

    </h1>



    <h3>Editar Nueva Categoria</h3>



    <div class=""col"">
        <label>CÓDIGO CATEGORIA </label>
        <input type=""text"" class=""form-control"" id=""cod_categoria"" name=""cod_categoria"">

    </div>

    <div class=""col"">
        <label>INGRESE NOMBRE CATEGORIA</label>
        <input type=""text"" class=""form-control"" id=""categoria"" name=""categoria"">

    </div>

    <div class=""col"">
        <label>ISBN</label>
        <input type=""text"" class=""form-control"" id=""ISBN"" name=""ISBN"">
    </div>
    <br />
    <div class=""btn-group"">
        <div class=""col"">
            <button type=""button"" class=""btn btn-block bg-gradient-danger btn-sm"">Borrar</button>
        </div> &nbsp;&nbsp;&nbsp;&nbsp; <div class=""col""> <button type=""submit"" class=""btn btn-block bg-gradient-success btn-sm"">Crear</button></div>
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
