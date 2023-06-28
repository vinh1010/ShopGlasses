#pragma checksum "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "595a89eed1a6c49c95c9b531d13768fe0932adc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Products/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Products_Index))]
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
#line 2 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595a89eed1a6c49c95c9b531d13768fe0932adc2", @"/Areas/Admin/Views/Products/Index.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<BTL.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(187, 1288, true);
            WriteLiteral(@"
<section class=""content"" style=""padding-top: 20px"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Danh sách sản phẩm</h3>
                        <div class=""card-tools"">
                            <form action=""/Admin/Products/Index"" method=""GET"">
                                <div class=""input-group input-group-sm"" style=""width: 350px;"">
                                    <input type=""text"" name=""Search"" class=""form-control float-right"" placeholder=""Nhâp tên sản phẩm"">
                                    <div class=""input-group-append"">
                                        <button type=""submit"" class=""btn btn-default"">
                                            <i class=""fas fa-search""></i>
                                        </button>
                                    </div>
                         ");
            WriteLiteral(@"       </div>
                            </form>
                        </div>
                    </div>

                    <div class=""card-body"">
                        <a class=""btn btn-primary"" href=""/Admin/Products/Create"">Thêm mới sản phẩm </a>
");
            EndContext();
#line 31 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                         if (TempData["success"] != null)
                        {

#line default
#line hidden
            BeginContext(1561, 132, true);
            WriteLiteral("                            <div class=\"alert alert-success\" role=\"alert\" style=\"margin-top:20px\">\r\n                                ");
            EndContext();
            BeginContext(1694, 29, false);
#line 34 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                           Write(Html.Raw(TempData["success"]));

#line default
#line hidden
            EndContext();
            BeginContext(1723, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 36 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1788, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 37 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                         if (TempData["eror"] != null)
                        {

#line default
#line hidden
            BeginContext(1871, 131, true);
            WriteLiteral("                            <div class=\"alert alert-danger\" role=\"alert\" style=\"margin-top:20px\">\r\n                                ");
            EndContext();
            BeginContext(2003, 26, false);
#line 40 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                           Write(Html.Raw(TempData["eror"]));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 42 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2094, 920, true);
            WriteLiteral(@"                        <table class=""table table-bordered"" style=""margin-top: 20px"">
                            <thead>
                                <tr>
                                    <th>Mã SP</th>
                                    <th>Tên sản phẩm</th>
                                    <th width=""10%"">Ảnh sản phẩm</th>
                                    <th>Giá</th>
                                    <th>Giá khuyến mãi</th>
                                    <th>Số lượng</th>
                                    <th>Danh mục</th>
                                    <th>Nhãn hàng</th>
                                    <th>Chất liệu</th>
                                    <th>Trạng thái</th>
                                    <th style=""width: 7%"">Công cụ</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 60 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                 foreach (var pro in Model)
                                {

#line default
#line hidden
            BeginContext(3110, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3197, 13, false);
#line 63 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                       Write(pro.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(3210, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3262, 15, false);
#line 64 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                       Write(pro.NameProduct);

#line default
#line hidden
            EndContext();
            BeginContext(3277, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3328, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e29693bdf0024b0c9e0eee3638a6389a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3338, "~/products/", 3338, 11, true);
#line 65 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 3349, pro.Image, 3349, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 65 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 3366, pro.NameProduct, 3366, 16, false);

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
            BeginContext(3396, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3448, 9, false);
#line 66 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                       Write(pro.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3457, 55, true);
            WriteLiteral(" VNĐ</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3513, 13, false);
#line 67 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                       Write(pro.SalePrice);

#line default
#line hidden
            EndContext();
            BeginContext(3526, 55, true);
            WriteLiteral(" VNĐ</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3582, 12, false);
#line 68 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                       Write(pro.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3594, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3646, 25, false);
#line 69 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                       Write(pro.Category.NameCategory);

#line default
#line hidden
            EndContext();
            BeginContext(3671, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3723, 19, false);
#line 70 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                       Write(pro.Brand.NameBrand);

#line default
#line hidden
            EndContext();
            BeginContext(3742, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3794, 25, false);
#line 71 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                       Write(pro.Material.NameMaterial);

#line default
#line hidden
            EndContext();
            BeginContext(3819, 53, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n");
            EndContext();
#line 73 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                             if ((bool)pro.Status)
                                            {

#line default
#line hidden
            BeginContext(3987, 96, true);
            WriteLiteral("                                                <span class=\"badge bg-success\">Còn hàng</span>\r\n");
            EndContext();
#line 76 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(4227, 95, true);
            WriteLiteral("                                                <span class=\"badge bg-danger\">Hết hàng</span>\r\n");
            EndContext();
#line 80 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4369, 162, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a style=\"color: green\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4531, "\"", 4576, 2);
            WriteAttributeValue("", 4538, "/Admin/Products/Edit?id=", 4538, 24, true);
#line 84 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 4562, pro.ProductId, 4562, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4577, 157, true);
            WriteLiteral(" title=\"Sửa thông tin\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i></a>\r\n                                            <a style=\"color: red;padding-left: 20px\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4734, "\"", 4781, 2);
            WriteAttributeValue("", 4741, "/Admin/Products/Delete?id=", 4741, 26, true);
#line 85 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 4767, pro.ProductId, 4767, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4782, 165, true);
            WriteLiteral(" title=\"Xóa bản ghi\"><i class=\"fa fa-trash\" aria-hidden=\"true\"></i></a>\r\n\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 89 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4982, 265, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>

                    <div class=""card-footer clearfix"">
                        <ul class=""pagination pagination-sm m-0 float-right"">
                            ");
            EndContext();
            BeginContext(5248, 400, false);
#line 96 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Products\Index.cshtml"
                       Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page = page }),
                             new PagedListRenderOptions
                                {
                                    LiElementClasses = new string[] { "page-item" },
                                    PageClasses = new string[] { "page-link" }
                                }
                            ));

#line default
#line hidden
            EndContext();
            BeginContext(5648, 153, true);
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<BTL.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
