#pragma checksum "C:\Users\frenh\Dropbox\VisualStudioApplications\CISC551\WineTaste\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26373d375d64a507c8df2f0ba2042afef3536a55"
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
#line 2 "C:\Users\frenh\Dropbox\VisualStudioApplications\CISC551\WineTaste\Views\Home\Index.cshtml"
using WineTaste.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26373d375d64a507c8df2f0ba2042afef3536a55", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WineTaste.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div>\r\n");
#nullable restore
#line 11 "C:\Users\frenh\Dropbox\VisualStudioApplications\CISC551\WineTaste\Views\Home\Index.cshtml"
     foreach (var category in Model.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>");
#nullable restore
#line 13 "C:\Users\frenh\Dropbox\VisualStudioApplications\CISC551\WineTaste\Views\Home\Index.cshtml"
       Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 14 "C:\Users\frenh\Dropbox\VisualStudioApplications\CISC551\WineTaste\Views\Home\Index.cshtml"
         foreach (var varietal in category.VarietalList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>");
#nullable restore
#line 16 "C:\Users\frenh\Dropbox\VisualStudioApplications\CISC551\WineTaste\Views\Home\Index.cshtml"
           Write(varietal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 17 "C:\Users\frenh\Dropbox\VisualStudioApplications\CISC551\WineTaste\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\frenh\Dropbox\VisualStudioApplications\CISC551\WineTaste\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WineTaste.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
