#pragma checksum "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\LongHair.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36ee459fa9fb4e10b4644e70c6fd2a966966ed32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LongHair), @"mvc.1.0.view", @"/Views/Home/LongHair.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LongHair.cshtml", typeof(AspNetCore.Views_Home_LongHair))]
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
#line 1 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\_ViewImports.cshtml"
using Sqlwork;

#line default
#line hidden
#line 2 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\_ViewImports.cshtml"
using Sqlwork.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ee459fa9fb4e10b4644e70c6fd2a966966ed32", @"/Views/Home/LongHair.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fdc4b8ae803a813a9b13a498623c814119b9a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LongHair : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DBClassLibrary.ViewModels.CatViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\LongHair.cshtml"
  
    ViewData["Title"] = "長毛貓";

#line default
#line hidden
            BeginContext(92, 711, true);
            WriteLiteral(@"
<div id=""font-family-default"">
    <h2>長毛貓</h2>
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
#line 25 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\LongHair.cshtml"
         foreach (var temp in @Model)
        {

#line default
#line hidden
            BeginContext(853, 124, true);
            WriteLiteral("            <div class=\"col-sm-4 col-md-3\">\r\n                <div class=\"thumbnail\">\r\n                    <img class=\"large\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 977, "\"", 999, 1);
#line 29 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\LongHair.cshtml"
WriteAttributeValue("", 983, temp.CatPicture, 983, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1000, 83, true);
            WriteLiteral(" alt=\"圖片\">\r\n                    <div class=\"caption\">\r\n                        <h3>");
            EndContext();
            BeginContext(1084, 12, false);
#line 31 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\LongHair.cshtml"
                       Write(temp.CatKind);

#line default
#line hidden
            EndContext();
            BeginContext(1096, 34, true);
            WriteLiteral("</h3>\r\n                        <p>");
            EndContext();
            BeginContext(1131, 12, false);
#line 32 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\LongHair.cshtml"
                      Write(temp.CatHair);

#line default
#line hidden
            EndContext();
            BeginContext(1143, 65, true);
            WriteLiteral("</p>\r\n                        <p>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1208, "\"", 1277, 1);
#line 34 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\LongHair.cshtml"
WriteAttributeValue("", 1215, Url.Action("CatIntroductionDetails", new { id = temp.CatId }), 1215, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1278, 215, true);
            WriteLiteral(" class=\"btn btn-default\" role=\"button\">\r\n                                詳細資訊\r\n                            </a>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 41 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\LongHair.cshtml"
        }

#line default
#line hidden
            BeginContext(1504, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
