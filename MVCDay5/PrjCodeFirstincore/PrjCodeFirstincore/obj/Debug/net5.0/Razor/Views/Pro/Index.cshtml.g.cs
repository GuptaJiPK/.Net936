#pragma checksum "C:\OnlineTraining\LTI\July21\MVC\MVCDay5\PrjCodeFirstincore\PrjCodeFirstincore\Views\Pro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24a8e6cbba41a1a4b071602c8822f9f102058754"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pro_Index), @"mvc.1.0.view", @"/Views/Pro/Index.cshtml")]
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
#line 1 "C:\OnlineTraining\LTI\July21\MVC\MVCDay5\PrjCodeFirstincore\PrjCodeFirstincore\Views\_ViewImports.cshtml"
using PrjCodeFirstincore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OnlineTraining\LTI\July21\MVC\MVCDay5\PrjCodeFirstincore\PrjCodeFirstincore\Views\_ViewImports.cshtml"
using PrjCodeFirstincore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a8e6cbba41a1a4b071602c8822f9f102058754", @"/Views/Pro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"444bd217d1cdde443a195e43759d45c555d5c357", @"/Views/_ViewImports.cshtml")]
    public class Views_Pro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PrjCodeFirstincore.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\OnlineTraining\LTI\July21\MVC\MVCDay5\PrjCodeFirstincore\PrjCodeFirstincore\Views\Pro\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\OnlineTraining\LTI\July21\MVC\MVCDay5\PrjCodeFirstincore\PrjCodeFirstincore\Views\Pro\Index.cshtml"
 foreach(var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\OnlineTraining\LTI\July21\MVC\MVCDay5\PrjCodeFirstincore\PrjCodeFirstincore\Views\Pro\Index.cshtml"
Write(item.ProductName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\OnlineTraining\LTI\July21\MVC\MVCDay5\PrjCodeFirstincore\PrjCodeFirstincore\Views\Pro\Index.cshtml"
Write(item.ProductDescription);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\OnlineTraining\LTI\July21\MVC\MVCDay5\PrjCodeFirstincore\PrjCodeFirstincore\Views\Pro\Index.cshtml"
                            
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PrjCodeFirstincore.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
