#pragma checksum "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3857142e23a6d36eb179ddc743d9bdb15df9605"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_Details), @"mvc.1.0.view", @"/Views/Film/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3857142e23a6d36eb179ddc743d9bdb15df9605", @"/Views/Film/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca35a71de2a90cee38a364687b87b31d35ea3e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Film_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/filmDetail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/filmDetail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b3857142e23a6d36eb179ddc743d9bdb15df96054440", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<!-- main start -->\r\n<main>\r\n\r\n    <!-- movie-information start -->\r\n\r\n    <section");
            BeginWriteAttribute("style", " style=\"", 196, "\"", 250, 3);
            WriteAttributeValue("", 204, "background-image:url(", 204, 21, true);
#nullable restore
#line 13 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
WriteAttributeValue("", 225, Model.ByFilm.CoverPhoto, 225, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 249, ")", 249, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" id=""Player"" class=""movie-information"">
        <div class=""container"">
            <div class=""row"">
                <div class=""all-inform"">
                    <div class=""play-ico"">
                        <i onclick=""toggle();"" class=""fad fa-play-circle""></i>
                        <span>watch trailer</span>
                    </div>
                    <div class=""movie-head"">
                        <h5>");
#nullable restore
#line 22 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                       Write(Model.ByFilm.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <div class=\"content\">\r\n                            <span><i class=\"fas fa-star\"></i>");
#nullable restore
#line 24 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                                                        Write(Model.ByFilm.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <ul>\r\n");
#nullable restore
#line 26 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                                   
                                  var filmCat=  Model.filmToCategories.Select(x => x.Category.CategoryName).Distinct().ToList();
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n");
#nullable restore
#line 30 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                                     foreach (var item in filmCat)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span> &nbsp;</span>");
#nullable restore
#line 32 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                                                                  ;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </li>\r\n                                <li>");
#nullable restore
#line 35 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                               Write(Model.ByFilm.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                <li>");
#nullable restore
#line 36 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                               Write(Model.ByFilm.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                <li>");
#nullable restore
#line 37 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                               Write(Model.ByFilm.AgeLimit);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" +</li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""overlay""></div>

            </div>
        </div>
    </section>
    <div class=""tag-video col-12 col-sm-12 col-md-12 col-xl-12"">
        <div class=""container"">
            <div class=""row"">
                <iframe id=""playerid"" width=""700"" height=""450""");
            BeginWriteAttribute("src", " src=\"", 1969, "\"", 2000, 1);
#nullable restore
#line 50 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
WriteAttributeValue("", 1975, Model.ByFilm.TrailerLink, 1975, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                        title=""TrailerAZ video player"" frameborder=""0""
                        allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture""
                        allowfullscreen></iframe>

                <i onclick=""toggle();"" class=""far fa-times-circle exit""></i>
            </div>
        </div>
    </div>

    <!-- movie-information end -->
    <!-- movie-on start -->
    <section class=""movie-on"">

        <div class=""container"">


            <iframe id=""playerid""");
            BeginWriteAttribute("src", " src=\"", 2547, "\"", 2575, 1);
