#pragma checksum "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Shared\_Tasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f18727b603044d913209264ae7f9509b815cd27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Tasks), @"mvc.1.0.view", @"/Views/Shared/_Tasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Tasks.cshtml", typeof(AspNetCore.Views_Shared__Tasks))]
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
using ToDoApplication;

#line default
#line hidden
#line 2 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\_ViewImports.cshtml"
using ToDoApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f18727b603044d913209264ae7f9509b815cd27", @"/Views/Shared/_Tasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c445bdeba7a11e2b82cdbead924050244346a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Tasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 59, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        ");
            EndContext();
            BeginContext(82, 27, false);
#line 6 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Shared\_Tasks.cshtml"
   Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(109, 12, true);
            WriteLiteral(":\r\n        \"");
            EndContext();
            BeginContext(122, 27, false);
#line 7 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Shared\_Tasks.cshtml"
    Write(Html.ValueFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(149, 51, true);
            WriteLiteral("\"\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        ");
            EndContext();
            BeginContext(201, 32, false);
#line 10 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Shared\_Tasks.cshtml"
   Write(Html.LabelFor(x => x.Descripton));

#line default
#line hidden
            EndContext();
            BeginContext(233, 12, true);
            WriteLiteral(":\r\n        \"");
            EndContext();
            BeginContext(246, 32, false);
#line 11 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Shared\_Tasks.cshtml"
    Write(Html.ValueFor(x => x.Descripton));

#line default
#line hidden
            EndContext();
            BeginContext(278, 51, true);
            WriteLiteral("\"\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        ");
            EndContext();
            BeginContext(330, 32, false);
#line 14 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Shared\_Tasks.cshtml"
   Write(Html.LabelFor(x => x.Importance));

#line default
#line hidden
            EndContext();
            BeginContext(362, 12, true);
            WriteLiteral(":\r\n        \"");
            EndContext();
            BeginContext(375, 32, false);
#line 15 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Shared\_Tasks.cshtml"
    Write(Html.ValueFor(x => x.Importance));

#line default
#line hidden
            EndContext();
            BeginContext(407, 51, true);
            WriteLiteral("\"\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        ");
            EndContext();
            BeginContext(459, 26, false);
#line 18 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Shared\_Tasks.cshtml"
   Write(Html.LabelFor(x => x.Type));

#line default
#line hidden
            EndContext();
            BeginContext(485, 12, true);
            WriteLiteral(":\r\n        \"");
            EndContext();
            BeginContext(498, 26, false);
#line 19 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Shared\_Tasks.cshtml"
    Write(Html.ValueFor(x => x.Type));

#line default
#line hidden
            EndContext();
            BeginContext(524, 51, true);
            WriteLiteral("\"\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        ");
            EndContext();
            BeginContext(576, 28, false);
#line 22 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Shared\_Tasks.cshtml"
   Write(Html.LabelFor(x => x.Status));

#line default
#line hidden
            EndContext();
            BeginContext(604, 12, true);
            WriteLiteral(":\r\n        \"");
            EndContext();
            BeginContext(617, 28, false);
#line 23 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Shared\_Tasks.cshtml"
    Write(Html.ValueFor(x => x.Status));

#line default
#line hidden
            EndContext();
            BeginContext(645, 23, true);
            WriteLiteral("\"\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591