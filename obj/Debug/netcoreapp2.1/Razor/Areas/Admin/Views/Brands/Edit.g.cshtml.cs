#pragma checksum "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Brands\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dda950373f27495415ede3c1d14f7f864f9ec535"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Brands_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Brands/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Brands/Edit.cshtml", typeof(AspNetCore.Areas_Admin_Views_Brands_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda950373f27495415ede3c1d14f7f864f9ec535", @"/Areas/Admin/Views/Brands/Edit.cshtml")]
    public class Areas_Admin_Views_Brands_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BTL.Models.Brands>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("20%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Brands\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(130, 692, true);
            WriteLiteral(@"
<section class=""content"" style=""padding-top: 20px"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card card-primary"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Cập nhật nhãn hàng</h3>
                    </div>

                    <form action=""/Admin/Brands/Edit"" method=""POST"" enctype=""multipart/form-data"">
                        <div class=""card-body"">
                            <div class=""form-group"">
                                <label for=""exampleInputEmail1""> Mã nhãn hàng</label>
                                <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 822, "\"", 844, 1);
#line 20 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Brands\Edit.cshtml"
WriteAttributeValue("", 830, Model.BrandId, 830, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(845, 300, true);
            WriteLiteral(@" name=""BrandId"" class=""form-control"" id=""exampleInputEmail1"" readonly>
                            </div>
                            <div class=""form-group"">
                                <label for=""exampleInputEmail1""> Tên nhãn hàng</label>
                                <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1145, "\"", 1169, 1);
#line 24 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Brands\Edit.cshtml"
WriteAttributeValue("", 1153, Model.NameBrand, 1153, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1170, 346, true);
            WriteLiteral(@" name=""NameBrand"" class=""form-control"" id=""exampleInputEmail1"" placeholder=""Nhập tên nhãn hàng"">
                            </div>
                            <div class=""form-group"">
                                <label for=""exampleInputEmail1""> Ảnh nhãn hàng</label>
                                <br>
                                ");
            EndContext();
            BeginContext(1516, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "785644b87afc4875bb7ac3ab62357bf8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1526, "~/brands/", 1526, 9, true);
#line 29 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Brands\Edit.cshtml"
AddHtmlAttributeValue("", 1535, Model.Image, 1535, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1561, 189, true);
            WriteLiteral("\r\n                                <input type=\"file\" class=\"form-control-file\" name=\"Images\" id=\"exampleFormControlFile1\">\r\n                                <input type=\"hidden\" name=\"Image\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1750, "\"", 1770, 1);
#line 31 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Brands\Edit.cshtml"
WriteAttributeValue("", 1758, Model.Image, 1758, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1771, 299, true);
            WriteLiteral(@">
                            </div>

                            <div class=""form-group"">
                                <label for=""exampleInputPassword1"">Trạng thái</label>
                                <br>
                                <input type=""radio"" name=""Status"" value=""true"" ");
            EndContext();
            BeginContext(2072, 37, false);
#line 37 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Brands\Edit.cshtml"
                                                                           Write(Model.Status == true ? "checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(2110, 90, true);
            WriteLiteral(">Sử dụng\r\n                                <input type=\"radio\" name=\"Status\" value=\"false\" ");
            EndContext();
            BeginContext(2202, 38, false);
#line 38 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Brands\Edit.cshtml"
                                                                            Write(Model.Status == false ? "checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(2241, 396, true);
            WriteLiteral(@">Không sử dụng
                            </div>
                        </div>

                        <div class=""card-footer"">
                            <button type=""submit"" class=""btn btn-primary"">Ghi thông tin</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</section>








");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BTL.Models.Brands> Html { get; private set; }
    }
}
#pragma warning restore 1591
