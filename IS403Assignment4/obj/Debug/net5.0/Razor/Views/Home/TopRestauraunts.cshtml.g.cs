#pragma checksum "/Users/graysonfattaleh/Projects/IS403Assignment4/IS403Assignment4/Views/Home/TopRestauraunts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f574781eb32b70dd88ba947589bb8b31a6160714"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TopRestauraunts), @"mvc.1.0.view", @"/Views/Home/TopRestauraunts.cshtml")]
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
#line 1 "/Users/graysonfattaleh/Projects/IS403Assignment4/IS403Assignment4/Views/_ViewImports.cshtml"
using IS403Assignment4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/graysonfattaleh/Projects/IS403Assignment4/IS403Assignment4/Views/_ViewImports.cshtml"
using IS403Assignment4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f574781eb32b70dd88ba947589bb8b31a6160714", @"/Views/Home/TopRestauraunts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b2d9e0f2ca210508569a0ea4234f3c10920c15", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TopRestauraunts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "/Users/graysonfattaleh/Projects/IS403Assignment4/IS403Assignment4/Views/Home/TopRestauraunts.cshtml"
  
    ViewData["HeaderTitle"] = "Top Restauraunts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<ul style=\"width:50vw; margin-left:auto; margin-right:auto;\">\n");
#nullable restore
#line 12 "/Users/graysonfattaleh/Projects/IS403Assignment4/IS403Assignment4/Views/Home/TopRestauraunts.cshtml"
     foreach (string s in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\n            ");
#nullable restore
#line 15 "/Users/graysonfattaleh/Projects/IS403Assignment4/IS403Assignment4/Views/Home/TopRestauraunts.cshtml"
       Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </li>\n        <hr />\n");
#nullable restore
#line 18 "/Users/graysonfattaleh/Projects/IS403Assignment4/IS403Assignment4/Views/Home/TopRestauraunts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
