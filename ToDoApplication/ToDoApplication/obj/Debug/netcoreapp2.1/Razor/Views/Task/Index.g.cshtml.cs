#pragma checksum "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc55dfc03e747f3548e1f67dd9017b0e66465281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/Index.cshtml", typeof(AspNetCore.Views_Task_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc55dfc03e747f3548e1f67dd9017b0e66465281", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c445bdeba7a11e2b82cdbead924050244346a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Task\Index.cshtml"
   
    ViewBag.Title = "Create Task";

#line default
#line hidden
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 34, false);
#line 6 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Task\Index.cshtml"
Write(Html.Partial("_CreateTask", Model));

#line default
#line hidden
            EndContext();
            BeginContext(103, 1, true);
            WriteLiteral(";");
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