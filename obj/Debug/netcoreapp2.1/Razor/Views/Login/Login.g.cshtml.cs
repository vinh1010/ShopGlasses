#pragma checksum "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b3709028cec414f4b6f97210fdd57eb364c10a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Login.cshtml", typeof(AspNetCore.Views_Login_Login))]
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
#line 1 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\_ViewImports.cshtml"
using BTL;

#line default
#line hidden
#line 2 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\_ViewImports.cshtml"
using BTL.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b3709028cec414f4b6f97210fdd57eb364c10a2", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3e8df3d70c76e1818d2beb7c07b0d2cd01e79e", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forgot-pass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Login/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Login\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 100, true);
            WriteLiteral("\r\n<div class=\"main\">\r\n    <div class=\"container\">\r\n        <ul class=\"breadcrumb\">\r\n            <li>");
            EndContext();
            BeginContext(190, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd8f71b5e454db89d3054dee581baf1", async() => {
                BeginContext(234, 9, true);
                WriteLiteral("Trang chủ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(247, 513, true);
            WriteLiteral(@"</li>
            <li class=""active"">Đăng nhập</li>
        </ul>
        <div class=""d-lg-flex half"" style=""width: 50%;margin-left: 25%;"">
            <div class=""contents order-2 order-md-1"">
                <div class=""container"" style=""margin-top: 100px;margin-bottom: 100px"">
                    <div class=""row align-items-center justify-content-center"">
                        <div class=""col-md-7"">
                            <h3 class=""text-center"">Đăng nhập </h3>
                            ");
            EndContext();
            BeginContext(760, 2338, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf19b1a4c7994b5d86da8f7df879937d", async() => {
                BeginContext(802, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 20 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Login\Login.cshtml"
                                 if (ViewBag.Erorr != null)
                                {

#line default
#line hidden
                BeginContext(900, 123, true);
                WriteLiteral("                                    <div class=\"alert alert-danger\" role=\"alert\">\r\n                                        ");
                EndContext();
                BeginContext(1024, 23, false);
#line 23 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Login\Login.cshtml"
                                   Write(Html.Raw(ViewBag.Erorr));

#line default
#line hidden
                EndContext();
                BeginContext(1047, 46, true);
                WriteLiteral("\r\n                                    </div>\r\n");
                EndContext();
#line 25 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Login\Login.cshtml"
                                }

#line default
#line hidden
                BeginContext(1128, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Login\Login.cshtml"
                                 if (TempData["success"] != null)
                                {

#line default
#line hidden
                BeginContext(1232, 124, true);
                WriteLiteral("                                    <div class=\"alert alert-success\" role=\"alert\">\r\n                                        ");
                EndContext();
                BeginContext(1357, 29, false);
#line 30 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Login\Login.cshtml"
                                   Write(Html.Raw(TempData["success"]));

#line default
#line hidden
                EndContext();
                BeginContext(1386, 46, true);
                WriteLiteral("\r\n                                    </div>\r\n");
                EndContext();
#line 32 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Login\Login.cshtml"
                                }

#line default
#line hidden
                BeginContext(1467, 1305, true);
                WriteLiteral(@"                                <div class=""form-group first"">
                                    <label for=""username"">Email</label>
                                    <input type=""text"" name=""email"" class=""form-control"" placeholder=""Nhập email của bạn"">
                                </div>
                                <div class=""form-group last mb-3"">
                                    <label for=""password"">Mật khẩu</label>
                                    <input type=""password"" name=""password"" class=""form-control"" placeholder=""Nhập mật khẩu"">
                                </div>

                                <div class=""d-flex mb-5 align-items-center"">
                                    <label class=""control control--checkbox mb-0"">
                                        <span class=""caption"">Nhớ mật khẩu</span>
                                        <input type=""checkbox"" />
                                    </label>
                                </div>

           ");
                WriteLiteral(@"                     <div class=""d-flex mb-5 align-items-center"" style=""margin-top: 10px;margin-bottom: 10px"">
                                    <label class=""control control--checkbox mb-0"">
                                        <span class=""caption"">Bạn chưa có tài khoản: ");
                EndContext();
                BeginContext(2772, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9d715b7447f442c983f81a7e60150ba", async() => {
                    BeginContext(2840, 12, true);
                    WriteLiteral("Đăng ký ngay");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2856, 235, true);
                WriteLiteral(" </span>\r\n                                    </label>\r\n                                </div>\r\n\r\n                                <input type=\"submit\" value=\"Đăng nhập\" class=\"btn btn-block btn-primary\">\r\n\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3098, 142, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
