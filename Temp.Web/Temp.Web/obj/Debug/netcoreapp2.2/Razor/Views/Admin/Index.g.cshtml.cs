#pragma checksum "/home/local/3SI/tri.nv/Documents/intern-2019-03-049/Temp.Web/Temp.Web/Views/Admin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f03ada927fc5951796133267306a2cc00e6896df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 1 "/home/local/3SI/tri.nv/Documents/intern-2019-03-049/Temp.Web/Temp.Web/Views/_ViewImports.cshtml"
using Temp.Web;

#line default
#line hidden
#line 2 "/home/local/3SI/tri.nv/Documents/intern-2019-03-049/Temp.Web/Temp.Web/Views/_ViewImports.cshtml"
using Temp.Web.Models;

#line default
#line hidden
#line 4 "/home/local/3SI/tri.nv/Documents/intern-2019-03-049/Temp.Web/Temp.Web/Views/_ViewImports.cshtml"
using Temp.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f03ada927fc5951796133267306a2cc00e6896df", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced53840927957e783b72566e4fd1411de7d804f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Temp.Service.DTO.LogInDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/local/3SI/tri.nv/Documents/intern-2019-03-049/Temp.Web/Temp.Web/Views/Admin/Index.cshtml"
  
    ViewBag.Title = "Admin";
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(97, 193, true);
            WriteLiteral("<div class=\"content-header\">\n<div class=\"container-fluid\">\n    <div class=\"row mb-2\">\n        <div class=\"col-sm-6\">\n\n            <h2>Wellcome!</h2>\n           </div> \n    </div>\n</div>\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Temp.Service.DTO.LogInDto> Html { get; private set; }
    }
}
#pragma warning restore 1591