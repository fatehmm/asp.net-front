#pragma checksum "/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Views/Admin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daba5c68b659a0cb2bca82d2b37def087937fa56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Views/_ViewImports.cshtml"
using aspFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Views/_ViewImports.cshtml"
using aspFront.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daba5c68b659a0cb2bca82d2b37def087937fa56", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28c975b3bb595e37ee66acb041d5542562262168", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Views/Admin/Index.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"product-table table table-striped p-6 w-75 ma-auto\">\n    <thead>\n        <tr>\n            <th>Count</th>\n            <th>Name</th>\n            <th>New Price</th>\n            <th>Image</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 17 "/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Views/Admin/Index.cshtml"
          int count = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Views/Admin/Index.cshtml"
         foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 21 "/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Views/Admin/Index.cshtml"
                      ++count;

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 22 "/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Views/Admin/Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Views/Admin/Index.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><img");
            BeginWriteAttribute("src", " src =\"", 548, "\"", 567, 1);
#nullable restore
#line 24 "/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Views/Admin/Index.cshtml"
WriteAttributeValue("", 555, item.ImgURL, 555, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\"/></td>\n            </tr>\n");
#nullable restore
#line 26 "/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Views/Admin/Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n<style>\n    .product-table{\n        border: 1px solid gainsboro;\n        margin: 20px auto;\n        border-radius: 10px;\n    }\n</style>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
