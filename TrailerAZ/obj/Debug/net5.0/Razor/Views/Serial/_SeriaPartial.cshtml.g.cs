#pragma checksum "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Serial\_SeriaPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8be765a1e94f9d5b055b9a23a64a47cb88ef955c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Serial__SeriaPartial), @"mvc.1.0.view", @"/Views/Serial/_SeriaPartial.cshtml")]
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
#line 1 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\_ViewImports.cshtml"
using TrailerAZ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\_ViewImports.cshtml"
using TrailerAZ.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\_ViewImports.cshtml"
using TrailerAZ.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be765a1e94f9d5b055b9a23a64a47cb88ef955c", @"/Views/Serial/_SeriaPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca35a71de2a90cee38a364687b87b31d35ea3e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Serial__SeriaPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.SerialSerie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Serial\_SeriaPartial.cshtml"
 foreach (var seria in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-detail\">\r\n        <div class=\"card-film\">\r\n            <img");
            BeginWriteAttribute("src", "  src=\"", 168, "\"", 194, 1);
#nullable restore
#line 12 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Serial\_SeriaPartial.cshtml"
WriteAttributeValue("", 175, seria.Serial.Photo, 175, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 195, "\"", 201, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-text\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 260, "\"", 325, 1);
#nullable restore
#line 14 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Serial\_SeriaPartial.cshtml"
WriteAttributeValue("", 267, Url.Action("Details", "Serial", new { seriaId=seria.ID }), 267, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"play-btn fad fa-play-circle\"></i></a>\r\n            </div>\r\n        </div>\r\n        <div class=\"series-num\">\r\n            <h6> serie ");
#nullable restore
#line 18 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Serial\_SeriaPartial.cshtml"
                  Write(seria.Serie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Serial\_SeriaPartial.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.SerialSerie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
