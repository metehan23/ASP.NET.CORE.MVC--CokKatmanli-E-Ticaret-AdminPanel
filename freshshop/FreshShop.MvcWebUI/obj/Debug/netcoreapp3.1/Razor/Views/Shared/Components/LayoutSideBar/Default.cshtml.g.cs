#pragma checksum "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Views\Shared\Components\LayoutSideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2710463a2966a35db972a25996a7787722be5ed3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LayoutSideBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LayoutSideBar/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Views\_ViewImports.cshtml"
using FreshShop.MvcWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Views\_ViewImports.cshtml"
using FreshShop.MvcWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2710463a2966a35db972a25996a7787722be5ed3", @"/Views/Shared/Components/LayoutSideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d80f3cfdb47ad5ce4c8ebac62e7e1bfcb627c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LayoutSideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FreshShop.Model.Entity.Manager>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"user-panel mt-3 pb-3 mb-3 d-flex\">\r\n        <div class=\"image\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 140, "\"", 162, 1);
#nullable restore
#line 6 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Views\Shared\Components\LayoutSideBar\Default.cshtml"
WriteAttributeValue("", 146, Model.PhotoPath, 146, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-circle elevation-2\" alt=\"User Image\">\r\n        </div>\r\n        <div class=\"info\">\r\n            <a href=\"#\" class=\"d-block\">");
#nullable restore
#line 9 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\FreshShop\FreshShop.MvcWebUI\Views\Shared\Components\LayoutSideBar\Default.cshtml"
                                   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
        </div>
    </div>

    <nav class=""mt-2"">
        <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
            <li class=""nav-item has-treeview menu-open"">
                <a href=""#"" class=""nav-link active"">
                    <i class=""nav-icon fas fa-tachometer-alt""></i>
                    <p>
                        Menü
                        <i class=""right fas fa-angle-left""></i>
                    </p>
                </a>
                <ul class=""nav nav-treeview"">
                    <li class=""nav-item"">
                        <a href=""/managers"" class=""nav-link active"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Yöneticiler</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/categories"" class=""nav-link"">
                            <i class=""far fa-circle nav-i");
            WriteLiteral(@"con""></i>
                            <p>Kategoriler</p>
                        </a>
                    </li>

                    <li class=""nav-item"">
                        <a href=""/products"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Ürünler</p>
                        </a>
                    </li>
                </ul>
            </li>
        </ul>
    </nav>
 
         
           
       
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreshShop.Model.Entity.Manager> Html { get; private set; }
    }
}
#pragma warning restore 1591
