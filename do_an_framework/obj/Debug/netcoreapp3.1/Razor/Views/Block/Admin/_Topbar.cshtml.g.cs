#pragma checksum "C:\project\do_an_framework\do_an_framework\do_an_framework\Views\Block\Admin\_Topbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4490ab13cc67ac6a4743af581e6b0ca7a673e321"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Block_Admin__Topbar), @"mvc.1.0.view", @"/Views/Block/Admin/_Topbar.cshtml")]
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
#line 1 "C:\project\do_an_framework\do_an_framework\do_an_framework\Views\_ViewImports.cshtml"
using do_an_framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\project\do_an_framework\do_an_framework\do_an_framework\Views\_ViewImports.cshtml"
using do_an_framework.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4490ab13cc67ac6a4743af581e6b0ca7a673e321", @"/Views/Block/Admin/_Topbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c819f096963f888405f1a1ff11f14f7ed2d34635", @"/Views/_ViewImports.cshtml")]
    public class Views_Block_Admin__Topbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mr-auto w-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

    <!-- Sidebar Toggle (Topbar) -->
    <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
        <i class=""fa fa-bars""></i>
    </button>

    <!-- Topbar Navbar -->
    <ul class=""navbar-nav ml-auto"">

        <!-- Nav Item - Search Dropdown (Visible Only XS) -->
        <li class=""nav-item dropdown no-arrow d-sm-none"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button"" data-toggle=""dropdown""
               aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-search fa-fw""></i>
            </a>
            <!-- Dropdown - Messages -->
            <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in""
                 aria-labelledby=""searchDropdown"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4490ab13cc67ac6a4743af581e6b0ca7a673e3214591", async() => {
                WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for...""
                               aria-label=""Search"" aria-describedby=""basic-addon2"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-primary"" type=""button"">
                                <i class=""fas fa-search fa-sm""></i>
                            </button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </li>

        <div class=""topbar-divider d-none d-sm-block""></div>

        <!-- Nav Item - User Information -->

        <li class=""nav-item dropdown no-arrow"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown""
               aria-haspopup=""true"" aria-expanded=""false"">
                <span class=""mr-2 d-none d-lg-inline text-gray-600 small""></span>
                <img class=""img-profile rounded-circle""");
            BeginWriteAttribute("src", " src=\"", 2043, "\"", 2049, 0);
            EndWriteAttribute();
            WriteLiteral(" alt=\"avatar\">\r\n            </a>\r\n            <!-- Dropdown - User Information -->\r\n            <div class=\"dropdown-menu dropdown-menu-right shadow animated--grow-in\" aria-labelledby=\"userDropdown\">\r\n                <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 2291, "\"", 2298, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fas fa-user fa-sm fa-fw mr-2 text-gray-400\"></i>\r\n                    Thông Tin\r\n                </a>\r\n                <div class=\"dropdown-divider\"></div>\r\n                <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 2529, "\"", 2536, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400\"></i>\r\n                    Đăng Xuất\r\n                </a>\r\n            </div>\r\n        </li>\r\n\r\n    </ul>\r\n\r\n</nav>");
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