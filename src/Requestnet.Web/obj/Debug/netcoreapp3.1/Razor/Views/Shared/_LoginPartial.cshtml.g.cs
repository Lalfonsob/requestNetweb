#pragma checksum "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Shared/_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0f4cc3ef0859e62af73548f9360b31b9969c75e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
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
#nullable restore
#line 1 "/Users/miguelbaron/VisualStudio_NET/requestNetweb/src/Requestnet.Web/Views/Shared/_LoginPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f4cc3ef0859e62af73548f9360b31b9969c75e", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a71de84072cd5a19f20677ac8d804f0548d2d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--
<ul class=""navbar-nav"">
-if (SignInManager.IsSignedIn(User))
{
    <li class=""nav-item"">
        <a  class=""nav-link text-dark"" asp-area=""Identity"" asp-page=""/Account/Manage/Index"" title=""Manage"">Hello User.Identity.Name!</a>
    </li>
    <li class=""nav-item"">
        <form  class=""form-inline"" asp-area=""Identity"" asp-page=""/Account/Logout"" asp-route-returnUrl=""Url.Action(""Index"", ""Home"", new { area = """" })"">
            <button  type=""submit"" class=""nav-link btn btn-link text-dark"">Logout</button>
        </form>
    </li>
}
else
{
    <li class=""nav-item"">
        <a class=""nav-link text-dark"" asp-area=""Identity"" asp-page=""/Account/Register"">Register</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link text-dark"" asp-area=""Identity"" asp-page=""/Account/Login"">Login</a>
    </li>
}
</ul>
-->

<ul class=""nav navbar-nav navbar-right"">
    <li class=""dropdown"">
        <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""><img src=""/images/userWomen4.jpg"" class=""img-circle"" alt=""Avatar"" ");
            WriteLiteral("/><span>Leidy Alfonso</span> <i class=\"icon-submenu lnr lnr-chevron-down\"></i></a>\n    </li>\n</ul>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
