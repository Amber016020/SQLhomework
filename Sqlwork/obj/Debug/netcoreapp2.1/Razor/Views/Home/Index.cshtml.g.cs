#pragma checksum "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c24b7f7470ae9c98c6ad20947488b9e9baaeac6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c24b7f7470ae9c98c6ad20947488b9e9baaeac6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fdc4b8ae803a813a9b13a498623c814119b9a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DBClassLibrary.ViewModels.DogViewModels>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "犬種介紹";

#line default
#line hidden
            BeginContext(94, 761, true);
            WriteLiteral(@"
<div id=""font-family-default"">
    <h2>犬種</h2>
    <style>
        .ProductImg {
            height: 300px;
        }
    </style>

    <ul class=""nav nav-tabs"">
        <li class=""dropdown"">
            <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#dog"">犬<span class=""caret""></span></a>
            <ul class=""dropdown-menu"">
                <li><a href=""/SQLhomework/home/SmallDog"">小型犬</a></li><!--<a data-toggle=""tab"" href=""#SmallDog"">小型犬</a>-->
                <li><a href=""/SQLhomework/home/MediumDog"">中型犬</a></li>
                <li><a href=""/SQLhomework/home/BigDog"">大型犬</a></li>
                <li><a href=""/SQLhomework/home/SuperBigDog"">超大型犬</a></li>
            </ul>
        </li>
    </ul>

    <div class=""row"">
");
            EndContext();
#line 27 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\Index.cshtml"
         foreach (var temp in @Model)
        {

#line default
#line hidden
            BeginContext(905, 129, true);
            WriteLiteral("            <div class=\"col-sm-4 col-md-3\">\r\n                <div class=\"thumbnail\">\r\n                    <img class=\"ProductImg\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1034, "\"", 1056, 1);
#line 31 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\Index.cshtml"
WriteAttributeValue("", 1040, temp.DogPicture, 1040, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1057, 83, true);
            WriteLiteral(" alt=\"圖片\">\r\n                    <div class=\"caption\">\r\n                        <h3>");
            EndContext();
            BeginContext(1141, 12, false);
#line 33 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\Index.cshtml"
                       Write(temp.DogKind);

#line default
#line hidden
            EndContext();
            BeginContext(1153, 34, true);
            WriteLiteral("</h3>\r\n                        <p>");
            EndContext();
            BeginContext(1188, 12, false);
#line 34 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\Index.cshtml"
                      Write(temp.DogType);

#line default
#line hidden
            EndContext();
            BeginContext(1200, 33, true);
            WriteLiteral("</p>\r\n                        <p>");
            EndContext();
            BeginContext(1234, 16, false);
#line 35 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\Index.cshtml"
                      Write(temp.DogFeature1);

#line default
#line hidden
            EndContext();
            BeginContext(1250, 65, true);
            WriteLiteral("</p>\r\n                        <p>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1315, "\"", 1369, 1);
#line 37 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\Index.cshtml"
WriteAttributeValue("", 1322, Url.Action("Details", new { id = temp.DogId }), 1322, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1370, 215, true);
            WriteLiteral(" class=\"btn btn-default\" role=\"button\">\r\n                                詳細資訊\r\n                            </a>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 44 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1596, 24, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DBClassLibrary.ViewModels.DogViewModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
