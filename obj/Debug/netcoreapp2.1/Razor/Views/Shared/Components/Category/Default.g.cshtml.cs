#pragma checksum "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5adf28fce026db985d5f6658800d9970b6456ef2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Category/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Category/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Category_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5adf28fce026db985d5f6658800d9970b6456ef2", @"/Views/Shared/Components/Category/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3e8df3d70c76e1818d2beb7c07b0d2cd01e79e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BTL.Models.Categories>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductByCate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 139, true);
            WriteLiteral("\r\n<li class=\"dropdown nav-catalogue\">\r\n    <a class=\"dropdown-toggle\">\r\n        Gọng kính cận\r\n\r\n    </a>\r\n    <ul class=\"dropdown-menu\">\r\n");
            EndContext();
#line 9 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml"
         foreach (var cate in Model)
        {

#line default
#line hidden
            BeginContext(231, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(247, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41370db359d846e49f9c60cac3f2bc61", async() => {
                BeginContext(335, 17, false);
#line 11 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml"
                                                                                                  Write(cate.NameCategory);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml"
                                                                         WriteLiteral(cate.CategoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(356, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 12 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(374, 159, true);
            WriteLiteral("    </ul>\r\n</li>\r\n<li class=\"dropdown dropdown-megamenu\">\r\n    <a class=\"dropdown-toggle\">\r\n        Gọng kính râm\r\n\r\n    </a>\r\n    <ul class=\"dropdown-menu\">\r\n");
            EndContext();
#line 21 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml"
         foreach (var cate2 in ViewBag.listCate2)
        {

#line default
#line hidden
            BeginContext(595, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(611, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f9626f258894d1ab0f436804aad159a", async() => {
                BeginContext(700, 18, false);
#line 23 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml"
                                                                                                   Write(cate2.NameCategory);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml"
                                                                         WriteLiteral(cate2.CategoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(722, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 24 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(740, 150, true);
            WriteLiteral("    </ul>\r\n</li>\r\n<li class=\"dropdown nav-catalogue\">\r\n    <a class=\"dropdown-toggle\">\r\n        Mắt kính\r\n\r\n    </a>\r\n    <ul class=\"dropdown-menu\">\r\n");
            EndContext();
#line 33 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml"
         foreach (var cate3 in ViewBag.listCate3)
        {

#line default
#line hidden
            BeginContext(952, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(968, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f3df98e5a5f4a9eaff31b89b3a3cf60", async() => {
                BeginContext(1057, 18, false);
#line 35 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml"
                                                                                                   Write(cate3.NameCategory);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml"
                                                                         WriteLiteral(cate3.CategoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1079, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 36 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Views\Shared\Components\Category\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(1097, 18, true);
            WriteLiteral("    </ul>\r\n</li>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BTL.Models.Categories>> Html { get; private set; }
    }
}
#pragma warning restore 1591
