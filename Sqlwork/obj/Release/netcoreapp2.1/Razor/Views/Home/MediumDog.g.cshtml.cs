#pragma checksum "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\MediumDog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cb4e66220f6fccdafb7ebc9006a0c4b0c76bea1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MediumDog), @"mvc.1.0.view", @"/Views/Home/MediumDog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MediumDog.cshtml", typeof(AspNetCore.Views_Home_MediumDog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb4e66220f6fccdafb7ebc9006a0c4b0c76bea1", @"/Views/Home/MediumDog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fdc4b8ae803a813a9b13a498623c814119b9a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MediumDog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DBClassLibrary.ViewModels.DogViewModels>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\MediumDog.cshtml"
  
    ViewData["Title"] = "中型犬";

#line default
#line hidden
            BeginContext(93, 669, true);
            WriteLiteral(@"
<div id=""font-family-default"">
    <h2>中型犬</h2>
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
#line 20 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\MediumDog.cshtml"
         foreach (var temp in @Model)
        {

#line default
#line hidden
            BeginContext(812, 124, true);
            WriteLiteral("            <div class=\"col-sm-4 col-md-3\">\r\n                <div class=\"thumbnail\">\r\n                    <img class=\"large\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 936, "\"", 958, 1);
#line 24 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\MediumDog.cshtml"
WriteAttributeValue("", 942, temp.DogPicture, 942, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(959, 83, true);
            WriteLiteral(" alt=\"圖片\">\r\n                    <div class=\"caption\">\r\n                        <h3>");
            EndContext();
            BeginContext(1043, 12, false);
#line 26 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\MediumDog.cshtml"
                       Write(temp.DogKind);

#line default
#line hidden
            EndContext();
            BeginContext(1055, 34, true);
            WriteLiteral("</h3>\r\n                        <p>");
            EndContext();
            BeginContext(1090, 12, false);
#line 27 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\MediumDog.cshtml"
                      Write(temp.DogType);

#line default
#line hidden
            EndContext();
            BeginContext(1102, 33, true);
            WriteLiteral("</p>\r\n                        <p>");
            EndContext();
            BeginContext(1136, 16, false);
#line 28 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\MediumDog.cshtml"
                      Write(temp.DogFeature1);

#line default
#line hidden
            EndContext();
            BeginContext(1152, 65, true);
            WriteLiteral("</p>\r\n                        <p>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1217, "\"", 1271, 1);
#line 30 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\MediumDog.cshtml"
WriteAttributeValue("", 1224, Url.Action("Details", new { id = temp.DogId }), 1224, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1272, 215, true);
            WriteLiteral(" class=\"btn btn-default\" role=\"button\">\r\n                                詳細資訊\r\n                            </a>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 37 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\MediumDog.cshtml"
        }

#line default
#line hidden
            BeginContext(1498, 18, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DBClassLibrary.ViewModels.DogViewModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
