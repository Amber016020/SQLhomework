#pragma checksum "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\SuperBigDog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d8c506849cd95d4d910e17b645eb0803f693f95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SuperBigDog), @"mvc.1.0.view", @"/Views/Home/SuperBigDog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SuperBigDog.cshtml", typeof(AspNetCore.Views_Home_SuperBigDog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d8c506849cd95d4d910e17b645eb0803f693f95", @"/Views/Home/SuperBigDog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fdc4b8ae803a813a9b13a498623c814119b9a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SuperBigDog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DBClassLibrary.ViewModels.DogViewModels>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\SuperBigDog.cshtml"
  
    ViewData["Title"] = "超大型犬";

#line default
#line hidden
            BeginContext(94, 1340, true);
            WriteLiteral(@"
<div id=""font-family-default"">
    <h2>超大型犬</h2>

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

    <!--<ul class=""nav nav-tabs"">
        <li><a data-toggle=""tab"" href=""#home"">Home</a></li>
        <li><a data-toggle=""tab"" href=""#menu1"">Page 1</a></li>
        <li><a data-toggle=""tab"" href=""#menu2"">Page 2</a></li>
        <li class=""dropdown"">
            <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#dog"">犬<span class=""caret""></span></a>
          ");
            WriteLiteral(@"  <ul class=""dropdown-menu"">
                <li><a data-toggle=""tab"" href=""#SmallDog"">小型犬</a></li>
                <li><a data-toggle=""tab"" href=""#MediumDog"">中型犬</a></li>
                <li><a data-toggle=""tab"" href=""#BigDog"">大型犬</a></li>
            </ul>
        </li>
    </ul>-->
    <div class=""row"">
");
            EndContext();
#line 35 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\SuperBigDog.cshtml"
         foreach (var temp in @Model)
        {

#line default
#line hidden
            BeginContext(1484, 124, true);
            WriteLiteral("            <div class=\"col-sm-4 col-md-3\">\r\n                <div class=\"thumbnail\">\r\n                    <img class=\"large\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1608, "\"", 1630, 1);
#line 39 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\SuperBigDog.cshtml"
WriteAttributeValue("", 1614, temp.DogPicture, 1614, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1631, 83, true);
            WriteLiteral(" alt=\"圖片\">\r\n                    <div class=\"caption\">\r\n                        <h3>");
            EndContext();
            BeginContext(1715, 12, false);
#line 41 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\SuperBigDog.cshtml"
                       Write(temp.DogKind);

#line default
#line hidden
            EndContext();
            BeginContext(1727, 34, true);
            WriteLiteral("</h3>\r\n                        <p>");
            EndContext();
            BeginContext(1762, 12, false);
#line 42 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\SuperBigDog.cshtml"
                      Write(temp.DogType);

#line default
#line hidden
            EndContext();
            BeginContext(1774, 33, true);
            WriteLiteral("</p>\r\n                        <p>");
            EndContext();
            BeginContext(1808, 16, false);
#line 43 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\SuperBigDog.cshtml"
                      Write(temp.DogFeature1);

#line default
#line hidden
            EndContext();
            BeginContext(1824, 65, true);
            WriteLiteral("</p>\r\n                        <p>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1889, "\"", 1943, 1);
#line 45 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\SuperBigDog.cshtml"
WriteAttributeValue("", 1896, Url.Action("Details", new { id = temp.DogId }), 1896, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1944, 215, true);
            WriteLiteral(" class=\"btn btn-default\" role=\"button\">\r\n                                詳細資訊\r\n                            </a>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 52 "E:\大學\大三資料庫專題\SQLhomework\Sqlwork\Views\Home\SuperBigDog.cshtml"
        }

#line default
#line hidden
            BeginContext(2170, 24, true);
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
