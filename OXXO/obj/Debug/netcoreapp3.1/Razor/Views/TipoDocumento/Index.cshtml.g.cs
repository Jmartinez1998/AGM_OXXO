#pragma checksum "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fcdd8c33f2b02c8f66d9d09ae3590c21cf7b2d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoDocumento_Index), @"mvc.1.0.view", @"/Views/TipoDocumento/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fcdd8c33f2b02c8f66d9d09ae3590c21cf7b2d1", @"/Views/TipoDocumento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02cf9593350579a1d8a3a4d64042c9074a423a2a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TipoDocumento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OXXO.Models.TipoDocumento>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TipoDocumento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div id=\"PlaceHolderHere\"></div>\r\n    <style>\r\n\r\n        .input-validation-error {\r\n            border-color: red;\r\n        }\r\n    </style>\r\n");
#nullable restore
#line 11 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
     if (ViewBag.Alert != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"alerta\" class=\"container body-content\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
       Write(Html.Raw(@ViewBag.Alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <h1 id=""titulo"">Tipos de Documentos Permitidos</h1>
    <button class=""btn btn-primary"" type=""button"" data-bs-toggle=""offcanvas"" data-bs-target=""#offcanvasRight"" aria-controls=""offcanvasRight"" style=""width: 120px; border-radius: 0px; ""><i class=""bi bi-funnel""></i> Filtrar</button>
");
#nullable restore
#line 20 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
     if (ViewBag.Crear)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <button id=""CreateDoc"" class=""btn btn-primary"" type=""button"" data-bs-toggle=""offcanvas"" data-bs-target=""#offcanvasRightCrear"" aria-controls=""offcanvasRightCrear"" style=""border-radius: 0px; ""><i class=""bi bi-person-plus-fill""></i> Crear Nuevo Tipo de Documento</button>
");
#nullable restore
#line 23 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""accordion-bral"">
        <div>

            <div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""offcanvasRight"" aria-labelledby=""offcanvasRightLabel"">
                <div class=""offcanvas-header"">
                    <h5>Filtrar</h5>
                    <button type=""button"" class=""btn-close text-reset"" data-bs-dismiss=""offcanvas"" aria-label=""Close""></button>
                </div>
                <div class=""offcanvas-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fcdd8c33f2b02c8f66d9d09ae3590c21cf7b2d18019", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""mb-3"">
                                <label for=""exampleFormControlInput1"" class=""form-label"">Nombre de Documento</label>
                                <input type=""text"" name=""NombreDocumento"" class=""form-control form-control-sm"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""exampleFormControlInput1"" class=""form-label"">Descripcion del Documento</label>
                                <input type=""text"" name=""Descripcion"" class=""form-control form-control-sm"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""exampleFormControlInput1"" class=""form-label"">Tipo de Archivo</label>
                                <input type=""text"" name=""TipoArchivo"" class=""form-control form-control-sm"">
                            </div>
                            <div class=""");
                WriteLiteral(@"mb-3"">
                                <label for=""exampleFormControlInput1"" class=""form-label"">Estatus del Tipo de Documento</label>
                                <select id=""ddPerfiles"" name=""Activo"" class=""form-select"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fcdd8c33f2b02c8f66d9d09ae3590c21cf7b2d19648", async() => {
                    WriteLiteral("Selecciona una opción...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fcdd8c33f2b02c8f66d9d09ae3590c21cf7b2d110925", async() => {
                    WriteLiteral("Activo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fcdd8c33f2b02c8f66d9d09ae3590c21cf7b2d112185", async() => {
                    WriteLiteral("Inactivo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select> <span name=""Activo"" class=""text-danger""></span>
                            </div>
                        </div>
                        <div class=""row p-2"">
                            <input type=""submit"" value=""Buscar"" class=""btn btn-dark float-right"" />
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
    </div>

    <br />

    <table id=""tabletipos"" class=""table"" style=""width:100%"">
        <thead>
            <tr class=""text-center"">
                <th scope=""col"">Nombre</th>
                <th scope=""col"">Descripción</th>
                <th scope=""col"">Tipo de Archivo</th>
                <th scope=""col"">Estatus</th>
                <th scope=""col"">Persona Física</th>
                <th scope=""col"">Persona Moral</th>
                <th scope=""col"">¿Documento Obligatorio?</th>
                <th colspan=""1""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 81 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-center\">\r\n                <td style=\"display:none\">");
#nullable restore
#line 84 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.IdTipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
#nullable restore
#line 85 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NombreDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 86 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 87 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TipoArchivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 89 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                     if (@item.Activo == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Activo</span>\r\n");
#nullable restore
#line 92 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Inactivo</span>\r\n");
#nullable restore
#line 96 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 100 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                     if (@item.PersonaFisica == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Requerido</span>\r\n");
#nullable restore
#line 103 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>No Requerido</span>\r\n");
#nullable restore
#line 107 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 111 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                     if (@item.PersonaMoral == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Requerido</span>\r\n");
#nullable restore
#line 114 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>No Requerido</span>\r\n");
#nullable restore
#line 118 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 121 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                     if (@item.Obligatorio == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>SI</span>\r\n");
#nullable restore
#line 124 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>NO</span>\r\n");
#nullable restore
#line 128 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 131 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                     if (ViewBag.Editar)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button id=\"editDoc\" data-url=\"Editar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5875, "\"", 5913, 3);
            WriteAttributeValue("", 5885, "datos(", 5885, 6, true);
#nullable restore
#line 133 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
WriteAttributeValue("", 5891, item.IdTipoDocumento, 5891, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5912, ")", 5912, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""offcanvas"" data-bs-target=""#offcanvasRightEdit"" aria-controls=""offcanvasRightEdit"" title=""Editar Documento"" class=""btn btn-block popup btn-sm"" type=""button"" style=""border-radius: 0px;""><i class=""bi bi-person-lines-fill""></i> Editar</button>
");
#nullable restore
#line 134 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 137 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
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
                    <h5>Editar Tipo de Documento</h5>

                    <button type=""button"" class=""btn-close text-reset"" data-bs-dismiss=""offcanvas"" aria-label=""Close""></button>
                </div>
                <div id=""createBodyEdit"" class=""offcanvas-body"">

                </div>
            </div>
        </div>
    </div>



    <div class=""accordion-bral"">
        <div>
            <div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""offcanvasRightCrear"" aria-labelledby=""offcanvasRightLabel"">
                <div class=""offcanvas-header"">
                    <h5>Crear un nuevo tipo de documento</h5>

                    <button type=""button"" class=""btn-close text-reset"" data-bs-dismiss=""offcanvas"" aria-label=""Close"">");
            WriteLiteral(@"</button>
                </div>
                <div id=""createBodyCrear"" class=""offcanvas-body"">
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

    

    $('#tabletipos tbody').on('click', '#editDoc', function (event) {
        event.preventDefault();
        event.stopImmediatePropagation();

        $.ajax({
            url: '/TipoDocumento/Editar/',
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


    $('#");
            WriteLiteral(@"CreateDoc').click(function (event) {
        event.preventDefault();
        event.stopImmediatePropagation();
       
        $.ajax({
            url: '/TipoDocumento/Crear/',
            type: 'GET',
            success: function (data) {
                $('#offcanvasRightCrear').html(data);
                $('#createBodyCrear').modal('show');
            },
            error: function () {
                console.log(error);
                alert(""¡Hay un problema con el servicio, favor de reiniciar!"")
            }
        });
    });
    

</script>
");
#nullable restore
#line 224 "C:\Users\Integra\Desktop\DEV\OXXO\OXXO\Views\TipoDocumento\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OXXO.Models.TipoDocumento>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
