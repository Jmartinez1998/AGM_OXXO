#pragma checksum "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29eb39c63b6b5a0d321cb020bc58c342b6befe76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mantenimiento_Index), @"mvc.1.0.view", @"/Views/Mantenimiento/Index.cshtml")]
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
#line 1 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\_ViewImports.cshtml"
using OXXO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\_ViewImports.cshtml"
using OXXO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29eb39c63b6b5a0d321cb020bc58c342b6befe76", @"/Views/Mantenimiento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02cf9593350579a1d8a3a4d64042c9074a423a2a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Mantenimiento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OXXO.Models.Mantenimiento>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Mantenimiento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-group mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div id=\"PlaceHolderHere\"></div>\r\n    <style>\r\n\r\n        .input-validation-error {\r\n            border-color: red;\r\n        }\r\n    </style>\r\n");
#nullable restore
#line 11 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
     if (ViewBag.Alert != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"alerta\" class=\"container body-content\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
       Write(Html.Raw(@ViewBag.Alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1 id=\"titulo\">Mantenimiento</h1>\r\n    <div class=\"row\">\r\n\r\n        <h6>Id Emisor: </h6>\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29eb39c63b6b5a0d321cb020bc58c342b6befe765661", async() => {
                WriteLiteral(@"
                    <input id=""IdEmisor"" type=""text"" class=""form-control"" placeholder=""Buscar por ID Emisor"" aria-label=""Buscar por ID Emisor"" name=""IdEmisor"" />
                    <button class=""btn btn-outline-secondary"" type=""submit""><i class=""bi bi-search"" ></i></button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <br />

    <table id=""tableman"" class=""table"">
        <thead>
            <tr class=""text-center"">
                <th scope=""col"">ID Emisor</th>
                <th scope=""col"">Nombre Comercial</th>
                <th>RFC</th>
                <th scope=""col"">Giro Comercial</th>
                <th scope=""col"">Razón Social</th>
                <th scope=""col"">Banco</th>
                <th scope=""col"">Cuenta</th>
                <th scope=""col"">Estatus</th>
                <th colspan=""1""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 48 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-center\">\r\n                <td style=\"display:none\">");
#nullable restore
#line 51 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.IdComercio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
#nullable restore
#line 52 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IdEmisor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NombreComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RFC));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Giro));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RazonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Banco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 58 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cuenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 60 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
                     if (@item.Activo == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Activo</span>\r\n");
#nullable restore
#line 63 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Inactivo</span>\r\n");
#nullable restore
#line 67 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 71 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
                     if (ViewBag.Editar)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button id=\"editman\" data-url=\"Editar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2720, "\"", 2753, 3);
            WriteAttributeValue("", 2730, "datos(", 2730, 6, true);
#nullable restore
#line 73 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
WriteAttributeValue("", 2736, item.IdComercio, 2736, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2752, ")", 2752, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""offcanvas"" data-bs-target=""#offcanvasRightEdit"" aria-controls=""offcanvasRightEdit"" title=""Editar Documento"" class=""btn btn-block popup btn-sm"" type=""button"" style=""border-radius: 0px;""><i class=""bi bi-person-lines-fill""></i> Editar</button>
");
#nullable restore
#line 74 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 77 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>


    <div class=""accordion-bral"">
        <div>
            <div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""offcanvasRightEdit"" aria-labelledby=""offcanvasRightLabel"">
                <div class=""offcanvas-header"">
                    <h5>Categorizar Información</h5>

                    <button type=""button"" class=""btn-close text-reset"" data-bs-dismiss=""offcanvas"" aria-label=""Close""></button>
                </div>
                <div id=""createBodyEdit"" class=""offcanvas-body"">

                </div>
            </div>
        </div>
    </div>
</div>
<script src=""https://code.jquery.com/jquery-3.6.0.min.js"" integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
<script>

    let idt;
    function datos(id) {
        idt = id;
    }
   

    $('#tableman tbody').on('click', '#editman', function (event) {
        event.preventDefault();
        event.stopImmediatePropagation();

        $.ajax({
");
            WriteLiteral(@"            url: '/Mantenimiento/Editar/',
            type: 'GET',
            data: { Id: idt },
            success: function (res) {
                $('#offcanvasRightEdit').html(res);
                $('#createBodyEdit').modal('show');
            },
            error: function () {
                alert(""¡Hay un problema con el servicio, favor de reiniciar!"")
            }
        });

    });
    $(document).ready(function () {

    });

</script>
");
#nullable restore
#line 129 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\Mantenimiento\Index.cshtml"
  await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OXXO.Models.Mantenimiento>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
