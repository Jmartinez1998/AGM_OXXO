#pragma checksum "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "937b792b876145b14f9b71af0550f3933e5e9559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
#line 1 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\_ViewImports.cshtml"
using OXXO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\_ViewImports.cshtml"
using OXXO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"937b792b876145b14f9b71af0550f3933e5e9559", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7fd0f624010dea055f2bcf6294458a76d9a61e", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OXXO.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validateForm()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"container\">\n    <div id=\"PlaceHolderHere\"></div>\n    <style>\n\n        .input-validation-error {\n            border-color: red;\n        }\n    </style>\n");
#nullable restore
#line 10 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
     if (ViewBag.Alert != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"alerta\" class=\"container body-content\">\n            ");
#nullable restore
#line 13 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
       Write(Html.Raw(@ViewBag.Alert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 15 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <h1 id=""titulo"">Usuarios</h1>
    <button class=""btn btn-primary"" type=""button"" data-bs-toggle=""offcanvas"" data-bs-target=""#offcanvasRight"" aria-controls=""offcanvasRight"" style=""width: 120px; border-radius: 0px; ""><i class=""bi bi-funnel""></i> Filtrar</button>
");
#nullable restore
#line 19 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
     if (ViewBag.Crear)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <button id=""CreateUser"" class=""btn btn-primary"" type=""button"" data-bs-toggle=""offcanvas"" data-bs-target=""#offcanvasRightCrear"" aria-controls=""offcanvasRightCrear"" style=""border-radius: 0px; ""><i class=""bi bi-person-plus-fill""></i> Crear nuevo usuario</button>
");
#nullable restore
#line 23 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "937b792b876145b14f9b71af0550f3933e5e95597277", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""mb-3"">
                                <label for=""exampleFormControlInput1"" class=""form-label"">Nombre</label>
                                <input type=""text"" name=""Nombre"" class=""form-control form-control-sm"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""exampleFormControlInput1"" class=""form-label"">Nombre de Usuario</label>
                                <input type=""text"" name=""UserName"" class=""form-control form-control-sm"">
                            </div>
                        </div>
                        <div class=""row p-2"">
                            <input type=""submit"" value=""Buscar"" class=""btn btn-dark float-right"" />
                        </div>
                        <script>
                            function validateForm() {
                                var x = document.forms[""myForm""][""Nombre""].value;
             ");
                WriteLiteral(@"                   var y = document.forms[""myForm""][""UserName""].value;
                                if (x == """" && y == """") {
                                    Swal.fire({ icon: 'info', title: '¡Atención!', text: 'Debes seleccionar al menos un valor para buscar.' })
                                    return false;
                                }
                            }
                        </script>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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

    <table id=""tableusers"" class=""table"">
        <thead>
            <tr class=""text-center"">
                <th scope=""col"">Nombre</th>
                <th scope=""col"">Apellido</th>
                <th scope=""col"">Nombre de Usuario</th>
                <th scope=""col"">Correo</th>
                <th scope=""col"">Puesto</th>
                <th scope=""col"">Estatus</th>
                <th scope=""col"">Vigencia</th>
                <th colspan=""2""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 79 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\n                    <td style=\"display:none\">");
#nullable restore
#line 82 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.IdUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td scope=\"row\">");
#nullable restore
#line 83 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 84 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 85 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 86 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 87 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Puesto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 88 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                     if (item.Activo == false)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Inactivo</td>\n");
#nullable restore
#line 91 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Activo</td>\n");
#nullable restore
#line 95 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"width:10%\">");
#nullable restore
#line 96 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Vigencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n");
#nullable restore
#line 98 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                         if (ViewBag.Editar)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button id=\"editUser\" data-url=\"Editar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4632, "\"", 4664, 3);
            WriteAttributeValue("", 4642, "datos(", 4642, 6, true);
#nullable restore
#line 100 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 4648, item.IdUsuario, 4648, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4663, ")", 4663, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""offcanvas"" data-bs-target=""#offcanvasRightEdit"" aria-controls=""offcanvasRightEdit"" title=""Editar Usuario"" class=""btn btn-block popup btn-sm"" type=""button"" style=""border-radius: 0px;""><i class=""bi bi-person-lines-fill""></i> Editar</button>
");
#nullable restore
#line 101 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                    <td>\n");
#nullable restore
#line 104 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                         if (ViewBag.CambiarContrasena || ViewBag.User == item.IdUsuario)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button id=\"editPassword\" data-url=\"CambiarContrasena\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5196, "\"", 5228, 3);
            WriteAttributeValue("", 5206, "datos(", 5206, 6, true);
#nullable restore
#line 106 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 5212, item.IdUsuario, 5212, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5227, ")", 5227, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""offcanvas"" data-bs-target=""#offcanvasRightContrasena"" aria-controls=""offcanvasRightContrasena"" title=""Cambiar contraseña"" class=""btn btn-block popup btn-sm"" type=""button"" style=""border-radius: 0px;""><i class=""bi bi-shield-lock""></i> Cambiar Contrasena</button>
");
#nullable restore
#line 107 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                </tr>\n");
#nullable restore
#line 110 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>


    <div class=""accordion-bral"">
        <div>

            <div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""offcanvasRightContrasena"" aria-labelledby=""offcanvasRightLabel"">
                <div class=""offcanvas-header"">
                    <h5>Cambiar Contraseña</h5>

                    <button type=""button"" class=""btn-close text-reset"" data-bs-dismiss=""offcanvas"" aria-label=""Close""></button>
                </div>
                <div id=""createBody"" class=""offcanvas-body"">

                </div>
            </div>
        </div>
    </div>

    <div class=""accordion-bral"">
        <div>
            <div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""offcanvasRightEdit"" aria-labelledby=""offcanvasRightLabel"">
                <div class=""offcanvas-header"">
                    <h5>Editar Usuario</h5>

                    <button type=""button"" class=""btn-close text-reset"" data-bs-dismiss=""offcanvas"" aria-label=""Close""></button>
                </div>
                <d");
            WriteLiteral(@"iv id=""createBodyEdit"" class=""offcanvas-body"">

                </div>
            </div>
        </div>
    </div>



    <div class=""accordion-bral"">
        <div>

            <div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""offcanvasRightCrear"" aria-labelledby=""offcanvasRightLabel"">
                <div class=""offcanvas-header"">
                    <h5>Crear un nuevo Usuario</h5>

                    <button type=""button"" class=""btn-close text-reset"" data-bs-dismiss=""offcanvas"" aria-label=""Close""></button>
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


    $('#tableusers tbody').on('click', '#editPassword', function (event) {
        event.preventDefault();
 ");
            WriteLiteral(@"       event.stopImmediatePropagation();

        $.ajax({
            url: '/Usuarios/CambiarContrasena/',
            type: 'GET',
            data: { Id: idt },
            success: function (result) {
                $('#offcanvasRightContrasena').html(result);
                $('#createBody').modal('show');
                   
            },
            error: function () {
                alert(""¡Hay un problema con el servicio, favor de reiniciar!"")
            }
        });

    });

    $('#tableusers tbody').on('click', '#editUser', function (event) {
        event.preventDefault();
        event.stopImmediatePropagation();

        $.ajax({
            url: '/Usuarios/Editar/',
            type: 'GET',
            data: { Id: idt },
            success: function (res) {
                $('#offcanvasRightEdit').html(res);
                $('#createBodyEdit').modal('show');
            },
            error: function () {
                alert(""¡Hay un problema con el servicio, favor de reiniciar!"")
 ");
            WriteLiteral(@"           }
        });

    });
        

    $('#CreateUser').click(function (event) {
        event.preventDefault();
        event.stopImmediatePropagation();

        $.ajax({
            url: '/Usuarios/Crear/',
            type: 'GET',
            success: function (res) {
                $('#offcanvasRightCrear').html(res);
                $('#createBodyCrear').modal('show');
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
#line 233 "C:\Users\Integracorp\Desktop\OXXO-main\OXXO\OXXO\Views\Usuarios\Index.cshtml"
  await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OXXO.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
