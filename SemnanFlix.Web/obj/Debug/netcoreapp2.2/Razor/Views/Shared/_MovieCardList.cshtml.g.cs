#pragma checksum "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "769d9df3456bcd7024b4f815367cbf5aaa7d228d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MovieCardList), @"mvc.1.0.view", @"/Views/Shared/_MovieCardList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_MovieCardList.cshtml", typeof(AspNetCore.Views_Shared__MovieCardList))]
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
#line 1 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using SemnanFlix;

#line default
#line hidden
#line 2 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using SemnanFlix.ViewModels;

#line default
#line hidden
#line 3 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using SemnanFlix.ViewModels.Account;

#line default
#line hidden
#line 4 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using SemnanFlix.ViewModels.Manage;

#line default
#line hidden
#line 5 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
using SemnanFlix.Common.Utilities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"769d9df3456bcd7024b4f815367cbf5aaa7d228d", @"/Views/Shared/_MovieCardList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa6f439dba39d5d7130eb680c45ba14b0891373", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MovieCardList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SemnanFlix.ViewModels.Movie.MovieViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: black; text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(95, 117, true);
            WriteLiteral("\r\n<div class=\"mx-auto d-flex flex-wrap justify-content-center justify-content-lg-start\" style=\"max-width: 1088px;\">\r\n");
            EndContext();
#line 6 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
     foreach (var movie in Model)
    {

#line default
#line hidden
            BeginContext(254, 102, true);
            WriteLiteral("        <div class=\"card movie-card m-3\"\r\n             style=\"width: 15rem;\"\r\n             data-name=\"");
            EndContext();
            BeginContext(357, 10, false);
#line 10 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                   Write(movie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(367, 27, true);
            WriteLiteral("\"\r\n             data-date=\"");
            EndContext();
            BeginContext(396, 66, false);
#line 11 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                    Write(((DateTimeOffset)movie.ReleaseDate).ToUnixTimeSeconds().ToString());

#line default
#line hidden
            EndContext();
            BeginContext(463, 28, true);
            WriteLiteral("\"\r\n             data-price=\"");
            EndContext();
            BeginContext(492, 14, false);
#line 12 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                    Write(movie.RentCost);

#line default
#line hidden
            EndContext();
            BeginContext(506, 36, true);
            WriteLiteral("\"\r\n             data-purchase-date=\"");
            EndContext();
            BeginContext(543, 24, false);
#line 13 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                            Write(movie.PurchaseDateString);

#line default
#line hidden
            EndContext();
            BeginContext(567, 16, true);
            WriteLiteral("\">\r\n            ");
            EndContext();
            BeginContext(583, 1123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "769d9df3456bcd7024b4f815367cbf5aaa7d228d7157", async() => {
                BeginContext(697, 43, true);
                WriteLiteral("\r\n                <img class=\"card-img-top\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 740, "\"", 761, 1);
#line 15 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
WriteAttributeValue("", 746, movie.ImageUrl, 746, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(762, 85, true);
                WriteLiteral(">\r\n                <div class=\"card-body\" style=\"padding-bottom: 0; height: 44px;\">\r\n");
                EndContext();
#line 17 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                     if (movie.Name.Count() > 20)
                    {

#line default
#line hidden
                BeginContext(921, 52, true);
                WriteLiteral("                        <h6 class=\"card-title mb-0\">");
                EndContext();
                BeginContext(974, 10, false);
#line 19 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                                               Write(movie.Name);

#line default
#line hidden
                EndContext();
                BeginContext(984, 7, true);
                WriteLiteral("</h6>\r\n");
                EndContext();
#line 20 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(1063, 52, true);
                WriteLiteral("                        <h5 class=\"card-title mb-0\">");
                EndContext();
                BeginContext(1116, 10, false);
#line 23 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                                               Write(movie.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1126, 7, true);
                WriteLiteral("</h5>\r\n");
                EndContext();
#line 24 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                    }

#line default
#line hidden
                BeginContext(1156, 221, true);
                WriteLiteral("                </div>\r\n                <div class=\"card-footer text-muted\" style=\"background: none; border-top: none;\">\r\n                    <div class=\"d-flex\">\r\n                        <p class=\"card-text mb-0\"><small>");
                EndContext();
                BeginContext(1378, 38, false);
#line 28 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                                                    Write(movie.ReleaseDate.ToCustomDateString());

#line default
#line hidden
                EndContext();
                BeginContext(1416, 14, true);
                WriteLiteral("</small></p>\r\n");
                EndContext();
#line 29 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                         if (!(bool)ViewData["OnlyPurchasedMovies"])
                        {

#line default
#line hidden
                BeginContext(1527, 63, true);
                WriteLiteral("                            <p class=\"card-text ml-auto mb-0\">$");
                EndContext();
                BeginContext(1591, 14, false);
#line 31 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                                                          Write(movie.RentCost);

#line default
#line hidden
                EndContext();
                BeginContext(1605, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 32 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                        }

#line default
#line hidden
                BeginContext(1638, 64, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
                                                          WriteLiteral(movie.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1706, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 37 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_MovieCardList.cshtml"
    }

#line default
#line hidden
            BeginContext(1731, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SemnanFlix.ViewModels.Movie.MovieViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
