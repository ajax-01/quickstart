#pragma checksum "D:\workspace\dotnet\quickstart\src\MvcClient\Views\Home\json.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51217cd7c65e1d2e4055a0e7ad72f2fea13d94cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_json), @"mvc.1.0.view", @"/Views/Home/json.cshtml")]
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
#line 1 "D:\workspace\dotnet\quickstart\src\MvcClient\Views\_ViewImports.cshtml"
using MvcClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\workspace\dotnet\quickstart\src\MvcClient\Views\_ViewImports.cshtml"
using MvcClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51217cd7c65e1d2e4055a0e7ad72f2fea13d94cf", @"/Views/Home/json.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8143d1835352feeef7cd3c50c0d2dc4c14dbed3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_json : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<pre>");
#nullable restore
#line 1 "D:\workspace\dotnet\quickstart\src\MvcClient\Views\Home\json.cshtml"
Write(ViewBag.Json);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>");
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