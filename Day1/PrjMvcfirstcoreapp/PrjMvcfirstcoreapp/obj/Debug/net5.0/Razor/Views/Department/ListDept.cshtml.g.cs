#pragma checksum "C:\OnlineTraining\LTI\July21\MVC\Day1\PrjMvcfirstcoreapp\PrjMvcfirstcoreapp\Views\Department\ListDept.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ebc9916c35b5c4f555ac168c9b692d285876b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_ListDept), @"mvc.1.0.view", @"/Views/Department/ListDept.cshtml")]
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
#line 1 "C:\OnlineTraining\LTI\July21\MVC\Day1\PrjMvcfirstcoreapp\PrjMvcfirstcoreapp\Views\_ViewImports.cshtml"
using PrjMvcfirstcoreapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OnlineTraining\LTI\July21\MVC\Day1\PrjMvcfirstcoreapp\PrjMvcfirstcoreapp\Views\_ViewImports.cshtml"
using PrjMvcfirstcoreapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebc9916c35b5c4f555ac168c9b692d285876b9e", @"/Views/Department/ListDept.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"108876fc7416bbeca669d57ba0f06b91a2c1130d", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_ListDept : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PrjMvcfirstcoreapp.Models.Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\OnlineTraining\LTI\July21\MVC\Day1\PrjMvcfirstcoreapp\PrjMvcfirstcoreapp\Views\Department\ListDept.cshtml"
  
    ViewData["Title"] = "ListDept";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ListDept</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\OnlineTraining\LTI\July21\MVC\Day1\PrjMvcfirstcoreapp\PrjMvcfirstcoreapp\Views\Department\ListDept.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 10 "C:\OnlineTraining\LTI\July21\MVC\Day1\PrjMvcfirstcoreapp\PrjMvcfirstcoreapp\Views\Department\ListDept.cshtml"
   Write(item.did);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 11 "C:\OnlineTraining\LTI\July21\MVC\Day1\PrjMvcfirstcoreapp\PrjMvcfirstcoreapp\Views\Department\ListDept.cshtml"
   Write(item.dname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 12 "C:\OnlineTraining\LTI\July21\MVC\Day1\PrjMvcfirstcoreapp\PrjMvcfirstcoreapp\Views\Department\ListDept.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>Department Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "C:\OnlineTraining\LTI\July21\MVC\Day1\PrjMvcfirstcoreapp\PrjMvcfirstcoreapp\Views\Department\ListDept.cshtml"
         foreach(var i in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\OnlineTraining\LTI\July21\MVC\Day1\PrjMvcfirstcoreapp\PrjMvcfirstcoreapp\Views\Department\ListDept.cshtml"
               Write(i.did);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\OnlineTraining\LTI\July21\MVC\Day1\PrjMvcfirstcoreapp\PrjMvcfirstcoreapp\Views\Department\ListDept.cshtml"
               Write(i.dname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\OnlineTraining\LTI\July21\MVC\Day1\PrjMvcfirstcoreapp\PrjMvcfirstcoreapp\Views\Department\ListDept.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PrjMvcfirstcoreapp.Models.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591