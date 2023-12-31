#pragma checksum "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ef2e5308db00ef597515390fd28a1649e3c598"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Colors_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Colors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Colors/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Colors_Index))]
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
#line 2 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ef2e5308db00ef597515390fd28a1649e3c598", @"/Areas/Admin/Views/Colors/Index.cshtml")]
    public class Areas_Admin_Views_Colors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<BTL.Models.Colors>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(151, 1784, true);
            WriteLiteral(@"
<section class=""content"" style=""padding-top: 20px"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Danh sách màu sắc</h3>
                        <div class=""card-tools"">
                            <form action=""/Admin/Colors/Index"" method=""GET"">
                                <div class=""input-group input-group-sm"" style=""width: 350px;"">
                                    <input type=""text"" name=""Search"" class=""form-control float-right"" placeholder=""Nhâp tên màu sắc"">
                                    <div class=""input-group-append"">
                                        <button type=""submit"" class=""btn btn-default"">
                                            <i class=""fas fa-search""></i>
                                        </button>
                                    </div>
                             ");
            WriteLiteral(@"   </div>
                            </form>
                        </div>
                    </div>

                    <div class=""card-body"">
                        <a class=""btn btn-primary"" href=""/Admin/Colors/Create"">Thêm mới màu sắc</a>
                        <table class=""table table-bordered"" style=""margin-top: 20px"">
                            <thead>
                                <tr>
                                    <th>Mã màu sắc</th>
                                    <th>Tên màu sắc</th>
                                    <th>Trạng thái</th>
                                    <th>Chức năng</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 40 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
                                 foreach (var color in Model)
                                {

#line default
#line hidden
            BeginContext(2033, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(2120, 13, false);
#line 43 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
                                       Write(color.ColorId);

#line default
#line hidden
            EndContext();
            BeginContext(2133, 97, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2231, 15, false);
#line 45 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
                                       Write(color.NameColor);

#line default
#line hidden
            EndContext();
            BeginContext(2246, 48, true);
            WriteLiteral("\r\n                                            <i");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2294, "\"", 2343, 4);
            WriteAttributeValue("", 2302, "padding-left:", 2302, 13, true);
            WriteAttributeValue(" ", 2315, "20px;color:", 2316, 12, true);
            WriteAttributeValue(" ", 2327, "#", 2328, 2, true);
#line 46 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
WriteAttributeValue("", 2329, color.ColorId, 2329, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2344, 142, true);
            WriteLiteral(" class=\"fa fa-square\" aria-hidden=\"true\"></i>\r\n                                        </td>\r\n\r\n                                        <td>\r\n");
            EndContext();
#line 50 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
                                             if ((bool)color.Status)
                                            {

#line default
#line hidden
            BeginContext(2603, 95, true);
            WriteLiteral("                                                <span class=\"badge bg-success\">Sử dụng</span>\r\n");
            EndContext();
#line 53 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(2842, 100, true);
            WriteLiteral("                                                <span class=\"badge bg-danger\">Không sử dụng</span>\r\n");
            EndContext();
#line 57 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2989, 162, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a style=\"color: green\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3151, "\"", 3194, 2);
            WriteAttributeValue("", 3158, "/Admin/Colors/Edit?id=", 3158, 22, true);
#line 61 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
WriteAttributeValue("", 3180, color.ColorId, 3180, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3195, 157, true);
            WriteLiteral(" title=\"Sửa thông tin\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i></a>\r\n                                            <a style=\"color: red;padding-left: 20px\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3352, "\"", 3397, 2);
            WriteAttributeValue("", 3359, "/Admin/Colors/Delete?id=", 3359, 24, true);
#line 62 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
WriteAttributeValue("", 3383, color.ColorId, 3383, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3398, 165, true);
            WriteLiteral(" title=\"Xóa bản ghi\"><i class=\"fa fa-trash\" aria-hidden=\"true\"></i></a>\r\n\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 66 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3598, 265, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>

                    <div class=""card-footer clearfix"">
                        <ul class=""pagination pagination-sm m-0 float-right"">
                            ");
            EndContext();
            BeginContext(3864, 400, false);
#line 73 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Colors\Index.cshtml"
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
            BeginContext(4264, 153, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<BTL.Models.Colors>> Html { get; private set; }
    }
}
#pragma warning restore 1591
