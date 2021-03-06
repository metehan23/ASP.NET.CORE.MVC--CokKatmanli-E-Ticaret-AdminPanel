#pragma checksum "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Product\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84a46c1bd0aee9ada6498963419a632488eee7a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Product_Index1), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Product/Index1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84a46c1bd0aee9ada6498963419a632488eee7a4", @"/Areas/AdminPanel/Views/Product/Index1.cshtml")]
    public class Areas_AdminPanel_Views_Product_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FreshShop.Model.Entity.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Product\Index1.cshtml"
  
    ViewData["Title"] = "Index1";
    Layout = "~/Areas/AdminPanel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/AdminPanelContent/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css\">\r\n    <link rel=\"stylesheet\" href=\"/AdminPanelContent/plugins/datatables-responsive/css/responsive.bootstrap4.min.css\">\r\n");
            }
            );
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script src=""/AdminPanelContent/plugins/datatables/jquery.dataTables.min.js""></script>
    <script src=""/AdminPanelContent/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js""></script>
    <script src=""/AdminPanelContent/plugins/datatables-responsive/js/dataTables.responsive.min.js""></script>
    <script src=""/AdminPanelContent/plugins/datatables-responsive/js/responsive.bootstrap4.min.js""></script>
    <script>
        $(function () {
            $(""#tblCategories"").DataTable({
                ""responsive"": true,
                ""autoWidth"": false,
            });
            //$('#example2').DataTable({
            //    ""paging"": true,
            //    ""lengthChange"": false,
            //    ""searching"": false,
            //    ""ordering"": true,
            //    ""info"": true,
            //    ""autoWidth"": false,
            //    ""responsive"": true,
            //});
        });
    </script>


");
            }
            );
            WriteLiteral(@"
<div class=""col-12"">
    <div class=""card"">
        <div class=""card-header"">
            <h3 class=""card-title""><b>KATEGORİLER</b></h3>
        </div>
        <!-- /.card-header -->
        <div class=""card-body"">
            <table id=""tblCategories"" class=""table table-bordered table-striped"">
                <thead>
                    <tr>
                        <th>Categori Adı</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 53 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Product\Index1.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Product\Index1.cshtml"
                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td>
                                <a href=""#"" class=""btn btn-warning"">Düzenle</a>
                            </td>
                            <td>
                                <a href=""#"" class=""btn btn-danger"">Sil</a>
                            </td>
                        </tr>
");
#nullable restore
#line 64 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Product\Index1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n        <!-- /.card-body -->\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FreshShop.Model.Entity.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
