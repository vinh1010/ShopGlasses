#pragma checksum "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75c2636a14dea90d258fd1ec4abe4268320befa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Materials_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Materials/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Materials/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Materials_Index))]
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
#line 2 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75c2636a14dea90d258fd1ec4abe4268320befa5", @"/Areas/Admin/Views/Materials/Index.cshtml")]
    public class Areas_Admin_Views_Materials_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<BTL.Models.Materials>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(154, 1292, true);
            WriteLiteral(@"
<section class=""content"" style=""padding-top: 20px"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Danh sách chất liệu</h3>
                        <div class=""card-tools"">
                            <form action=""/Admin/Materials/Index"" method=""GET"">
                                <div class=""input-group input-group-sm"" style=""width: 350px;"">
                                    <input type=""text"" name=""Search"" class=""form-control float-right"" placeholder=""Nhâp tên chất liệu"">
                                    <div class=""input-group-append"">
                                        <button type=""submit"" class=""btn btn-default"">
                                            <i class=""fas fa-search""></i>
                                        </button>
                                    </div>
                      ");
            WriteLiteral(@"          </div>
                            </form>
                        </div>
                    </div>

                    <div class=""card-body"">
                        <a class=""btn btn-primary"" href=""/Admin/Materials/Create"">Thêm mới chất liệu</a>
");
            EndContext();
#line 30 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                         if (TempData["success"] != null)
                        {

#line default
#line hidden
            BeginContext(1532, 132, true);
            WriteLiteral("                            <div class=\"alert alert-success\" role=\"alert\" style=\"margin-top:20px\">\r\n                                ");
            EndContext();
            BeginContext(1665, 29, false);
#line 33 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                           Write(Html.Raw(TempData["success"]));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 35 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1759, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 36 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                         if (TempData["eror"] != null)
                        {

#line default
#line hidden
            BeginContext(1842, 131, true);
            WriteLiteral("                            <div class=\"alert alert-danger\" role=\"alert\" style=\"margin-top:20px\">\r\n                                ");
            EndContext();
            BeginContext(1974, 26, false);
#line 39 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                           Write(Html.Raw(TempData["eror"]));

#line default
#line hidden
            EndContext();
            BeginContext(2000, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 41 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2065, 508, true);
            WriteLiteral(@"                        <table class=""table table-bordered"" style=""margin-top: 20px"">
                            <thead>
                                <tr>
                                    <th>Mã chất liệu</th>
                                    <th>Tên chất liệu</th>
                                    <th>Trạng thái</th>
                                    <th>Chức năng</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 52 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                                 foreach (var material in Model)
                                {

#line default
#line hidden
            BeginContext(2674, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(2761, 19, false);
#line 55 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                                       Write(material.MaterialId);

#line default
#line hidden
            EndContext();
            BeginContext(2780, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2832, 21, false);
#line 56 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                                       Write(material.NameMaterial);

#line default
#line hidden
            EndContext();
            BeginContext(2853, 53, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n");
            EndContext();
#line 58 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                                             if ((bool)material.Status)
                                            {

#line default
#line hidden
            BeginContext(3026, 95, true);
            WriteLiteral("                                                <span class=\"badge bg-success\">Sử dụng</span>\r\n");
            EndContext();
#line 61 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(3265, 100, true);
            WriteLiteral("                                                <span class=\"badge bg-danger\">Không sử dụng</span>\r\n");
            EndContext();
#line 65 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3412, 162, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a style=\"color: green\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3574, "\"", 3626, 2);
            WriteAttributeValue("", 3581, "/Admin/Materials/Edit?id=", 3581, 25, true);
#line 69 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
WriteAttributeValue("", 3606, material.MaterialId, 3606, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3627, 157, true);
            WriteLiteral(" title=\"Sửa thông tin\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i></a>\r\n                                            <a style=\"color: red;padding-left: 20px\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3784, "\"", 3838, 2);
            WriteAttributeValue("", 3791, "/Admin/Materials/Delete?id=", 3791, 27, true);
#line 70 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
WriteAttributeValue("", 3818, material.MaterialId, 3818, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3839, 165, true);
            WriteLiteral(" title=\"Xóa bản ghi\"><i class=\"fa fa-trash\" aria-hidden=\"true\"></i></a>\r\n\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 74 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4039, 265, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>

                    <div class=""card-footer clearfix"">
                        <ul class=""pagination pagination-sm m-0 float-right"">
                            ");
            EndContext();
            BeginContext(4305, 400, false);
#line 81 "C:\Users\101020\OneDrive\Documents\Sem 3\WAD\BTL\BTL_ASP\BTL\Areas\Admin\Views\Materials\Index.cshtml"
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
            BeginContext(4705, 159, true);
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<BTL.Models.Materials>> Html { get; private set; }
    }
}
#pragma warning restore 1591
