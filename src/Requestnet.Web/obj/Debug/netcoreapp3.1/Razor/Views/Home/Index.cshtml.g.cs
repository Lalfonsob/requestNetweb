#pragma checksum "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60324d4c8ffb0fd8f3f4b2ce71bf0b7ed96e23a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60324d4c8ffb0fd8f3f4b2ce71bf0b7ed96e23a4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a71de84072cd5a19f20677ac8d804f0548d2d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div id=\"sidebar-nav\" class=\"sidebar\">\n    <div class=\"sidebar-scroll\">\n        <nav>\n            <ul class=\"nav\">\n                <li>");
#nullable restore
#line 9 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Home/Index.cshtml"
               Write(Html.ActionLink("Inventario", "Index", "Inventario"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>");
#nullable restore
#line 10 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Home/Index.cshtml"
               Write(Html.ActionLink("Novedades", "Index", "Caso"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>");
#nullable restore
#line 11 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Home/Index.cshtml"
               Write(Html.ActionLink("Proveedores", "Index", "Orden"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li>");
#nullable restore
#line 12 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Home/Index.cshtml"
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
            <div class=""formsRequestNet"">
                <div class=""titleForm"">
                    <h2>Bienvenidos a</h2>
                    <img src=""/images/logoWhiteRN.png"">
                </div>
            </div>
        </div>
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
