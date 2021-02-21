#pragma checksum "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Manager\LogIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f607a17dd7ae9399413e18c86e92192d1f5445f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Manager_LogIn), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Manager/LogIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f607a17dd7ae9399413e18c86e92192d1f5445f", @"/Areas/AdminPanel/Views/Manager/LogIn.cshtml")]
    public class Areas_AdminPanel_Views_Manager_LogIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition login-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f607a17dd7ae9399413e18c86e92192d1f5445f3191", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>FreshShop | Login</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""/AdminPanelContent/plugins/fontawesome-free/css/all.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <!-- icheck bootstrap -->
    <link rel=""stylesheet"" href=""/AdminPanelContent/plugins/icheck-bootstrap/icheck-bootstrap.min.css"">
    <!-- Theme style -->
    <link href=""/AdminPanelContent/plugins/sweetalert2/sweetalert2.css"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""/AdminPanelContent/dist/css/adminlte.min.css"">
    <!-- Google Font: Source Sans Pro -->
    <link href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f607a17dd7ae9399413e18c86e92192d1f5445f5197", async() => {
                WriteLiteral(@"
    <div class=""login-box"">
        <div class=""login-logo"">
            <a href=""../../index2.html""><b>Fresh</b>SHOP</a>
        </div>
        <!-- /.login-logo -->
        <div class=""card"">
            <div class=""card-body login-card-body"">
                <p class=""login-box-msg"">Oturum açmak için giriş yapınız</p>

                <form>
                    <div class=""input-group mb-3"">
                        <input id=""txtUserName"" type=""text"" class=""form-control"" placeholder=""Kullanıcı Adı""");
                BeginWriteAttribute("value", " value=\"", 1609, "\"", 1639, 1);
#nullable restore
#line 36 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Manager\LogIn.cshtml"
WriteAttributeValue("", 1617, ViewData["cookie_UN"], 1617, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""input-group-append"">
                            <div class=""input-group-text"">
                                <span class=""fas fa-envelope""></span>
                            </div>
                        </div>
                    </div>
                    <div class=""input-group mb-3"">
                        <input id=""txtPassword"" type=""password"" class=""form-control"" placeholder=""Şifre""");
                BeginWriteAttribute("value", " value=\"", 2084, "\"", 2114, 1);
#nullable restore
#line 44 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Manager\LogIn.cshtml"
WriteAttributeValue("", 2092, ViewData["cookie_PW"], 2092, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""input-group-append"">
                            <div class=""input-group-text"">
                                <span class=""fas fa-lock""></span>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-8"">
                            <div class=""icheck-primary"">
                                <input type=""checkbox"" id=""remember"" ");
#nullable restore
#line 54 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Manager\LogIn.cshtml"
                                                                 Write((bool)ViewData["chIsChecked"] ? "checked=\"checked\"" : null);

#line default
#line hidden
#nullable disable
                WriteLiteral(@">
                                <label for=""remember"">
                                    Beni Hatırla
                                </label>
                            </div>
                        </div>
                        <!-- /.col -->
                        <div class=""col-4"">
                            <button id=""btnLogIn"" type=""button"" class=""btn btn-primary btn-block"">Giriş Yap</button>
                        </div>
                        <!-- /.col -->
                    </div>
                </form>

                <p class=""mb-1"">
                    <a href=""#"" data-toggle=""modal"" data-target=""#divForgotPassword"">Şifremi Unuttum</a>
                </p>

            </div>
            <!-- /.login-card-body -->
        </div>
    </div>

    <div class=""modal fade"" id=""divForgotPassword"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=");
                WriteLiteral(@"""exampleModalLabel"">Şifremi Unuttum</h5>
                    <button type=""button"" class=""close"" data-bs-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;></span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label>Email</label>
                        <input type=""email"" class=""form-control"" id=""txtEmail"">
                        <small id=""emailHelp"" class=""form-text text-muted"">Şifrenizin gönderilmesini istediğiniz sistemimizde kayıtlı mail adresinizi giriniz.</small>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Kapat</button>
                    <button id=""btnSendPassword"" type=""button"" class=""btn btn-primary"">Şifremi Gönder</button>
                </div>
            </div>
        </div>
    ");
                WriteLiteral(@"</div>





    <!-- /.login-box -->
    <!-- jQuery -->
    <script src=""/AdminPanelContent/plugins/jquery/jquery.min.js""></script>
    <!-- Bootstrap 4 -->
    <script src=""/AdminPanelContent/plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- AdminLTE App -->
    <script src=""/AdminPanelContent/dist/js/adminlte.min.js""></script>
    <script src=""/AdminPanelContent/plugins/sweetalert2/sweetalert2.js""></script>
    <script>
        $(document).ready(function () {
            $(""#btnLogIn"").click(function () {

                var clientData = {
                    UserName: $(""#txtUserName"").val(),
                    Password: $(""#txtPassword"").val(),
                    RememberMe: $(""#remember"").is("":checked"")
                };


                $.ajax({
                    url: ""/admin"",
                    method: ""post"",
                    dataType: ""json"",
                    data: { vm: clientData },
                    success: function (resp) {
        ");
                WriteLiteral(@"                if (resp.isOk)
                            window.location.href = ""/admin-dashboard"";
                        else {
                            Swal.fire({
                                icon: 'error',
                                title: 'Kullanıcı Bulunamadı',
                                html: resp.message
                            })
                        }
                    }
                });
            });

            $(""#btnSendPassword"").click(function () {
                var vm = {
                    Email: $(""#txtEmail"").val()
                };

                $.ajax({
                    url: ""/forgot-password"",
                    method: ""post"",
                    dataType: ""json"",
                    data: { vm: vm },
                    success: function (resp) {
                        if (resp.isOk) {
                            Swal.fire({
                                icon: 'succes',
                                title: '");
                WriteLiteral(@"Şifreniz Başarıyla Gönderildi',
                                text: resp.message
                            });
                        }
                        else {
                            Swal.fire({
                                icon: 'error',
                                title: 'Şifre Gönderilemedi',
                                text: resp.message
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
