#pragma checksum "C:\DevBuild\Week09\Lab9_2_MVC\Views\MySite\ThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "445405cfc75e49ce6953e7d0901fdc126b247868"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MySite_ThankYou), @"mvc.1.0.view", @"/Views/MySite/ThankYou.cshtml")]
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
#line 1 "C:\DevBuild\Week09\Lab9_2_MVC\Views\_ViewImports.cshtml"
using Lab9_2_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DevBuild\Week09\Lab9_2_MVC\Views\_ViewImports.cshtml"
using Lab9_2_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"445405cfc75e49ce6953e7d0901fdc126b247868", @"/Views/MySite/ThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc77e1aa1e2a5fb9de6627036fb1610168c46610", @"/Views/_ViewImports.cshtml")]
    public class Views_MySite_ThankYou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\DevBuild\Week09\Lab9_2_MVC\Views\MySite\ThankYou.cshtml"
  
    ViewData["Title"] = "ThankYou";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Thank You</h1>\r\n\r\n<div>");
#nullable restore
#line 8 "C:\DevBuild\Week09\Lab9_2_MVC\Views\MySite\ThankYou.cshtml"
Write(ViewData["FirstName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\DevBuild\Week09\Lab9_2_MVC\Views\MySite\ThankYou.cshtml"
                       Write(ViewData["LastName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(", you are registered with the following email address: ");
#nullable restore
#line 8 "C:\DevBuild\Week09\Lab9_2_MVC\Views\MySite\ThankYou.cshtml"
                                                                                                   Write(ViewData["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
