#pragma checksum "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f101e8489514378c270107478945c0793f0117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caso_Details), @"mvc.1.0.view", @"/Views/Caso/Details.cshtml")]
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
#line 1 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/_ViewImports.cshtml"
using Requestnet.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/_ViewImports.cshtml"
using Requestnet.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f101e8489514378c270107478945c0793f0117", @"/Views/Caso/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a71de84072cd5a19f20677ac8d804f0548d2d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Caso_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Requestnet.Core.Domain.Casos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Casos</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Solucion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayFor(model => model.Solucion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 32 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaSol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 35 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaSol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 38 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Notas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 41 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayFor(model => model.Notas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 44 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdClienteNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 47 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayFor(model => model.IdClienteNavigation.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 50 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 53 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayFor(model => model.IdEstadoNavigation.IdEstado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 56 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdJefeNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 59 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayFor(model => model.IdJefeNavigation.IdJefe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 62 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdLiderNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 65 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayFor(model => model.IdLiderNavigation.IdLider));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 68 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdTecnicoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 71 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayFor(model => model.IdTecnicoNavigation.IdTecnico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 74 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdTipoCasoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 77 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
       Write(Html.DisplayFor(model => model.IdTipoCasoNavigation.IdTipoCaso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3f101e8489514378c270107478945c0793f011711317", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Caso/Details.cshtml"
                           WriteLiteral(Model.IdCaso);

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
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3f101e8489514378c270107478945c0793f011713446", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Requestnet.Core.Domain.Casos> Html { get; private set; }
    }
}
#pragma warning restore 1591
