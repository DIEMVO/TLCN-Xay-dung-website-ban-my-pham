#pragma checksum "D:\WebMyPham\WebMyPham.WebApp\Views\Shared\Components\SideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32846c95ff430cbf1fac9da37d8dcc4164c0b019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideBar/Default.cshtml")]
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
#line 1 "D:\WebMyPham\WebMyPham.WebApp\Views\_ViewImports.cshtml"
using WebMyPham.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebMyPham\WebMyPham.WebApp\Views\_ViewImports.cshtml"
using WebMyPham.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32846c95ff430cbf1fac9da37d8dcc4164c0b019", @"/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e015ead6ee395342c241ca3717bf78f082099abc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebMyPham.ViewModels.Catalog.Categories.CategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""sidebar"" class=""span3"">
    <div class=""well well-small""><a id=""myCart"" href=""product_summary.html""><img src=""/themes/images/ico-cart.png"" alt=""cart"">3 Items in your cart  <span class=""badge badge-warning pull-right"">$155.00</span></a></div>
    <ul id=""sideManu"" class=""nav nav-tabs nav-stacked"">
");
#nullable restore
#line 6 "D:\WebMyPham\WebMyPham.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
          
            var parents = Model.Where(x => x.ParentId == null);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WebMyPham\WebMyPham.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
         for (int index = 0; index < parents.Count(); index++)
        {
            var parent = parents.ElementAt(index);
            var children = Model.Where(x => x.ParentId == parent.Id);
            if (children.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"subMenu open\">\r\n                    <a> ");
#nullable restore
#line 16 "D:\WebMyPham\WebMyPham.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
                   Write(parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <ul>\r\n");
#nullable restore
#line 18 "D:\WebMyPham\WebMyPham.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
                         foreach (var item in children)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a class=\"active\"");
            BeginWriteAttribute("href", " href=\"", 962, "\"", 987, 2);
            WriteAttributeValue("", 969, "/danh-muc/", 969, 10, true);
#nullable restore
#line 20 "D:\WebMyPham\WebMyPham.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 979, item.Id, 979, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-chevron-right\"></i>");
#nullable restore
#line 20 "D:\WebMyPham\WebMyPham.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
                                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></li>\r\n");
#nullable restore
#line 21 "D:\WebMyPham\WebMyPham.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </li>\r\n");
#nullable restore
#line 24 "D:\WebMyPham\WebMyPham.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 1192, "\"", 1219, 2);
            WriteAttributeValue("", 1199, "/danh-muc/", 1199, 10, true);
#nullable restore
#line 27 "D:\WebMyPham\WebMyPham.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 1209, parent.Id, 1209, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "D:\WebMyPham\WebMyPham.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
                                              Write(parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 28 "D:\WebMyPham\WebMyPham.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </ul>
    <br />
    <div class=""thumbnail"">
            <img src=""/themes/images/products/panasonic.jpg"" alt=""Bootshop panasonoc New camera"" />
            <div class=""caption"">
                <h5>Panasonic</h5>
                <h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">$222.00</a></h4>
            </div>
        </div><br />
        <div class=""thumbnail"">
            <img src=""/themes/images/products/kindle.png"" title=""Bootshop New Kindel"" alt=""Bootshop Kindel"">
            <div class=""caption"">
                <h5>Kindle</h5>
                <h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">$222.00</a></h4>
            </div>
        </div><br />
        <di");
            WriteLiteral(@"v class=""thumbnail"">
            <img src=""/themes/images/payment_methods.png"" title=""Bootshop Payment Methods"" alt=""Payments Methods"">
            <div class=""caption"">
                <h5>Payment Methods</h5>
            </div>
        </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebMyPham.ViewModels.Catalog.Categories.CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
