#pragma checksum "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\SpooltHairs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa3555b3ad28a8bf0f794cd4ade682219fb4d89a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SpooltHairs), @"mvc.1.0.view", @"/Views/Home/SpooltHairs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SpooltHairs.cshtml", typeof(AspNetCore.Views_Home_SpooltHairs))]
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
#line 1 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\_ViewImports.cshtml"
using Sqlwork;

#line default
#line hidden
#line 2 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\_ViewImports.cshtml"
using Sqlwork.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa3555b3ad28a8bf0f794cd4ade682219fb4d89a", @"/Views/Home/SpooltHairs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fdc4b8ae803a813a9b13a498623c814119b9a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SpooltHairs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DBClassLibrary.ViewModels.CatViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\SpooltHairs.cshtml"
  
    ViewData["Title"] = "捲毛貓";

#line default
#line hidden
            BeginContext(92, 641, true);
            WriteLiteral(@"
<div id=""font-family-default"">
<h2>捲毛貓</h2>
<style>
    img.large {
        width: 100px;
        height: 100px;
    }
</style>
<ul class=""nav nav-tabs"">
    <li class=""dropdown"">
        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#cat"">貓<span class=""caret""></span></a>
        <ul class=""dropdown-menu"">
            <li><a href=""/SQLhomework/home/LongHair"">長毛</a></li><!--<a data-toggle=""tab"" href=""#SmallDog"">小型犬</a>-->
            <li><a href=""/SQLhomework/home/ShortHairs"">短毛</a></li>
            <li><a href=""/SQLhomework/home/SpooltHairs"">捲毛</a></li>
        </ul>
    </li>
</ul>

<div class=""row"">
");
            EndContext();
#line 26 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\SpooltHairs.cshtml"
     foreach (var temp in @Model)
    {

#line default
#line hidden
            BeginContext(775, 112, true);
            WriteLiteral("        <div class=\"col-sm-4 col-md-3\">\r\n            <div class=\"thumbnail\">\r\n                <img class=\"large\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 887, "\"", 909, 1);
#line 30 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\SpooltHairs.cshtml"
WriteAttributeValue("", 893, temp.CatPicture, 893, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(910, 75, true);
            WriteLiteral(" alt=\"圖片\">\r\n                <div class=\"caption\">\r\n                    <h3>");
            EndContext();
            BeginContext(986, 12, false);
#line 32 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\SpooltHairs.cshtml"
                   Write(temp.CatKind);

#line default
#line hidden
            EndContext();
            BeginContext(998, 30, true);
            WriteLiteral("</h3>\r\n                    <p>");
            EndContext();
            BeginContext(1029, 12, false);
#line 33 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\SpooltHairs.cshtml"
                  Write(temp.CatHair);

#line default
#line hidden
            EndContext();
            BeginContext(1041, 57, true);
            WriteLiteral("</p>\r\n                    <p>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1098, "\"", 1167, 1);
#line 35 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\SpooltHairs.cshtml"
WriteAttributeValue("", 1105, Url.Action("CatIntroductionDetails", new { id = temp.CatId }), 1105, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1168, 191, true);
            WriteLiteral(" class=\"btn btn-default\" role=\"button\">\r\n                            詳細資訊\r\n                        </a>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 42 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\SpooltHairs.cshtml"
    }

#line default
#line hidden
            BeginContext(1366, 14, true);
            WriteLiteral("</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DBClassLibrary.ViewModels.CatViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
