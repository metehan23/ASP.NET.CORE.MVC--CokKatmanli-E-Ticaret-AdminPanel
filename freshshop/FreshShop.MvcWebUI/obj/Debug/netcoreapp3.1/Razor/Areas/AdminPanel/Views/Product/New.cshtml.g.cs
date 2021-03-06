#pragma checksum "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Product\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1122e819382f5e70cc53b7b1a0d4db0ae0451e05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Product_New), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Product/New.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1122e819382f5e70cc53b7b1a0d4db0ae0451e05", @"/Areas/AdminPanel/Views/Product/New.cshtml")]
    public class Areas_AdminPanel_Views_Product_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SelectListItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ddlCategories"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Product\New.cshtml"
  
    ViewData["Title"] = "New";
    Layout = "~/Areas/AdminPanel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@" 
<script>

    $(document).ready(function () {
        $(""#btnSave"").click(function () {
            var vm = {
                ProductName: $(""#txtProductName"").val(),
                Price: $(""#txtPrice"").val(),
                Discount: $(""#txtDiscount"").val(),
                ShortDescription: $(""#txtShortDescription"").val(),
                CategoryId: $(""#ddlCategories"").val()
            };

            $.ajax({
                url: ""/new-product"",
                method: ""post"",
                dataType: ""json"",
                data: { vm: vm },
                success: function (response) {
                    if (response.isOk) {
                        var formData = new FormData();
                        var files = $(""#fuPhoto"")[0].files;
                        $.each(files, function (i, file) {
                            formData.append(""image[]"", file);
                        });                      

                        formData.append(""prdId"", response.prod");
                WriteLiteral(@"uctId);

                        $.ajax({
                            url: ""/product-photo-upload"",
                            method: ""post"",
                            data: formData,
                            contentType: false,
                            processData: false,
                            success: function (resp) {
                                if (resp.isOk) {
                                    window.location.href = ""/products"";
                                }
                                else
                                    alert(""Ürün Kaydedilemedi"");
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
            WriteLiteral("\r\n<div class=\"col-md-12\">\r\n    <div class=\"card card-primary\">\r\n        <div class=\"card-header\">\r\n            <h3 class=\"card-title\">Yönetici Ürün Formu</h3>\r\n        </div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1122e819382f5e70cc53b7b1a0d4db0ae0451e056563", async() => {
                WriteLiteral(@"
            <div class=""card-body"">
                <div class=""form-group"">
                    <label>Ürün Adı</label>
                    <input type=""text"" class=""form-control"" id=""txtProductName"" placeholder=""Ürün Adı Giriniz"">
                </div>
                <div class=""form-group"">
                    <label>Fiyat</label>
                    <input type=""text"" class=""form-control"" id=""txtPrice"" placeholder=""Fiyat Giriniz"">
                </div>
                <div class=""form-group"">
                    <label>İndirim</label>
                    <input type=""text"" class=""form-control"" id=""txtDiscount"" placeholder=""İndirimit Giriniz"">
                </div>
                <div class=""form-group"">
                    <label>Ürün Açıklaması</label>
                    <textarea id=""txtShortDescription"" class=""form-control""></textarea>
                </div>
                <div class=""form-group"">
                    <label>Kategorisi</label>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1122e819382f5e70cc53b7b1a0d4db0ae0451e057870", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 88 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Areas\AdminPanel\Views\Product\New.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                <div class=""form-group"">
                    <label>Fotoğraflar</label>
                    <div class=""input-group"">
                        <div class=""custom-file"">
                            <input type=""file"" class=""custom-file-input"" id=""fuPhoto"" multiple>
                            <label class=""custom-file-label"">Fotoğraf Seç</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card-footer"">
                <button id=""btnSave"" type=""button"" class=""btn btn-primary"">Kaydet</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SelectListItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
