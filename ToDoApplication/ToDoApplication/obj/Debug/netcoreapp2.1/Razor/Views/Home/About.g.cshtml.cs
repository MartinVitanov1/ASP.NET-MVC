#pragma checksum "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0e26696f86b3c0bfe6804654167965e5da569aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\_ViewImports.cshtml"
using ToDoApplication.Models.DomainModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e26696f86b3c0bfe6804654167965e5da569aa", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6495ab74950df7410147d8f0326e4eaa020faf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(12, 13, false);
#line 4 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Home\About.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(25, 63, true);
            WriteLiteral("</h1>\n\n<p>Use this area to provide additional information.</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591