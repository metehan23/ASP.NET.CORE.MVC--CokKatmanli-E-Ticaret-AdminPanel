#pragma checksum "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Manager\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23d87cd6cb07a37f68052b88ef5686aa22e73be3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Manager_New), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Manager/New.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d87cd6cb07a37f68052b88ef5686aa22e73be3", @"/Areas/AdminPanel/Views/Manager/New.cshtml")]
    public class Areas_AdminPanel_Views_Manager_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Manager\New.cshtml"
  
    ViewData["Title"] = "New";
    Layout = "~/Areas/AdminPanel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script src=\"/AdminPanelContent/plugins/sweetalert2/sweetalert2.js\"></script>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#btnSave"").click(function () {
                var formData = new FormData();
                var file = $(""#fuPhoto"")[0].files[0];
                formData.append(""photo"", file);

                $.ajax({
                    url: ""/manager-photo-upload"",
                    method: ""post"",
                    data: formData,
                    contentType: false,
                    processData: false,
                    success: function (response) {
                        if (response.isOk) {
                            var vm = {
                                FullName: $(""#txtFullName"").val(),
                                UserName: $(""#txtUserName"").val(),
                                Password: $(""#txtPassword"").val(),
                                Email: $(""#txtEmail"").val(),
                                PhotoPath: response.photoPath
                            };

                            $.aj");
                WriteLiteral(@"ax({
                                url: ""/new-manager"",
                                method: ""post"",
                                dataType: ""json"",
                                data: { vm: vm },
                                success: function (resp) {
                                    if (resp.isOk) {
                                        Swal.fire({
                                            icon: 'succes',
                                            title: 'Yönetici Başarıyla Kaydedildi',
                                            text: resp.message
                                        });
                                        window.location.href = ""/managers"";
                                    }
                                } 
                            });
                        }
                    }
                });
            });
        });
    </script>
 ");
            }
            );
            WriteLiteral(@"

    <div class=""col-md-12"">
        <div class=""card card-primary"">
            <div class=""card-header"">
                <h3 class=""card-title"">Yönetici Kayıt Formu</h3>
            </div>

            <form role=""form"">
                <div class=""card-body"">
                    <div class=""form-group"">
                        <label>Ad Soyad</label>
                        <input type=""text"" class=""form-control"" id=""txtFullName"" placeholder=""Ad Soyad Giriniz"">
                    </div>
                    <div class=""form-group"">
                        <label>Kullanıcı Adı</label>
                        <input type=""text"" class=""form-control"" id=""txtUserName"" placeholder=""Kullanıcı Adı Giriniz"">
                    </div>
                    <div class=""form-group"">
                        <label>Şifre</label>
                        <input type=""password"" class=""form-control"" id=""txtPassword"" placeholder=""Şifre Giriniz"">
                    </div>
                    <div class=");
            WriteLiteral(@"""form-group"">
                        <label>Email</label>
                        <input type=""email"" class=""form-control"" id=""txtEmail"" placeholder=""Email Giriniz"">
                    </div>
                    <div class=""form-group"">
                        <label>Dosya Seçme</label>
                        <div class=""input-group"">
                            <div class=""custom-file"">
                                <input type=""file"" class=""custom-file-input"" id=""fuPhoto"">
                                <label class=""custom-file-label"">Dosya Seç</label>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <button id=""btnSave"" type=""button"" class=""btn btn-primary"">Kaydet</button>
                </div>
            </form>
        </div>
    </div>
        

");
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
