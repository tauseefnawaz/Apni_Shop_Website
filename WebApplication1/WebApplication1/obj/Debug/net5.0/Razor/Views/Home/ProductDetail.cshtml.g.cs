#pragma checksum "C:\Users\tauseefnawaz\source\repos\WebApplication1\WebApplication1\Views\Home\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59bb68dabf5fb9fcc2f9aa4a87fd74e148d6f9e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetail), @"mvc.1.0.view", @"/Views/Home/ProductDetail.cshtml")]
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
#line 1 "C:\Users\tauseefnawaz\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tauseefnawaz\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59bb68dabf5fb9fcc2f9aa4a87fd74e148d6f9e4", @"/Views/Home/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MultipleData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <div class=\"carousel slide\" data-ride=\"carousel\">\r\n            <div class=\"carousel-inner w-100 h-75\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 200, "\"", 315, 1);
#nullable restore
#line 6 "C:\Users\tauseefnawaz\source\repos\WebApplication1\WebApplication1\Views\Home\ProductDetail.cshtml"
WriteAttributeValue("", 206, string.IsNullOrEmpty(Model.product.ImageName) ? "/images/noimage.png" : "/images/"+Model.product.ImageName, 206, 109, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block w-200 h-100"" ) />
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""border border-dark rounded"" style=""padding:20px"">
            <p class=""price font-weight-bolder justify-content-center"" style=""font-size:60px"">
                Rs. ");
#nullable restore
#line 13 "C:\Users\tauseefnawaz\source\repos\WebApplication1\WebApplication1\Views\Home\ProductDetail.cshtml"
               Write(Model.product.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <p class=\"price text-secondary font-italic font-weight-normal justify-content-center\" style=\"font-size:20px\">\r\n                ");
#nullable restore
#line 16 "C:\Users\tauseefnawaz\source\repos\WebApplication1\WebApplication1\Views\Home\ProductDetail.cshtml"
           Write(Model.product.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
        </div>
        <div class=""border border-dark rounded"" style=""padding:20px"">
            <p class=""price font-weight-bolder justify-content-center"" style=""font-size:30px"">
                Seller description
            </p>
            <div class=""row"">
                <p class=""dropdown-item font-weight-bolder"" data-toggle=""modal"" data-target=""#profile-modal"" style=""height:20px;width:40px;font-size:25px;"">
                    <i class=""fa fa-user""></i>  ");
#nullable restore
#line 25 "C:\Users\tauseefnawaz\source\repos\WebApplication1\WebApplication1\Views\Home\ProductDetail.cshtml"
                                           Write(Model.user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\tauseefnawaz\source\repos\WebApplication1\WebApplication1\Views\Home\ProductDetail.cshtml"
                                                                 Write(Model.user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
            <div class=""row"">
                <button type=""button"" class=""btn btn-dark btn-block"">Call me</button>
            </div>

            <div class=""row justify-content-center"">
                <p class=""col "" style=""margin-top:10px;padding:10px"">
                    <i class=""material-icons"" style=""font-size:36px"">call</i>
                </p>
                <p class=""col-3 font-weight-normal"" style=""padding-top: 25px; font-size: 18px"">
                    ");
#nullable restore
#line 37 "C:\Users\tauseefnawaz\source\repos\WebApplication1\WebApplication1\Views\Home\ProductDetail.cshtml"
               Write(Model.user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
        </div>
    </div>

<div class=""row"" style=""margin-top: 20px; margin-left: 0; margin-right: 10px;"">
    <div class=""col-md-8 border border-dark rounded"" style=""padding:20px"">
        <p class=""description font-weight-normal"" style=""border-width:5px;font-size:20px;"">
            ");
#nullable restore
#line 46 "C:\Users\tauseefnawaz\source\repos\WebApplication1\WebApplication1\Views\Home\ProductDetail.cshtml"
       Write(Model.product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n<style>\r\n    img {\r\n        width: 100%;\r\n        height: 100%;\r\n    }\r\n    body{\r\n        margin:20px;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MultipleData> Html { get; private set; }
    }
}
#pragma warning restore 1591