#nullable restore
#line 67 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
WriteAttributeValue("", 2553, Model.ByFilm.MainLink, 2553, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" allowfullscreen=""true"" scrolling=""no"" style=""  height:390px; border:none; margin:auto; ; overflow:hidden; z-index:9;"" width=""70%""></iframe>
            <!-- <iframe id=""playerid"" width=""100%"" height=""390"" src=""hhttps://vidmoly.net/embed-ydjbid4y9qv0.html""
                title=""TrailerAZ video player"" frameborder=""0""
                allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture""
                allowfullscreen>
            </iframe> -->
            <div class=""col-12 col-sm-12 col-lg-6 col-xl-6 col-xxl-6 col-md-6"">
                <div class=""movie-about"">
                    <p>
                        ");
#nullable restore
#line 76 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                   Write(Model.ByFilm.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
            </div>
            <div class=""col-12"">
                <div class=""add-favorite"">
                    <i class=""fal fa-bookmark""></i>
                    <i class=""fal fa-heart""></i>
                    <i class=""far fa-retweet-alt""></i>
                </div>
            </div>
        </div>
    </section>
    <!-- movie-on end -->
    <!-- same category films start -->
");
#nullable restore
#line 91 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
     if (Model.SameCategoryFilms.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("style", " style=\"", 3789, "\"", 3855, 1);
#nullable restore
#line 93 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
WriteAttributeValue("", 3797, Model.SameCategoryFilms.Count==0? "display:none;": null, 3797, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"carousel\" data-gap=\"20\" data-bfc>\r\n            <h2>Same categories films</h2>\r\n\r\n            <figure>\r\n");
#nullable restore
#line 97 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                 foreach (var sameFilm in Model.SameCategoryFilms)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 4078, "\"", 4109, 1);
#nullable restore
#line 99 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
WriteAttributeValue("", 4084, sameFilm.Film.CoverPhoto, 4084, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4110, "\"", 4116, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 100 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </figure>\r\n            <div class=\"films\">\r\n\r\n");
#nullable restore
#line 106 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                 foreach (var SameFilm in Model.SameCategoryFilms)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 4310, "\"", 4373, 1);
#nullable restore
#line 108 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
WriteAttributeValue("", 4317, Url.Action("Details","Film", new { id=SameFilm.FilmID}), 4317, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 108 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                                                                                  Write(SameFilm.Film.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 109 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 113 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
             if (Model.SameCategoryFilms.Count <= 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <nav style=\"display:none;\">\r\n                    <button class=\"nav prev\">Prev</button>\r\n                    <button class=\"nav next\">Next</button>\r\n                </nav>\r\n");
#nullable restore
#line 119 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <nav>\r\n                    <button class=\"nav prev\">Prev</button>\r\n                    <button class=\"nav next\">Next</button>\r\n                </nav>\r\n");
#nullable restore
#line 126 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 129 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <!-- same category films end -->\r\n    <!--  same category-phone-slider start -->\r\n");
#nullable restore
#line 135 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
     if (Model.SameCategoryFilms.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <section");
            BeginWriteAttribute("style", " style=\"", 5117, "\"", 5183, 1);
#nullable restore
#line 137 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
WriteAttributeValue("", 5125, Model.SameCategoryFilms.Count==0? "display:none;": null, 5125, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""categorySame-phone"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""movie-category"">
                        <div class=""category-head"">
                            <h4>Same Categories Films</h4>

                        </div>
                        <div class=""category-card"">
");
#nullable restore
#line 146 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                             foreach (var sameFilm in Model.SameCategoryFilms)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card-detail\">\r\n                                    <div class=\"card-film\">\r\n\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 5813, "\"", 5839, 1);
#nullable restore
#line 151 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
WriteAttributeValue("", 5819, sameFilm.Film.Photo, 5819, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                             alt=\"", 5840, "\"", 5892, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"card-text\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 6007, "\"", 6071, 1);
#nullable restore
#line 154 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
WriteAttributeValue("", 6014, Url.Action("Details", "Film", new {id=sameFilm.FilmID }), 6014, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""play-btn fad fa-play-circle""></i></a>
                                        </div>

                                    </div>
                                    <div class=""category-altHead"">
                                        <h6>");
#nullable restore
#line 159 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                                       Write(sameFilm.Film.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 162 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 171 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n    <!-- same category-phone-slider end -->\r\n    <!-- feature films start -->\r\n\r\n    <section");
            BeginWriteAttribute("style", " style=\"", 6707, "\"", 6774, 1);
#nullable restore
#line 179 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
WriteAttributeValue("", 6715, Model.GetFilmsIsFeatured.Count==0? "display:none;": null, 6715, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""PluginOne"" class=""feature-slider"">
        <div class=""container"">
            <div class=""row"">
                <div class=""card-name"">
                    <h3>Featured Film & Movie</h3>
                </div>
                <div class=""all"">
");
#nullable restore
#line 186 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                     foreach (var film in Model.GetFilmsIsFeatured)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div  class=\"card-film\">\r\n\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 7208, "\"", 7225, 1);
#nullable restore
#line 190 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
WriteAttributeValue("", 7214, film.Photo, 7214, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 7226, "\"", 7266, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"card-text\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7357, "\"", 7413, 1);
#nullable restore
#line 193 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
WriteAttributeValue("", 7364, Url.Action("Details", "Film", new { id=film.ID}), 7364, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"play-btn fad fa-play-circle\"></i></a>\r\n                                <h5 style=\"display: none;\">");
#nullable restore
#line 194 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                                                      Write(film.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 197 "C:\Users\musal\source\repos\TrailerAZ\TrailerAZ\Views\Film\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                </div>
            </div>
        </div>
    </section>


    <!-- feature films end -->
    <!-- Comments start -->
    <!-- Comments end -->



</main>



<!-- main end -->
<div class=""container"">
    <div id=""disqus_thread""></div>

</div>

<script>
    window.addEventListener('message', receiveMessage, false);
    function receiveMessage(event) {
        if (event.data) {
            var msg;
            try {
                msg = JSON.parse(event.data);
            } catch (err) {
                // Do nothing
            }
            if (!msg) {
                return false;
            }
            if (msg.name === 'resize' || msg.name === 'rendered') {
                window.parent.postMessage({
                    sentinel: 'amp',
                    type: 'embed-size',
                    height: msg.data.height
                }, '*');
            }
        }
    }
</script>
<script>
    /**
    *  RECOMMENDED CONFIGURATION VARI");
            WriteLiteral(@"ABLES: EDIT AND UNCOMMENT THE SECTION BELOW TO INSERT DYNAMIC VALUES FROM YOUR PLATFORM OR CMS.
    *  LEARN WHY DEFINING THESE VARIABLES IS IMPORTANT: https://disqus.com/admin/universalcode/#configuration-variables
    */
    var disqus_config = function () {
        this.page.url = window.location;
        this.page.identifier = window.location.hash;
    };
    (function () {  // DON'T EDIT BELOW THIS LINE
        var d = document, s = d.createElement('script');

        s.src = '//traileraz.disqus.com/embed.js';

        s.setAttribute('data-timestamp', +new Date());
        (d.head || d.body).appendChild(s);
    })();
</script>

<div class=""container"">
    <amp-iframe width=50 height=240
                src=""https://example.com/amp#hash""
                layout=""responsive""
                sandbox=""allow-scripts allow-same-origin allow-modals allow-popups allow-forms""
                resizable>
        <div aria-label=""Load more""
             role=button
             tabindex=0
  ");
            WriteLiteral(@"           overflow
             style="" display:block;font-size:12px;font-weight:500;font-family:Helvetica Neue, arial, sans-serif;text-align:center;line-height:1.1;padding:12px 16px;border-radius:4px;background:rgba(29,47,58,0.6);color:rgb(255,255,255)"">
            Load more
        </div>
    </amp-iframe>
</div>
<script async custom-element=""amp-iframe"" src=""https://cdn.ampproject.org/v0/amp-iframe-0.1.js""></script>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3857142e23a6d36eb179ddc743d9bdb15df960526380", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
