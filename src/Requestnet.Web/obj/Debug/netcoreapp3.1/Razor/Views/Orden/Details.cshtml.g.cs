#pragma checksum "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04e0a1f5aedb2b4b7f909c8c4e6361dc57279ffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orden_Details), @"mvc.1.0.view", @"/Views/Orden/Details.cshtml")]
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
#line 1 "D:\request\requestNetweb\src\Requestnet.Web\Views\_ViewImports.cshtml"
using Requestnet.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\request\requestNetweb\src\Requestnet.Web\Views\_ViewImports.cshtml"
using Requestnet.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04e0a1f5aedb2b4b7f909c8c4e6361dc57279ffa", @"/Views/Orden/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a234c099b1587194e2f597986de8cc9fa7ddb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Orden_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Requestnet.Core.Domain.Orden>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btnVolver"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btnEditarContent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"sidebar-nav\" class=\"sidebar\">\r\n    <div class=\"sidebar-scroll\">\r\n        <nav>\r\n            <ul class=\"nav\">\r\n                <li>");
#nullable restore
#line 11 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
               Write(Html.ActionLink("Inventario", "Index", "Inventario"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>");
#nullable restore
#line 12 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
               Write(Html.ActionLink("Novedades", "Index", "Caso"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>");
#nullable restore
#line 13 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
               Write(Html.ActionLink("Proveedores", "Index", "Orden", new object { }, new { @class = "active" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>");
#nullable restore
#line 14 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
               Write(Html.ActionLink("Usuarios", "Index", "Usuario"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ul>

        </nav>
    </div>
</div>

<div class=""main"">
    <div class=""main-content"">

        <div class=""container-fluid"">

            <h3 class=""panel-title"">Detalle orden</h3>

            <div class=""mb-4"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04e0a1f5aedb2b4b7f909c8c4e6361dc57279ffa6192", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <hr />\r\n\r\n            <div>\r\n                <dl class=\"row\">\r\n                    <dt class=\"col-sm-2\">Descripción</dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 37 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">Adjuntar Archivo</dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 41 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
                   Write(Html.DisplayFor(model => model.AdjuntarArchivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">Fecha de aprobación</dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 45 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
                   Write(Html.DisplayFor(model => model.FechaAprobacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">Solución</dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 49 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Solucion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">Fecha de solución\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 54 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
                   Write(Html.DisplayFor(model => model.FechaSolucion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">Notas</dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 58 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Notas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">Estado de la orden</dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 62 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdEstadoNavigation.IdEstado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">Jefe</dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 66 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdJefeNavigation.IdJefe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">Lider</dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 70 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdLiderNavigation.IdLider));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">Proveedor</dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 74 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdProveedorNavigation.IdProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">Tipo de orden</dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 78 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdTipoOrdenNavigation.IdTipoOrden));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04e0a1f5aedb2b4b7f909c8c4e6361dc57279ffa12393", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "D:\request\requestNetweb\src\Requestnet.Web\Views\Orden\Details.cshtml"
                                                                WriteLiteral(Model.IdOrden);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Requestnet.Core.Domain.Orden> Html { get; private set; }
    }
}
#pragma warning restore 1591
