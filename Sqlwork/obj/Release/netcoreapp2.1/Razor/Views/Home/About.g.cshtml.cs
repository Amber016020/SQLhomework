#pragma checksum "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bde664cf4dda39b220612342b29ca50ab1dfc32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bde664cf4dda39b220612342b29ca50ab1dfc32", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fdc4b8ae803a813a9b13a498623c814119b9a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DBClassLibrary.ViewModels.AnimalViewModels>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\About.cshtml"
  
    ViewData["Title"] = "認養毛夥伴";

#line default
#line hidden
            BeginContext(105, 190, true);
            WriteLiteral("<div id=\"font-family-default\">\r\n    <h2>全部貓狗</h2>\r\n    <style>\r\n        img.large {\r\n            width: 200px;\r\n            height: 200px;\r\n        }\r\n    </style>\r\n\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 15 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\About.cshtml"
         foreach (var temp in Model)
        {

#line default
#line hidden
            BeginContext(344, 124, true);
            WriteLiteral("            <div class=\"col-sm-4 col-md-3\">\r\n                <div class=\"thumbnail\">\r\n                    <img class=\"large\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 468, "\"", 496, 1);
#line 19 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\About.cshtml"
WriteAttributeValue("", 474, temp.animal.AlbumFile, 474, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(497, 85, true);
            WriteLiteral(" alt=\"圖片\" />\r\n                    <div class=\"caption\">\r\n                        <h3>");
            EndContext();
            BeginContext(583, 22, false);
#line 21 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\About.cshtml"
                       Write(temp.animal.AnimalKind);

#line default
#line hidden
            EndContext();
            BeginContext(605, 37, true);
            WriteLiteral("</h3>\r\n                        <p>性別：");
            EndContext();
            BeginContext(643, 26, false);
#line 22 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\About.cshtml"
                         Write(temp.animaldetal.AnimalSex);

#line default
#line hidden
            EndContext();
            BeginContext(669, 36, true);
            WriteLiteral("</p>\r\n                        <p>年紀：");
            EndContext();
            BeginContext(706, 26, false);
#line 23 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\About.cshtml"
                         Write(temp.animaldetal.AnimalAge);

#line default
#line hidden
            EndContext();
            BeginContext(732, 36, true);
            WriteLiteral("</p>\r\n                        <p>體型：");
            EndContext();
            BeginContext(769, 31, false);
#line 24 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\About.cshtml"
                         Write(temp.animaldetal.AnimalBodytype);

#line default
#line hidden
            EndContext();
            BeginContext(800, 38, true);
            WriteLiteral("</p>\r\n                        <p>所在縣市：");
            EndContext();
            BeginContext(839, 18, false);
#line 25 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\About.cshtml"
                           Write(temp.area.AreaName);

#line default
#line hidden
            EndContext();
            BeginContext(857, 38, true);
            WriteLiteral("</p>\r\n                        <p>領養狀態：");
            EndContext();
            BeginContext(896, 24, false);
#line 26 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\About.cshtml"
                           Write(temp.animal.AnimalStatus);

#line default
#line hidden
            EndContext();
            BeginContext(920, 35, true);
            WriteLiteral("</p>\r\n                        <p>\r\n");
            EndContext();
            BeginContext(1045, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1075, "\"", 1145, 1);
#line 29 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\About.cshtml"
WriteAttributeValue("", 1082, Url.Action("AnimalDetails", new { id = temp.animal.AnimalId }), 1082, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1146, 215, true);
            WriteLiteral(" class=\"btn btn-default\" role=\"button\">\r\n                                詳細資訊\r\n                            </a>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 36 "C:\inetpub\wwwroot\SQLhomework\Sqlwork\Views\Home\About.cshtml"
        }

#line default
#line hidden
            BeginContext(1372, 18, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DBClassLibrary.ViewModels.AnimalViewModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
